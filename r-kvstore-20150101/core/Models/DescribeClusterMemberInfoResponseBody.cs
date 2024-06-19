// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeClusterMemberInfoResponseBody : TeaModel {
        /// <summary>
        /// Details of nodes in the cluster instance.
        /// </summary>
        [NameInMap("ClusterChildren")]
        [Validation(Required=false)]
        public List<DescribeClusterMemberInfoResponseBodyClusterChildren> ClusterChildren { get; set; }
        public class DescribeClusterMemberInfoResponseBodyClusterChildren : TeaModel {
            /// <summary>
            /// The maximum bandwidth of the node. Unit: MB/s.
            /// 
            /// > This parameter is returned only if the return value of **Service** is **redis**, which indicates a data node.
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// The retention period of binlogs.
            /// </summary>
            [NameInMap("BinlogRetentionDays")]
            [Validation(Required=false)]
            public int? BinlogRetentionDays { get; set; }

            /// <summary>
            /// The type of workload. The return value is **ALIYUN**.
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The maximum memory capacity per data node. Unit: MB.
            /// 
            /// > This parameter is returned only if the return value of **Service** is **redis**, which indicates a data node.
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// The specifications of the data node. For more information, see [Community Edition instances that use cloud disks](https://help.aliyun.com/document_detail/164477.html).
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The maximum number of connections supported by the data node.
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public long? Connections { get; set; }

            /// <summary>
            /// The current bandwidth of the node, which consists of the default bandwidth and the increased bandwidth. Unit: MB/s.
            /// 
            /// > This parameter is returned only if the instance is created in a dedicated cluster.
            /// </summary>
            [NameInMap("CurrentBandWidth")]
            [Validation(Required=false)]
            public long? CurrentBandWidth { get; set; }

            /// <summary>
            /// The storage capacity of the [enhanced SSD (ESSD)](https://help.aliyun.com/document_detail/122389.html) that is used by the data node. Unit: MB.
            /// 
            /// > The ESSD is used only to store system operating data, such as Persistent Memory (PMEM). It is not used as a medium to write and read data.
            /// </summary>
            [NameInMap("DiskSizeMB")]
            [Validation(Required=false)]
            public int? DiskSizeMB { get; set; }

            /// <summary>
            /// The ID of the replica set in the node.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the data node.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of replica nodes.
            /// </summary>
            [NameInMap("ReplicaSize")]
            [Validation(Required=false)]
            public int? ReplicaSize { get; set; }

            /// <summary>
            /// The name of the resource group to which the node belongs.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// The node type. Valid values:
            /// 
            /// *   **redis**: data node
            /// *   **redis_cs**: config server
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// The major version of the node.
            /// </summary>
            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
