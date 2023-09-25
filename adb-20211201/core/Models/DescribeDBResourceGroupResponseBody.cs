// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The queried resource groups.
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            [NameInMap("ClusterSizeResource")]
            [Validation(Required=false)]
            public string ClusterSizeResource { get; set; }

            /// <summary>
            /// The time when the resource group was created. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The amount of minimum elastic computing resources. Unit: ACU.
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The type of the resource group. Valid values:
            /// 
            /// *   **Interactive**
            /// *   **Job**
            /// 
            /// > For information about resource groups of Data Lakehouse Edition, see [Resource groups](~~428610~~).
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The Resource Access Management (RAM) user with which the resource group is associated.
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// The maximum amount of reserved computing resources. Unit: ACU.
            /// </summary>
            [NameInMap("MaxComputeResource")]
            [Validation(Required=false)]
            public string MaxComputeResource { get; set; }

            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// The minimum amount of reserved computing resources. Unit: AnalyticDB compute unit (ACU).
            /// </summary>
            [NameInMap("MinComputeResource")]
            [Validation(Required=false)]
            public string MinComputeResource { get; set; }

            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            /// <summary>
            /// The state of the resource group. Valid values:
            /// 
            /// *   **creating**
            /// *   **ok**
            /// *   **pendingdelete**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the resource group was updated. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
