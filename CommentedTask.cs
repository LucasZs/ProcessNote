using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote
{
    class CommentedTask
    {
        private int id;
        private string comment="";

        public CommentedTask(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setComment(string comment)
        {
            this.comment = comment;
        }

        public string getComment()
        {
            return comment;
        }
    }
}
