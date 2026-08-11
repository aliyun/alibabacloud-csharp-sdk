// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelCancelOrRefundResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelCancelOrRefundResponseBodyData Data { get; set; }
        public class GlobalHotelCancelOrRefundResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RF202606290001</para>
            /// </summary>
            [NameInMap("RefundOrderNo")]
            [Validation(Required=false)]
            public string RefundOrderNo { get; set; }

            /// <summary>
            /// <para>The total penalty amount on the sales side.</para>
            /// </summary>
            [NameInMap("TotalPenaltyAmount")]
            [Validation(Required=false)]
            public GlobalHotelCancelOrRefundResponseBodyDataTotalPenaltyAmount TotalPenaltyAmount { get; set; }
            public class GlobalHotelCancelOrRefundResponseBodyDataTotalPenaltyAmount : TeaModel {
                /// <summary>
                /// <para>The amount in the smallest currency unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The currency code in ISO 4217 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>TraceId</para>
                /// 
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>The total refund amount.</para>
            /// </summary>
            [NameInMap("TotalRefundAmount")]
            [Validation(Required=false)]
            public GlobalHotelCancelOrRefundResponseBodyDataTotalRefundAmount TotalRefundAmount { get; set; }
            public class GlobalHotelCancelOrRefundResponseBodyDataTotalRefundAmount : TeaModel {
                /// <summary>
                /// <para>The amount in the smallest currency unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The currency code in ISO 4217 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>TraceId</para>
                /// 
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>TraceId</para>
            /// 
            /// <b>Example:</b>
            /// <para>TraceId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to create order</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TraceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
