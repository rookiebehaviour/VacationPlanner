namespace BlazorApp.Data
{
    public class ProfileService
    {
    public string? UserName { get; set; }
        public string? Destination { get; set; }

        public bool HasUserProvidedInfo { get; private set; }

        public void SetUserProvidedInfo(bool provided)
        {
            HasUserProvidedInfo = provided;
        }

        public bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(UserName) && string.IsNullOrWhiteSpace(Destination);
        }

    }

}

