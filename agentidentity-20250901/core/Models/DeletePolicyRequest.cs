// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class DeletePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the policy. The name must be unique within the policy set to which it belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rate-limit-policy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The name of the policy set. The name must be unique within the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-policy-set</para>
        /// </summary>
        [NameInMap("PolicySetName")]
        [Validation(Required=false)]
        public string PolicySetName { get; set; }

    }

}
