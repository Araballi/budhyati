namespace SampleCallRestAPI
{
    internal class LinkRequest
    {
        public string source { get; set; } = "LINK";
        public string destination { get; set; } = "+4799999999";
        public string userData { get; set; } = "Hello world";
        public string platformId { get; set; } = "";
        public string platformPartnerId { get; set; } = "";
        public string useDeliveryReport { get; set; } = "false";
        public string refId { get; set; } = "dfasdfa";
        public CustomParameters customParameters { get; set; } = new CustomParameters();

    }
}
