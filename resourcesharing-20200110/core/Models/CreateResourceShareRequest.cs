// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareRequest : TeaModel {
        /// <summary>
        /// Specifies whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:
        /// 
        /// *   false: Resources in the resource share can be shared only with accounts in the resource directory. This is the default value.
        /// *   true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.
        /// </summary>
        [NameInMap("AllowExternalTargets")]
        [Validation(Required=false)]
        public bool? AllowExternalTargets { get; set; }

        [NameInMap("PermissionNames")]
        [Validation(Required=false)]
        public List<string> PermissionNames { get; set; }

        /// <summary>
        /// The name of the resource share.
        /// 
        /// The name must be 1 to 50 characters in length.
        /// 
        /// The name can contain letters, digits, periods (.), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestResources> Resources { get; set; }
        public class CreateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// The ID of a shared resource.
            /// 
            /// Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.
            /// 
            /// >  `Resources.N.ResourceId` and `Resources.N.ResourceType` must be used in pairs.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of a shared resource.
            /// 
            /// Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.
            /// 
            /// For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
            /// 
            /// >  `Resources.N.ResourceId` and `Resources.N.ResourceType` must be used in pairs.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}
