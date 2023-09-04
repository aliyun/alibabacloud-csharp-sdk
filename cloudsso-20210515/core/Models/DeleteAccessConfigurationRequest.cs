// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessConfigurationRequest : TeaModel {
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
        /// Specifies whether to forcibly remove system policies and inline policies. Valid values:
        /// 
        /// *   true: When you delete the access configuration, the associated system policies and inline policies are forcibly removed.
        /// *   false: When you delete the access configuration, the associated system policies and inline policies are not forcibly removed. This is the default value. If these policies exist in the access configuration, the deletion fails. Before you delete the access configuration, you must remove the system policies and inline policies. For more information, see [RemovePermissionPolicyFromAccessConfiguration](~~336904~~).
        /// </summary>
        [NameInMap("ForceRemovePermissionPolicies")]
        [Validation(Required=false)]
        public bool? ForceRemovePermissionPolicies { get; set; }

    }

}
