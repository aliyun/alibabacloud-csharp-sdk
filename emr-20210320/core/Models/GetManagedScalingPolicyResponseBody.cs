// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetManagedScalingPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public GetManagedScalingPolicyResponseBodyScalingPolicy ScalingPolicy { get; set; }
        public class GetManagedScalingPolicyResponseBodyScalingPolicy : TeaModel {
            /// <summary>
            /// <para>集群ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-b933c5aac8fe****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>最大最小值约束</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetManagedScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetManagedScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// <para>最大值</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// <para>最大按量数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxOnDemandCapacity")]
                [Validation(Required=false)]
                public int? MaxOnDemandCapacity { get; set; }

                /// <summary>
                /// <para>最小值</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// <para>伸缩策略ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>asp-asduwe23znl***</para>
            /// </summary>
            [NameInMap("ScalingPolicyId")]
            [Validation(Required=false)]
            public string ScalingPolicyId { get; set; }

        }

    }

}
