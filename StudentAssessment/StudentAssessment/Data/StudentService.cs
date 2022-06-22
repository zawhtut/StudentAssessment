namespace StudentAssessment.Data
{
    public class StudentService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public StudentService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
    }
}
