// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBResourceGroupRequest : TeaModel {
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
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable the spot instance feature for the resource group. After you enable the spot instance feature, you are charged for resources at a lower unit price but the resources are probably released. You can enable the spot instance feature only for job resource groups. Valid values:
        /// 
        /// *   **True**
        /// *   **False**
        /// </summary>
        [NameInMap("EnableSpot")]
        [Validation(Required=false)]
        public bool? EnableSpot { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// *   The name can be up to 255 characters in length.
        /// *   The name must start with a letter or a digit.
        /// *   The name can contain letters, digits, hyphens (_), and underscores (_).
        /// 
        /// This parameter is required.
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
        /// > For information about resource groups of Data Lakehouse Edition, see [Resource groups](https://help.aliyun.com/document_detail/428610.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("MaxClusterCount")]
        [Validation(Required=false)]
        public int? MaxClusterCount { get; set; }

        /// <summary>
        /// The maximum reserved computing resources. Unit: ACU.
        /// 
        /// *   If GroupType is set to Interactive, the maximum amount of reserved computing resources refers to the amount of resources that are not allocated in the cluster. Set this parameter to a value in increments of 16 ACUs.
        /// *   If GroupType is set to Job, the maximum amount of reserved computing resources refers to the amount of resources that are not allocated in the cluster. Set this parameter to a value in increments of 8 ACUs.
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
        /// The minimum reserved computing resources. Unit: AnalyticDB Compute Units (ACUs).
        /// 
        /// *   When GroupType is set to Interactive, set this parameter to 16 ACUs.
        /// *   When GroupType is set to Job, set this parameter to 0 ACUs.
        /// </summary>
        [NameInMap("MinComputeResource")]
        [Validation(Required=false)]
        public string MinComputeResource { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/612393.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The job resubmission rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateDBResourceGroupRequestRules> Rules { get; set; }
        public class CreateDBResourceGroupRequestRules : TeaModel {
            /// <summary>
            /// The name of the resource group.
            /// 
            /// *   The name can be up to 255 characters in length.
            /// *   The name must start with a letter or digit.
            /// *   The name can contain letters, digits, hyphens (-), and underscores (_).
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
            /// The name of the resource group to which you want to resubmit the query job.
            /// </summary>
            [NameInMap("TargetGroupName")]
            [Validation(Required=false)]
            public string TargetGroupName { get; set; }

        }

    }

}
