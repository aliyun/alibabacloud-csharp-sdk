// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookResponseBody : TeaModel {
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
        public BookResponseBodyData Data { get; set; }
        public class BookResponseBodyData : TeaModel {
            /// <summary>
            /// <para>order information list</para>
            /// </summary>
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<BookResponseBodyDataOrderList> OrderList { get; set; }
            public class BookResponseBodyDataOrderList : TeaModel {
                /// <summary>
                /// <para>order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>4966***617111</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

            }

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
        public BookResponseBodyErrorData ErrorData { get; set; }
        public class BookResponseBodyErrorData : TeaModel {
            /// <summary>
            /// <para>order information list. When the same input parameters are used to repeat a Book, if the booking has already been successful, the order number will be returned.</para>
            /// </summary>
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<BookResponseBodyErrorDataOrderList> OrderList { get; set; }
            public class BookResponseBodyErrorDataOrderList : TeaModel {
                /// <summary>
                /// <para>order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>4966***617111</para>
                /// </summary>
                [NameInMap("order_num")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

            }

        }

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
