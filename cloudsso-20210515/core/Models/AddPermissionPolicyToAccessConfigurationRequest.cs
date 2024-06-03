// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class AddPermissionPolicyToAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The configurations of the inline policy.
        /// 
        /// The value can be up to 4,096 characters in length.
        /// 
        /// If you set `PermissionPolicyType` to `Inline`, you must specify this parameter. For more information about the syntax and structure of RAM policies, see [Policy syntax and structure](https://help.aliyun.com/document_detail/93739.html).
        /// </summary>
        [NameInMap("InlinePolicyDocument")]
        [Validation(Required=false)]
        public string InlinePolicyDocument { get; set; }

        /// <summary>
        /// The name of the policy.
        /// 
        /// *   If you set `PermissionPolicyType` to `System`, you must set this parameter to the name of the system policy. You can obtain the name of the system policy from RAM.
        /// *   If you set `PermissionPolicyType` to `Inline`, you must set this parameter to the name of the inline policy. A custom value is supported.
        /// </summary>
        [NameInMap("PermissionPolicyName")]
        [Validation(Required=false)]
        public string PermissionPolicyName { get; set; }

        /// <summary>
        /// The type of the policy. Valid values:
        /// 
        /// *   System: system policy. Resource Access Management (RAM) system policies are reused.
        /// *   Inline: inline policy. Inline policies are created based on the RAM policy syntax and structure.
        /// </summary>
        [NameInMap("PermissionPolicyType")]
        [Validation(Required=false)]
        public string PermissionPolicyType { get; set; }

    }

}
