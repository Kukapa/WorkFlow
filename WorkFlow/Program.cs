namespace WorkFlowEng
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            var EncodeVideos = new WorkFlow();

            EncodeVideos.RegisterActivity(new UploadVideo());
            EncodeVideos.RegisterActivity(new NotifyService());
            EncodeVideos.RegisterActivity(new SendEmailToUser());
            EncodeVideos.RegisterActivity(new ChangeVideoStatus());
            workFlowEngine.Run(EncodeVideos);
        }
    }
}