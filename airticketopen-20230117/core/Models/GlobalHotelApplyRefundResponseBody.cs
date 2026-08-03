// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelApplyRefundResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelApplyRefundResponseBodyData Data { get; set; }
        public class GlobalHotelApplyRefundResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("SellRefundOrderId")]
            [Validation(Required=false)]
            public long? SellRefundOrderId { get; set; }

            [NameInMap("TotalPenaltyAmount")]
            [Validation(Required=false)]
            public GlobalHotelApplyRefundResponseBodyDataTotalPenaltyAmount TotalPenaltyAmount { get; set; }
            public class GlobalHotelApplyRefundResponseBodyDataTotalPenaltyAmount : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            [NameInMap("TotalRefundAmount")]
            [Validation(Required=false)]
            public GlobalHotelApplyRefundResponseBodyDataTotalRefundAmount TotalRefundAmount { get; set; }
            public class GlobalHotelApplyRefundResponseBodyDataTotalRefundAmount : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TraceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TraceId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建订单失败</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
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
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
