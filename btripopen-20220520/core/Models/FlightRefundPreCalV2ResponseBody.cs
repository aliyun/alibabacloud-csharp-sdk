// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightRefundPreCalV2ResponseBodyModule Module { get; set; }
        public class FlightRefundPreCalV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of multi-passenger refund pre-calculations.</para>
            /// </summary>
            [NameInMap("multi_refund_fee_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS> MultiRefundFeeDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS : TeaModel {
                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>乘客1</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The estimated refund amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                /// <summary>
                /// <para>The refund handling fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_charge_fee")]
                [Validation(Required=false)]
                public long? RefundChargeFee { get; set; }

            }

            /// <summary>
            /// <para>The estimated refund amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            /// <summary>
            /// <para>The refund handling fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_charge_fee")]
            [Validation(Required=false)]
            public long? RefundChargeFee { get; set; }

            /// <summary>
            /// <para>The available refund reasons.</para>
            /// </summary>
            [NameInMap("refund_reason_option_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS> RefundReasonOptionDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS : TeaModel {
                /// <summary>
                /// <para>The display text of the refund reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>我要改变行程计划、我不想飞</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The reason type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                /// <summary>
                /// <para>Indicates whether the refund is voluntary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public bool? Volunteer { get; set; }

            }

            /// <summary>
            /// <para>The refund service fee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("service_charge_fee")]
            [Validation(Required=false)]
            public long? ServiceChargeFee { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>92359A00-85D8-16C4-AED0-249618DEEC17</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
