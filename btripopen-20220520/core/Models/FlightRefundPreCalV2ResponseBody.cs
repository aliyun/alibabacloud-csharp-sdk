// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
            [NameInMap("multi_refund_fee_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS> MultiRefundFeeDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleMultiRefundFeeDTOS : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("pre_refund_money")]
                [Validation(Required=false)]
                public long? PreRefundMoney { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_charge_fee")]
                [Validation(Required=false)]
                public long? RefundChargeFee { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("pre_refund_money")]
            [Validation(Required=false)]
            public long? PreRefundMoney { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_charge_fee")]
            [Validation(Required=false)]
            public long? RefundChargeFee { get; set; }

            [NameInMap("refund_reason_option_d_t_o_s")]
            [Validation(Required=false)]
            public List<FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS> RefundReasonOptionDTOS { get; set; }
            public class FlightRefundPreCalV2ResponseBodyModuleRefundReasonOptionDTOS : TeaModel {
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("reason_type")]
                [Validation(Required=false)]
                public int? ReasonType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("volunteer")]
                [Validation(Required=false)]
                public bool? Volunteer { get; set; }

            }

            /// <summary>
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
