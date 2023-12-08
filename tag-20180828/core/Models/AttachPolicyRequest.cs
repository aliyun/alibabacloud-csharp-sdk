/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class AttachPolicyRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the tag policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the object.
        /// 
        /// >  If you use the Tag Policy feature in single-account mode, this parameter is optional. If you use the Tag Policy feature in multi-account mode, this feature is required.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the object. Valid values:
        /// 
        /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
        /// *   ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// 
        /// >  If you use the Tag Policy feature in single-account mode, this parameter is optional. If you use the Tag Policy feature in multi-account mode, this feature is required. The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
