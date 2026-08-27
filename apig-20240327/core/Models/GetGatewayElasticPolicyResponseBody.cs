// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayElasticPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayElasticPolicyResponseBodyData Data { get; set; }
        public class GetGatewayElasticPolicyResponseBodyData : TeaModel {
            [NameInMap("elasticPolicy")]
            [Validation(Required=false)]
            public GetGatewayElasticPolicyResponseBodyDataElasticPolicy ElasticPolicy { get; set; }
            public class GetGatewayElasticPolicyResponseBodyDataElasticPolicy : TeaModel {
                [NameInMap("disableScaleTimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyDisableScaleTimePolicyList> DisableScaleTimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyDisableScaleTimePolicyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("elasticEnabled")]
                [Validation(Required=false)]
                public bool? ElasticEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AutoHPA</para>
                /// </summary>
                [NameInMap("elasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                [NameInMap("enableScaleTimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyEnableScaleTimePolicyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>09:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("loadWarningThreshold")]
                [Validation(Required=false)]
                public bool? LoadWarningThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxUnits")]
                [Validation(Required=false)]
                public int? MaxUnits { get; set; }

                [NameInMap("timePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyTimePolicyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>06:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("units")]
                    [Validation(Required=false)]
                    public long? Units { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("elasticStrategyId")]
            [Validation(Required=false)]
            public string ElasticStrategyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CronHPA</para>
            /// </summary>
            [NameInMap("elasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-xxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7F02714-182D-55BC-AF0B-F454364445E4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
