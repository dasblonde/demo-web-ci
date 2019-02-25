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
                //TODO: restore next line
                //return BaseAddress + "/api/speakers";
                return "/api/speakers";
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
