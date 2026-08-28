// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayElasticPolicyRequest : TeaModel {
        [NameInMap("elasticPolicy")]
        [Validation(Required=false)]
        public UpdateGatewayElasticPolicyRequestElasticPolicy ElasticPolicy { get; set; }
        public class UpdateGatewayElasticPolicyRequestElasticPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("elasticEnabled")]
            [Validation(Required=false)]
            public bool? ElasticEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CronHPA</para>
            /// </summary>
            [NameInMap("elasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            [NameInMap("enableScaleTimePolicyList")]
            [Validation(Required=false)]
            public List<UpdateGatewayElasticPolicyRequestElasticPolicyEnableScaleTimePolicyList> EnableScaleTimePolicyList { get; set; }
            public class UpdateGatewayElasticPolicyRequestElasticPolicyEnableScaleTimePolicyList : TeaModel {
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
            public List<UpdateGatewayElasticPolicyRequestElasticPolicyTimePolicyList> TimePolicyList { get; set; }
            public class UpdateGatewayElasticPolicyRequestElasticPolicyTimePolicyList : TeaModel {
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
                public int? Units { get; set; }

            }

        }

    }

}
