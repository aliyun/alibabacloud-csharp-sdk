// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// The description of the policy.
        /// 
        /// The description must be 1 to 1,024 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The document of the policy.
        /// 
        /// The document must be 1 to 2,048 characters in length.
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// The name of the policy.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
