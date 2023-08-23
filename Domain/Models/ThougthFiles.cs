using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ThoughtFiles : IId
    {


        /// <summary>
        /// Идентификатор идеи, к которой относится файл 
        /// </summary>
        public  long ThoughtId { get; set; }
        
        /// <summary>
        /// Идея к которой относится файл
        /// </summary>
        public  Thought? Thought { get; set; }
        
        /// <summary>
        /// Идентификатор файла, к которой относится идея
        /// </summary>
        public  long FileId { get; set; }


        /// <summary>
        /// Сам файл, который относится к идеи
        /// </summary>
        public  File? File { get; set; }
    }
}
