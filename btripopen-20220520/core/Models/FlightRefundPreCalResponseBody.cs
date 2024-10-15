// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundPreCalResponseBodyModule Module { get; set; }
        public class FlightRefundPreCalResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("flight_change")]
            [Validation(Required=false)]
            public bool? FlightChange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FlightItem_996677504</para>
            /// </summary>
            [NameInMap("item_unit_id")]
            [Validation(Required=false)]
            public string ItemUnitId { get; set; }

            [NameInMap("multi_refund_cal_list")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleMultiRefundCalList> MultiRefundCalList { get; set; }
            public class FlightRefundPreCalResponseBodyModuleMultiRefundCalList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("can_apply_refund")]
                [Validation(Required=false)]
                public bool? CanApplyRefund { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>124</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            [NameInMap("return_reason")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleReturnReason> ReturnReason { get; set; }
            public class FlightRefundPreCalResponseBodyModuleReturnReason : TeaModel {
                [NameInMap("extend_desc")]
                [Validation(Required=false)]
                public string ExtendDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("person")]
                [Validation(Required=false)]
                public int? Person { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("reason_code")]
                [Validation(Required=false)]
                public int? ReasonCode { get; set; }

                [NameInMap("reason_show")]
                [Validation(Required=false)]
                public string ReasonShow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public int? Volunteer { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>882sudu23s923j9d2</para>
            /// </summary>
            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
