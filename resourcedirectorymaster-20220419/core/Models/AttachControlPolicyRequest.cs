// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AttachControlPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the access control policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The ID of the object to which you want to attach the access control policy. Access control policies can be attached to the following objects:
        /// 
        /// *   Root folder
        /// *   Subfolders of the Root folder
        /// *   Members
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
