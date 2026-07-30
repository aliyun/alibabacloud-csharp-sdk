// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundPreCalResponseBodyModule Module { get; set; }
        public class FlightRefundPreCalResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Indicates whether a flight change has occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("flight_change")]
            [Validation(Required=false)]
            public bool? FlightChange { get; set; }

            /// <summary>
            /// <para>The encrypted parameter used for the refund.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FlightItem_996677504</para>
            /// </summary>
            [NameInMap("item_unit_id")]
            [Validation(Required=false)]
            public string ItemUnitId { get; set; }

            /// <summary>
            /// <para>The list of pre-calculated refund information for multiple passengers.</para>
            /// </summary>
            [NameInMap("multi_refund_cal_list")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleMultiRefundCalList> MultiRefundCalList { get; set; }
            public class FlightRefundPreCalResponseBodyModuleMultiRefundCalList : TeaModel {
                /// <summary>
                /// <para>Indicates whether a refund application can be submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("can_apply_refund")]
                [Validation(Required=false)]
                public bool? CanApplyRefund { get; set; }

                /// <summary>
                /// <para>The employee name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The estimated refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                /// <summary>
                /// <para>The refund service fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                /// <summary>
                /// <para>The user ID of the external distributor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>124</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The estimated refund amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            /// <summary>
            /// <para>The refund service fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            /// <summary>
            /// <para>The refund reason.</para>
            /// </summary>
            [NameInMap("return_reason")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalResponseBodyModuleReturnReason> ReturnReason { get; set; }
            public class FlightRefundPreCalResponseBodyModuleReturnReason : TeaModel {
                /// <summary>
                /// <para>The remarks for the refund reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人原因提退退票,按照标准退改规则收取手续费</para>
                /// </summary>
                [NameInMap("extend_desc")]
                [Validation(Required=false)]
                public string ExtendDesc { get; set; }

                /// <summary>
                /// <para>Indicates whether the reason is personal or airline-related. Valid values: 0 (airline) and 1 (personal).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("person")]
                [Validation(Required=false)]
                public int? Person { get; set; }

                /// <summary>
                /// <para>The reason code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("reason_code")]
                [Validation(Required=false)]
                public int? ReasonCode { get; set; }

                /// <summary>
                /// <para>The display text of the reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人原因提退退票,按照标准退改规则收取手续费</para>
                /// </summary>
                [NameInMap("reason_show")]
                [Validation(Required=false)]
                public string ReasonShow { get; set; }

                /// <summary>
                /// <para>The reason type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                /// <summary>
                /// <para>Indicates whether the refund is voluntary or involuntary. Valid values: 0 (involuntary) and 1 (voluntary).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public int? Volunteer { get; set; }

            }

            /// <summary>
            /// <para>The session ID. This value is obtained from the isessionId field returned by the flight change inquiry operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>882sudu23s923j9d2</para>
            /// </summary>
            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>This field is currently unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
