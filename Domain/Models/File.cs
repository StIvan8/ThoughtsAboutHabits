using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class File : IId
    {
        /// <summary>
        /// Наименование файла (Без расширения)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Расширение файла
        /// </summary>
        public string Extension { get; set; } = string.Empty;

        /// <summary>
        /// Содержимое файла
        /// </summary>
        public byte[] Content { get; set; } = Array.Empty<byte>();




    }
}
