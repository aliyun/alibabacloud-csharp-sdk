// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetManagedScalingPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The elastic scaling policy.</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public GetManagedScalingPolicyResponseBodyScalingPolicy ScalingPolicy { get; set; }
        public class GetManagedScalingPolicyResponseBodyScalingPolicy : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-b933c5aac8fe****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The constraints on the maximum and minimum values.</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetManagedScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetManagedScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// <para>The maximum number of pay-as-you-go task nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxOnDemandCapacity")]
                [Validation(Required=false)]
                public int? MaxOnDemandCapacity { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// <para>The scaling policy ID.</para>
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
