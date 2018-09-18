using MyPrivate.Nuget.Contracts;

namespace App.ServiceLibrary
{
    public class ClassService : IClassService
    {
        private readonly IMyPrivate _prv;

        public ClassService(IMyPrivate prv)
        {
            _prv = prv;
        }

        public void DoWork()
        {
            _prv.DoWork();
        }

    }
}
