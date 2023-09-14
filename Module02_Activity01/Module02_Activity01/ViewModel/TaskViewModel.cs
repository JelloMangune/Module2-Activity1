using System;
using System.Collections.Generic;
using System.Text;
using Module02_Activity01.Model;


namespace Module02_Activity01.ViewModel
{
    class TaskViewModel
    {
        public Taskmodel TaskModelSet { get; set; }
        public TaskViewModel()
        {
            TaskModelSet = new Taskmodel
            {
                SubjectCode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}

