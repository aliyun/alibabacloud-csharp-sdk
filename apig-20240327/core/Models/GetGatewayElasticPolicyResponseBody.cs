// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayElasticPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayElasticPolicyResponseBodyData Data { get; set; }
        public class GetGatewayElasticPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The elastic policy configuration, deserialized from the elastic_config JSON field in the database.</para>
            /// </summary>
            [NameInMap("elasticPolicy")]
            [Validation(Required=false)]
            public GetGatewayElasticPolicyResponseBodyDataElasticPolicy ElasticPolicy { get; set; }
            public class GetGatewayElasticPolicyResponseBodyDataElasticPolicy : TeaModel {
                /// <summary>
                /// <para>The time periods during which AutoHPA scale-out is prohibited.</para>
                /// </summary>
                [NameInMap("disableScaleTimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyDisableScaleTimePolicyList> DisableScaleTimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyDisableScaleTimePolicyList : TeaModel {
                    /// <summary>
                    /// <para>The O&amp;M end time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The O&amp;M start time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether elastic scaling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("elasticEnabled")]
                [Validation(Required=false)]
                public bool? ElasticEnabled { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AutoHPA</para>
                /// </summary>
                [NameInMap("elasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// <para>The time periods during which AutoHPA scale-out is allowed.</para>
                /// </summary>
                [NameInMap("enableScaleTimePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyEnableScaleTimePolicyList : TeaModel {
                    /// <summary>
                    /// <para>The O&amp;M end time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The O&amp;M start time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>The load alert threshold switch for AutoHPA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("loadWarningThreshold")]
                [Validation(Required=false)]
                public bool? LoadWarningThreshold { get; set; }

                /// <summary>
                /// <para>The maximum number of replicas for AutoHPA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxUnits")]
                [Validation(Required=false)]
                public int? MaxUnits { get; set; }

                /// <summary>
                /// <para>The list of CronHPA scheduled policies. Each entry includes units (number of replicas), startTime, and endTime.</para>
                /// </summary>
                [NameInMap("timePolicyList")]
                [Validation(Required=false)]
                public List<GetGatewayElasticPolicyResponseBodyDataElasticPolicyTimePolicyList> TimePolicyList { get; set; }
                public class GetGatewayElasticPolicyResponseBodyDataElasticPolicyTimePolicyList : TeaModel {
                    /// <summary>
                    /// <para>The O&amp;M end time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>06:00</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The O&amp;M start time in the HH:mm format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The number of replicas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("units")]
                    [Validation(Required=false)]
                    public long? Units { get; set; }

                }

            }

            /// <summary>
            /// <para>The KubeOne AutoScaleStrategy instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("elasticStrategyId")]
            [Validation(Required=false)]
            public string ElasticStrategyId { get; set; }

            /// <summary>
            /// <para>The elastic policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CronHPA</para>
            /// </summary>
            [NameInMap("elasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-xxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
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
