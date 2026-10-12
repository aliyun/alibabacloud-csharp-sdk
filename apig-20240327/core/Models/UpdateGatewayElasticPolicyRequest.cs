// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayElasticPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The elastic policy object.</para>
        /// </summary>
        [NameInMap("elasticPolicy")]
        [Validation(Required=false)]
        public UpdateGatewayElasticPolicyRequestElasticPolicy ElasticPolicy { get; set; }
        public class UpdateGatewayElasticPolicyRequestElasticPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the elastic policy. A value of false indicates that the elastic policy is disabled. When the elastic policy is disabled, other fields are not validated and the system directly proceeds with the disabling process.</para>
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
            /// <para>CronHPA</para>
            /// </summary>
            [NameInMap("elasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            /// <summary>
            /// <para>The time periods during which AutoHPA is allowed to scale out, specified by startTime and endTime.</para>
            /// </summary>
            [NameInMap("enableScaleTimePolicyList")]
            [Validation(Required=false)]
            public List<UpdateGatewayElasticPolicyRequestElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
            public class UpdateGatewayElasticPolicyRequestElasticPolicyEnableScaleTimePolicyList : TeaModel {
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
            /// <para>Specifies whether to enable the AutoHPA load alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("loadWarningThreshold")]
            [Validation(Required=false)]
            public bool? LoadWarningThreshold { get; set; }

            /// <summary>
            /// <para>The maximum number of replicas. This parameter is required for AutoHPA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxUnits")]
            [Validation(Required=false)]
            public int? MaxUnits { get; set; }

            /// <summary>
            /// <para>The list of scheduled policies.</para>
            /// </summary>
            [NameInMap("timePolicyList")]
            [Validation(Required=false)]
            public List<UpdateGatewayElasticPolicyRequestElasticPolicyTimePolicyList> TimePolicyList { get; set; }
            public class UpdateGatewayElasticPolicyRequestElasticPolicyTimePolicyList : TeaModel {
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
                public int? Units { get; set; }

            }

        }

    }

}
