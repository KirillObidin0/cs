using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02.NewFolder1
{
    public enum RequestType
    {
        SALES,
        SALESIMS,
        STORED,
        MOVING,
        GOODS_RECEIPT
    }
    class Request
    {
        public RequestType RT { get; set; }
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        /// </summary>
        public int KUNNR { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
        /// </summary>
        public int BUKRS { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
        /// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime DATA1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime DATA2 { get; set; }

    }
}
