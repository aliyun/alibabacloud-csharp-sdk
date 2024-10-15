// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingApplyResponseBodyModule Module { get; set; }
        public class TicketChangingApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("booking_changed_total_fee")]
            [Validation(Required=false)]
            public int? BookingChangedTotalFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("booking_origin_total_fee")]
            [Validation(Required=false)]
            public int? BookingOriginTotalFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("booking_price_changed")]
            [Validation(Required=false)]
            public bool? BookingPriceChanged { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_pay")]
            [Validation(Required=false)]
            public bool? CanPay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("change_fee")]
            [Validation(Required=false)]
            public long? ChangeFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("deadline_time")]
            [Validation(Required=false)]
            public string DeadlineTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mid112</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("max_retry_times")]
            [Validation(Required=false)]
            public int? MaxRetryTimes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("next_retry_interval")]
            [Validation(Required=false)]
            public long? NextRetryInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retry")]
            [Validation(Required=false)]
            public bool? Retry { get; set; }

            [NameInMap("retry_client_tips")]
            [Validation(Required=false)]
            public string RetryClientTips { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("upgrade_fee")]
            [Validation(Required=false)]
            public long? UpgradeFee { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
