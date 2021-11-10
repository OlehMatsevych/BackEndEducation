namespace ReflectionTest
{
    public partial class StringHandler
    {
        public string Text { get; set; }
        public StringHandler(string text)
        {
            Text = text;
        }
        public string GetUpperText() =>
            Text.ToUpper();
        private string GetLowerText() =>
            Text.ToLower();
    }
}
