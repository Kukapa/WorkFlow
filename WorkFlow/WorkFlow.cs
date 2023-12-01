namespace WorkFlowEng
{
    class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _Activties;

        public WorkFlow()
        {
            _Activties = new List<IActivity>();
        }

        public void DeRegisterActivity(IActivity Activity)
        {
            _Activties.Remove(Activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _Activties;
        }

        public void RegisterActivity(IActivity Activity)
        {
            _Activties.Add(Activity);

        }
    }
}
