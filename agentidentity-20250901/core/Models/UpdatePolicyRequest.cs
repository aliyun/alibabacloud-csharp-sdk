// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The definition of the policy.</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public Definition Definition { get; set; }

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
        /// <para>The name of the policy. The name must be unique within the policy set to which the policy belongs.</para>
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
