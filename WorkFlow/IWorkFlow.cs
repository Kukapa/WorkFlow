namespace WorkFlowEng
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActivity Activity);
        IEnumerable<IActivity> GetActivities();
        void DeRegisterActivity(IActivity Activity);
    }
}
