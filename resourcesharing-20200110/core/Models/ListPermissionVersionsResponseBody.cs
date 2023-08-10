// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListPermissionVersionsResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about the permission.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionVersionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionVersionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates whether the permission is the default permission. Valid values:
            /// 
            /// *   false: The permission is not the default permission.
            /// *   true: The permission is the default permission.
            /// </summary>
            [NameInMap("DefaultPermission")]
            [Validation(Required=false)]
            public bool? DefaultPermission { get; set; }

            /// <summary>
            /// Indicates whether the version is the default version. Valid values:
            /// 
            /// *   false: The version is not the default version.
            /// *   true: The version is the default version.
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            /// <summary>
            /// The name of the permission.
            /// </summary>
            [NameInMap("PermissionName")]
            [Validation(Required=false)]
            public string PermissionName { get; set; }

            /// <summary>
            /// The version of the permission.
            /// </summary>
            [NameInMap("PermissionVersion")]
            [Validation(Required=false)]
            public string PermissionVersion { get; set; }

            /// <summary>
            /// The type of the shared resources.
            /// 
            /// For more information about the types of resources that can be shared, see [Services that work with Resource Sharing](~~450526~~).
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The update time.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
