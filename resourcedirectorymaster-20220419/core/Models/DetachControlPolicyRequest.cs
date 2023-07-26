// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DetachControlPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the access control policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The ID of the object from which you want to detach the access control policy. Access control policies can be attached to the following objects:
        /// 
        /// *   Root folder
        /// *   Subfolders of the Root folder
        /// *   Members
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
