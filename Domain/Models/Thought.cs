using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Account;

namespace Domain.Models
{

    /// <summary>
    /// Идея, статья которую нужно сохранить
    /// </summary>
    public class Thought : IId
    {
        

        /// <summary>
        /// Текст идеи/ статьи для сохранения
        /// </summary>
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Вложенные файлы
        /// </summary>
        public  List<ThoughtFiles>? ThoughtFiles { get; set; } 

        /// <summary>
        /// Id Создателя идеи
        /// </summary>
        public  long CreatorId { get; set; }

        /// <summary>
        /// Создатель идеи
        /// </summary>
        public User Creator { get; set; } = new ();


    }
}
