// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypeVersionsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The versions of the resource types.
        /// </summary>
        [NameInMap("ResourceTypeVersions")]
        [Validation(Required=false)]
        public List<ListResourceTypeVersionsResponseBodyResourceTypeVersions> ResourceTypeVersions { get; set; }
        public class ListResourceTypeVersionsResponseBodyResourceTypeVersions : TeaModel {
            /// <summary>
            /// The time when the version was created. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the version.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The entity type. Only Module may be returned.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// Indicates whether the version is the default version. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }

            /// <summary>
            /// The provider of the resource type. Valid values:
            /// 
            /// *   ROS: ROS
            /// *   Self: yourself
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The time when the version was updated. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The version ID.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
