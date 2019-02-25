namespace WebApp
{
    public class ApiOptions
    {
        public ApiOptions()
        { }

        public string BaseAddress { get; set; }

        public string SpeakersEndpoint
        {
            get
            {
                return BaseAddress + "/api/speakers";
            }
        }

        public string SessionsEndpoint
        {
            get
            {
                return BaseAddress + "/api/sessions";
            }
        }
    }
}
