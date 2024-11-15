using CaseStudyPart2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyPart2.ViewRepository
{
    public class ViewOperations : IView
    {
        ApplicationDBContext _dbContext;
        public ViewOperations(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<View> Getdata()
        {
            List<View> result = _dbContext.vuMergeData.ToList();
            return result;
        }
    }
}
