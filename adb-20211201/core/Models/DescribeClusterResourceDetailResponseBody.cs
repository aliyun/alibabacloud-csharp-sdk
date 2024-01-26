// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterResourceDetailResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the cluster resource usage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeClusterResourceDetailResponseBodyData Data { get; set; }
        public class DescribeClusterResourceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The amount of reserved computing resources. Unit: AnalyticDB compute units (ACUs). Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.
            /// </summary>
            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public string ComputeResource { get; set; }

            /// <summary>
            /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The amount of idle reserved computing resources. Unit: ACUs. Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.
            /// </summary>
            [NameInMap("FreeComputeResource")]
            [Validation(Required=false)]
            public string FreeComputeResource { get; set; }

            /// <summary>
            /// The resource groups.
            /// </summary>
            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<DescribeClusterResourceDetailResponseBodyDataResourceGroupList> ResourceGroupList { get; set; }
            public class DescribeClusterResourceDetailResponseBodyDataResourceGroupList : TeaModel {
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

                [NameInMap("EnableSpot")]
                [Validation(Required=false)]
                public bool? EnableSpot { get; set; }

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
                /// The minimum amount of reserved computing resources. Unit: ACUs.
                /// </summary>
                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public string MinComputeResource { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("PoolId")]
                [Validation(Required=false)]
                public long? PoolId { get; set; }

                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("PoolName")]
                [Validation(Required=false)]
                public string PoolName { get; set; }

                /// <summary>
                /// The type of the resource group.
                /// </summary>
                [NameInMap("PoolType")]
                [Validation(Required=false)]
                public string PoolType { get; set; }

                /// <summary>
                /// The user of the resource group.
                /// </summary>
                [NameInMap("PoolUsers")]
                [Validation(Required=false)]
                public string PoolUsers { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("RunningClusterCount")]
                [Validation(Required=false)]
                public int? RunningClusterCount { get; set; }

                /// <summary>
                /// The state of the resource group. Valid values:
                /// 
                /// *   **running**
                /// *   **deleting**
                /// *   **scaling**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The amount of reserved storage resources. Unit: ACUs. Valid values: 0 to 2064. The value must be in increments of 24 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.
            /// </summary>
            [NameInMap("StorageResource")]
            [Validation(Required=false)]
            public string StorageResource { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
