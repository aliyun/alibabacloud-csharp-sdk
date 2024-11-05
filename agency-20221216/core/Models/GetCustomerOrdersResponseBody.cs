// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCustomerOrdersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCustomerOrdersResponseBodyData> Data { get; set; }
        public class GetCustomerOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test_123</para>
            /// </summary>
            [NameInMap("CustomerAccount")]
            [Validation(Required=false)]
            public string CustomerAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>myBd</para>
            /// </summary>
            [NameInMap("CustomerManager")]
            [Validation(Required=false)]
            public string CustomerManager { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CustomerNo")]
            [Validation(Required=false)]
            public long? CustomerNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>236414227150922</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OrderSource")]
            [Validation(Required=false)]
            public string OrderSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.92</para>
            /// </summary>
            [NameInMap("OriginalCost")]
            [Validation(Required=false)]
            public double? OriginalCost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3:32</para>
            /// </summary>
            [NameInMap("PaymentMethod")]
            [Validation(Required=false)]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-13 13:02:02</para>
            /// </summary>
            [NameInMap("PaymentTime")]
            [Validation(Required=false)]
            public string PaymentTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.92</para>
            /// </summary>
            [NameInMap("PretaxCost")]
            [Validation(Required=false)]
            public double? PretaxCost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductDetail")]
            [Validation(Required=false)]
            public string ProductDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>snapshot</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-13 13:02:02</para>
            /// </summary>
            [NameInMap("TimeToOrder")]
            [Validation(Required=false)]
            public string TimeToOrder { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>23309219-4A34-589D-A3E0-9B2A3BFFD24F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
