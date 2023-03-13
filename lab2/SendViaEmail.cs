namespace lab2
{
    internal class SendViaEmail
    {
        private string email;

        public SendViaEmail(string email)
        {
            this.email = email;
        }

        public string Email { get; internal set; }
    }
}