using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp.Core.Entities
{
    class Note : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTimeOffset? TimeToComplete {get; set;}
        public Guid UserId {get; set;}

        public Note(string title, string details, DateTime createdDate, bool iscompleted)
        {
            Title = title;
            Details = details;
            CreatedDate = createdDate;
            IsCompleted = iscompleted;
                
        }
        private Note()
        {

        }

    }
}
