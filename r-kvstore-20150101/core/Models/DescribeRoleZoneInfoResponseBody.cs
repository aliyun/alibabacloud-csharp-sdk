// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// Details about each node in an ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyNode Node { get; set; }
        public class DescribeRoleZoneInfoResponseBodyNode : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyNodeNodeInfo> NodeInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyNodeNodeInfo : TeaModel {
                /// <summary>
                /// The current bandwidth of the node, which consists of the default bandwidth and the increased bandwidth. Unit: MB/s.
                /// 
                /// > *   You can call the [EnableAdditionalBandwidth](https://help.aliyun.com/document_detail/206173.html) operation to specify the increased bandwidth.
                /// > *   You can also use this parameter to calculate the increased bandwidth. For example, if the default bandwidth of the node is 96 MB/s and the returned value of this parameter is 100, the increased bandwidth is 4 MB/s.
                /// </summary>
                [NameInMap("CurrentBandWidth")]
                [Validation(Required=false)]
                public long? CurrentBandWidth { get; set; }

                /// <summary>
                /// The minor version of the node.
                /// </summary>
                [NameInMap("CurrentMinorVersion")]
                [Validation(Required=false)]
                public string CurrentMinorVersion { get; set; }

                /// <summary>
                /// The ID of the data shard.
                /// </summary>
                [NameInMap("CustinsId")]
                [Validation(Required=false)]
                public string CustinsId { get; set; }

                /// <summary>
                /// The default bandwidth of the node. Unit: MB/s.
                /// </summary>
                [NameInMap("DefaultBandWidth")]
                [Validation(Required=false)]
                public long? DefaultBandWidth { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// Indicates whether the node is a read replica. If the node is a read replica, **3** is returned.
                /// 
                /// >  If the node is not a read replica, no value is returned.
                /// </summary>
                [NameInMap("InsType")]
                [Validation(Required=false)]
                public int? InsType { get; set; }

                /// <summary>
                /// Indicates whether the minor version is the latest version. Valid values:
                /// 
                /// *   **0**: The minor version is not the latest version.
                /// *   **1**: The minor version is the latest version.
                /// 
                /// >  To update the minor version, call the [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) operation.
                /// </summary>
                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public int? IsLatestVersion { get; set; }

                /// <summary>
                /// Indicates whether the bandwidth of the node is increased. Valid values:
                /// 
                /// *   **true**: The bandwidth of the node is not increased.
                /// *   **false**: The bandwidth of the node is increased.
                /// </summary>
                [NameInMap("IsOpenBandWidthService")]
                [Validation(Required=false)]
                public bool? IsOpenBandWidthService { get; set; }

                /// <summary>
                /// This parameter is used only for internal maintenance of ApsaraDB for Redis instances.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **db**: data node.
                /// *   **proxy**: proxy node.
                /// *   **normal**: regular node. This value is returned when the instance runs in the standard architecture.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **master**: master node
                /// *   **slave**: replica node
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
