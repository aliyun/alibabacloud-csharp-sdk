// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketingResponseBody : TeaModel {
        /// <summary>
        /// <para>request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public TicketingResponseBodyData Data { get; set; }
        public class TicketingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>order number</para>
            /// 
            /// <b>Example:</b>
            /// <para>496***2617111</para>
            /// </summary>
            [NameInMap("order_num")]
            [Validation(Required=false)]
            public long? OrderNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1757404878000</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// <para>transaction serial number</para>
            /// 
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error data</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http reqeust has been processed successfully，status code is 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
