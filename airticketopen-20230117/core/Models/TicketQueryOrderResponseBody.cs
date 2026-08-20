// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketQueryOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketQueryOrderResponseBodyData Data { get; set; }
        public class TicketQueryOrderResponseBodyData : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public TicketQueryOrderResponseBodyDataOrder Order { get; set; }
            public class TicketQueryOrderResponseBodyDataOrder : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FundStatus")]
                [Validation(Required=false)]
                public int? FundStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

            }

            [NameInMap("Vouchers")]
            [Validation(Required=false)]
            public List<TicketQueryOrderResponseBodyDataVouchers> Vouchers { get; set; }
            public class TicketQueryOrderResponseBodyDataVouchers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalTimes")]
                [Validation(Required=false)]
                public int? TotalTimes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.alitrip.com/1234567890.png">https://www.alitrip.com/1234567890.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DistributorOrderIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分销商订单号不合法</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
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

    }

}
