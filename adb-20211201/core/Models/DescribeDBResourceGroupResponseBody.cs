// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The queried resource group.
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
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
            /// The minimum amount of elastic computing resources. Unit: ACUs.
            /// </summary>
            [NameInMap("ElasticMinComputeResource")]
            [Validation(Required=false)]
            public string ElasticMinComputeResource { get; set; }

            /// <summary>
            /// Indicates whether the preemptible instance feature is enabled for the resource group. After the preemptible instance feature is enabled, you are charged for resources at a lower unit price but the resources are probably released. Valid values:
            /// 
            /// *   **True**
            /// *   **False**
            /// 
            /// The True value is returned only for job resource groups.
            /// </summary>
            [NameInMap("EnableSpot")]
            [Validation(Required=false)]
            public string EnableSpot { get; set; }

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
            /// >  For more information about resource groups, see [Resource groups](https://help.aliyun.com/document_detail/428610.html).
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The Resource Access Management (RAM) user that is associated with the resource group.
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("MaxClusterCount")]
            [Validation(Required=false)]
            public int? MaxClusterCount { get; set; }

            /// <summary>
            /// The maximum amount of reserved computing resources. Unit: ACUs.
            /// </summary>
            [NameInMap("MaxComputeResource")]
            [Validation(Required=false)]
            public string MaxComputeResource { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("MinClusterCount")]
            [Validation(Required=false)]
            public int? MinClusterCount { get; set; }

            /// <summary>
            /// The minimum amount of reserved computing resources. Unit: AnalyticDB compute units (ACUs).
            /// </summary>
            [NameInMap("MinComputeResource")]
            [Validation(Required=false)]
            public string MinComputeResource { get; set; }

            /// <summary>
            /// The job resubmission rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyGroupsInfoRules> Rules { get; set; }
            public class DescribeDBResourceGroupResponseBodyGroupsInfoRules : TeaModel {
                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The execution duration of the query. Unit: milliseconds.
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                /// <summary>
                /// The name of the destination resource group.
                /// </summary>
                [NameInMap("TargetGroupName")]
                [Validation(Required=false)]
                public string TargetGroupName { get; set; }

            }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("RunningClusterCount")]
            [Validation(Required=false)]
            public int? RunningClusterCount { get; set; }

            /// <summary>
            /// The status of the resource group. Valid values:
            /// 
            /// *   **creating**: The resource group is being created.
            /// *   **ok**: The resource group is created.
            /// *   **pendingdelete**: The resource group is pending to be deleted.
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
