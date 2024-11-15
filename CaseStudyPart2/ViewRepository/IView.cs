using CaseStudyPart2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyPart2.ViewRepository
{
    public interface IView
    {
        public List<View> Getdata();
    }
}
