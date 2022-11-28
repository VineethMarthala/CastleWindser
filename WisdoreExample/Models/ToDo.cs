using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WisdoreExample.Models
{
    

    public class ToDoListServiceImpl : ToDoListService
    {
        public IEnumerable<ToDo> GetToDoList()
        {
            return new List<ToDo>
            {
                new ToDo
                {
                    Title = "Meeting with client",
                    Comment = "Meet at the office on 08:00AM",
                    Date = DateTime.Today
                },
                new ToDo
                {
                    Title = "Lunch with Girlfriend",
                    Comment = "At restaurant near the office",
                    Date = DateTime.Today
                },
                new ToDo
                {
                    Title = "Go to dentist",
                    Comment = "Scheduled Visit to dentist",
                    Date = DateTime.Today.AddDays(2)
                }
            };
        }
    }

    }
