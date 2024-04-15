using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            try
            {
                string userName = txtusername.Text;
                string email = txtemail.Text;
                string role = cborole.Text;

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsEmailDuplicate(email))
                {
                    MessageBox.Show("User with this email already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection conn = new(GetConnectionString._connStr);
                conn.Open();

                string query = @"INSERT INTO Users (UserName, Email, UserRole, IsActive)
VALUES(@UserName, @Email, @UserRole, @IsActive)";

                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@UserRole", role);
                cmd.Parameters.AddWithValue("@IsActive", true);

                int result = cmd.ExecuteNonQuery();

                conn.Close();

                if (result > 0)
                {
                    Clear();
                    DialogResult dialog = MessageBox.Show("Creating Successful!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Clear();
                    MessageBox.Show("Creating Fail!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private bool IsEmailDuplicate(string Email)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._connStr);
                conn.Open();
                string query = @"SELECT UserId, UserName, Email, UserRole, IsActive
FROM Users WHERE Email = @Email AND IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@IsActive", true);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Clear()
        {
            txtusername.Text = "";
            txtemail.Text = string.Empty;
            cborole.Text = string.Empty;
        }
    }
}
