using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Account;

namespace Domain.Models
{
    /// <summary>
    /// Была ли мысль/статья полезна, одобрена либо отклонена участником
    /// </summary>
     public class UserApprovedThought : IId
    {
        /// <summary>
        /// Ключ на таблицу пользователей
        /// </summary>
        public  long UserId { get; set; }
        
        /// <summary>
        /// Пользователь, который одобрил мысль
        /// </summary>
        public  User User { get; set; }

        /// <summary>
        /// Ключ на таблицу статей/идей
        /// </summary>
        public long ThoughtId { get; set; }

        /// <summary>
        /// Статья идея, которая была оценена пользователем
        /// </summary>
        public  Thought Thought { get; set; }

        /// <summary>
        /// Была ли мысль откланена либо одобрена
        /// </summary>
        public  bool IsApproved { get; set; }

        /// <summary>
        /// Комментарий 
        /// </summary>
        public  string Comment { get; set; }
    }
}
