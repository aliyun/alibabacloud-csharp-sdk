// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAttributeResponseBody : TeaModel {
        /// <summary>
        /// The IPv4 CIDR block of the network.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The list of resources in the network.
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeNetworkAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeNetworkAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                /// <summary>
                /// The number of resources in the network.
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// The resource type. VSwitch.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// The time when the network was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The description of the network.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The ID of the network access control list (ACL).
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The ID of the network.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The name of the network.
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the route table.
        /// </summary>
        [NameInMap("RouterTableId")]
        [Validation(Required=false)]
        public string RouterTableId { get; set; }

        /// <summary>
        /// The status of the network. Valid values:
        /// 
        /// *   Pending
        /// *   Available
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The list of vSwitches in the network.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public DescribeNetworkAttributeResponseBodyVSwitchIds VSwitchIds { get; set; }
        public class DescribeNetworkAttributeResponseBodyVSwitchIds : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public List<string> VSwitchId { get; set; }

        }

    }

}
