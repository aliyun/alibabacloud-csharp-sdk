// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// The role of the node. Valid values:
        /// 
        /// *   **master**: master node
        /// *   **slave**: replica node
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
                /// The number of the returned page.
                /// </summary>
                [NameInMap("CurrentBandWidth")]
                [Validation(Required=false)]
                public long? CurrentBandWidth { get; set; }

                /// <summary>
                /// The number of entries to return on each page. Valid values: **10**, **20**, and **50**. Default value: **10**.
                /// </summary>
                [NameInMap("CurrentMinorVersion")]
                [Validation(Required=false)]
                public string CurrentMinorVersion { get; set; }

                [NameInMap("CustinsId")]
                [Validation(Required=false)]
                public string CustinsId { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **db**: data node.
                /// *   **proxy**: proxy node.
                /// *   **normal**: regular node. This value is returned when the instance runs in the standard architecture.
                /// </summary>
                [NameInMap("DefaultBandWidth")]
                [Validation(Required=false)]
                public long? DefaultBandWidth { get; set; }

                /// <summary>
                /// Indicates whether the minor version is the latest version. Valid values:
                /// 
                /// *   **0**: The minor version is not the latest version.
                /// *   **1**: The minor version is the latest version.
                /// 
                /// >  To update the minor version, call the [ModifyInstanceMinorVersion](~~129381~~) operation.
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// Details about each node in an ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("InsType")]
                [Validation(Required=false)]
                public int? InsType { get; set; }

                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public int? IsLatestVersion { get; set; }

                /// <summary>
                /// DescribeRoleZoneInfo
                /// </summary>
                [NameInMap("IsOpenBandWidthService")]
                [Validation(Required=false)]
                public bool? IsOpenBandWidthService { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// Queries information about the type, minor version, and bandwidth of specific nodes in an ApsaraDB for Redis instance, and zones where the nodes are deployed.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query instance IDs.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Indicates whether the bandwidth of the node is increased. Valid values:
        /// 
        /// *   **true**: The bandwidth of the node is not increased.
        /// *   **false**: The bandwidth of the node is increased.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// This parameter is used only for internal maintenance of ApsaraDB for Redis instances.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the node is a read replica. If the node is a read replica, **3** is returned.
        /// 
        /// >  If the node is not a read replica, no value is returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
