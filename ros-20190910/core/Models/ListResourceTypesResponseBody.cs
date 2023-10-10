// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource type summaries.
        /// </summary>
        [NameInMap("ResourceTypeSummaries")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypeSummaries> ResourceTypeSummaries { get; set; }
        public class ListResourceTypesResponseBodyResourceTypeSummaries : TeaModel {
            /// <summary>
            /// The creation time. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the default version.
            /// </summary>
            [NameInMap("DefaultVersionId")]
            [Validation(Required=false)]
            public string DefaultVersionId { get; set; }

            /// <summary>
            /// The description of the resource type.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The entity type. Valid values:
            /// 
            /// *   Resource: regular resources.
            /// *   DataSource: DataSource resources.
            /// *   Module: modules.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// The ID of the latest version.
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// The provider of the resource type. Valid values:
            /// 
            /// *   ROS: The resource type is provided by ROS.
            /// *   Self: The resource type is provided by you.
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
            /// The number of versions.
            /// </summary>
            [NameInMap("TotalVersionCount")]
            [Validation(Required=false)]
            public int? TotalVersionCount { get; set; }

            /// <summary>
            /// The update time. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The array of resource types.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

    }

}
