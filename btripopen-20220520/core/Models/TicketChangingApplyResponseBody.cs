// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误提示</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingApplyResponseBodyModule Module { get; set; }
        public class TicketChangingApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The total amount originally paid by the user when the price changes after booking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("booking_changed_total_fee")]
            [Validation(Required=false)]
            public int? BookingChangedTotalFee { get; set; }

            /// <summary>
            /// <para>The total amount originally paid by the user when the price changes after booking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("booking_origin_total_fee")]
            [Validation(Required=false)]
            public int? BookingOriginTotalFee { get; set; }

            /// <summary>
            /// <para>Indicates whether the price has changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("booking_price_changed")]
            [Validation(Required=false)]
            public bool? BookingPriceChanged { get; set; }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether payment is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_pay")]
            [Validation(Required=false)]
            public bool? CanPay { get; set; }

            /// <summary>
            /// <para>The change fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public long? ChangeFee { get; set; }

            /// <summary>
            /// <para>The latest time by which payment must be made.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("deadline_time")]
            [Validation(Required=false)]
            public string DeadlineTime { get; set; }

            /// <summary>
            /// <para>The external order ID of the distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <para>The change order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mid112</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <para>The maximum number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("max_retry_times")]
            [Validation(Required=false)]
            public int? MaxRetryTimes { get; set; }

            /// <summary>
            /// <para>The interval before the next retry, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("next_retry_interval")]
            [Validation(Required=false)]
            public long? NextRetryInterval { get; set; }

            /// <summary>
            /// <para>Specifies whether to retry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            /// <summary>
            /// <para>The prompt message displayed to the user during a retry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>正在申请</para>
            /// </summary>
            [NameInMap("retry_client_tips")]
            [Validation(Required=false)]
            public string RetryClientTips { get; set; }

            /// <summary>
            /// <para>The status of the change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Initial state.</description></item>
            /// <item><description>1: Pending payment.</description></item>
            /// <item><description>2: Payment successful.</description></item>
            /// <item><description>3: Change successful.</description></item>
            /// <item><description>4: Change closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The cabin upgrade fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("upgrade_fee")]
            [Validation(Required=false)]
            public long? UpgradeFee { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
