// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform a dry run for the request. Valid values:
        /// 
        /// *   false: The system performs the related operation based on the parameter settings in the request. This is the default value.
        /// *   true: The system does not perform the related operation based on the parameter settings in the request but only verifies the parameter settings.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The document of the tag policy.
        /// 
        /// For more information about the syntax of a tag policy, see [Syntax of a tag policy](~~417436~~).
        /// </summary>
        [NameInMap("PolicyContent")]
        [Validation(Required=false)]
        public string PolicyContent { get; set; }

        /// <summary>
        /// The description of the tag policy.
        /// 
        /// The description must be 0 to 512 characters in length.
        /// </summary>
        [NameInMap("PolicyDesc")]
        [Validation(Required=false)]
        public string PolicyDesc { get; set; }

        /// <summary>
        /// The name of the tag policy.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

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
        /// The mode of the Tag Policy feature. Valid values:
        /// 
        /// *   USER: single-account mode. Set the value to USER if you use an Alibaba Cloud account or a member of a resource directory to call this API operation to create a tag policy for the Alibaba Cloud account or member.
        /// *   RD: multi-account mode. Set the value to RD if you use the management account of a resource directory to call this API operation to create a tag policy for the resource directory.
        /// 
        /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
