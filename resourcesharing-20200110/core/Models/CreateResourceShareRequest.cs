// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareRequest : TeaModel {
        /// <summary>
        /// The information of the resource share.
        /// </summary>
        [NameInMap("AllowExternalTargets")]
        [Validation(Required=false)]
        public bool? AllowExternalTargets { get; set; }

        [NameInMap("PermissionNames")]
        [Validation(Required=false)]
        public List<string> PermissionNames { get; set; }

        /// <summary>
        /// The ID of a shared resource.
        /// 
        /// Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.
        /// 
        /// >  `Resources.N.ResourceId` and `Resources.N.ResourceType` must be used in pairs.
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestResources> Resources { get; set; }
        public class CreateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// The name of a permission. If you do not configure this parameter, the system automatically associates the default permission for the specified resource type with the resource share. For more information, see [Permission library](~~465474~~).
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The ID of a principal. Valid values:
            /// 
            /// *   If you set `AllowExternalTargets` to `false`, set this parameter to the ID of a resource directory, ID of a folder in a resource directory, or ID of a member in a resource directory.
            /// *   If you set `AllowExternalTargets` to `true`, set this parameter to the ID of an independent Alibaba Cloud account, ID of a resource directory, ID of a folder in a resource directory, or ID of a member in a resource directory.
            /// 
            /// For more information, see [Resource sharing modes](~~160622~~), [View the ID of a resource directory](~~111217~~), [View the ID of a folder](~~111223~~), or [View the ID of a member](~~111624~~).
            /// 
            /// Valid values of N: 1 to 5. This indicates that a maximum of five principals can be specified at a time.
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
