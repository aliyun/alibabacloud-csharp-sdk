// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeletePolicyVersionRequest : TeaModel {
        /// <summary>
        /// The name of the policy.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The ID of the policy version.
        /// 
        /// You can call the [ListPolicyVersions](~~159982~~) operation to query the ID.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
