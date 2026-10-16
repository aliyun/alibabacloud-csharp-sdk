// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreatePolicySetResponseBody : TeaModel {
        /// <summary>
        /// <para>The policy set details.</para>
        /// </summary>
        [NameInMap("PolicySet")]
        [Validation(Required=false)]
        public CreatePolicySetResponseBodyPolicySet PolicySet { get; set; }
        public class CreatePolicySetResponseBodyPolicySet : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ARN of the policy set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:policyset/default-policy-set</para>
            /// </summary>
            [NameInMap("PolicySetArn")]
            [Validation(Required=false)]
            public string PolicySetArn { get; set; }

            /// <summary>
            /// <para>The name of the policy set. The name must be unique within the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-policy-set</para>
            /// </summary>
            [NameInMap("PolicySetName")]
            [Validation(Required=false)]
            public string PolicySetName { get; set; }

            /// <summary>
            /// <para>The source platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manuel</para>
            /// </summary>
            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
