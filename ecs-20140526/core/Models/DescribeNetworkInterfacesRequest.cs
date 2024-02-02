// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// The ID of the instance to which the ENI is attached.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// An array that consists of the IPv6 address of the ENI. You can specify multiple IPv6 addresses. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 10 to 500.
        /// 
        /// Default values:
        /// 
        /// *   If this parameter is not specified or if this parameter is set to a value less than 10, the default value is 10.
        /// *   If this parameter is set to a value greater than 500, the default value is 500.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// An array that consists of the IDs of the ENIs. You specify multiple ENI IDs. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceId { get; set; }

        /// <summary>
        /// The name of the ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value returned in the last call to this operation.
        /// 
        /// For more information about how to check the responses returned by this operation, see the preceding "Description" section.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// >This parameter is no longer used. We recommend that you specify the MaxResults or NextToken parameter for a paged query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageNumber { get; set; }

        /// <summary>
        /// >This parameter is no longer used. We recommend that you specify the MaxResults or NextToken parameter for a paged query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// The primary private IPv4 address of the ENI.
        /// </summary>
        [NameInMap("PrimaryIpAddress")]
        [Validation(Required=false)]
        public string PrimaryIpAddress { get; set; }

        /// <summary>
        /// An array that consists of the secondary private IPv4 addresses of the ENI. You can specify multiple secondary private IPv4 addresses. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// The region ID of the ENI. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the ENI belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be returned.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of how this parameter is set.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the security group to which the secondary ENI belongs.
        /// 
        /// *   To query the details of secondary ENIs based on the ID of a security group, specify this parameter.
        /// *   To query the details of primary ENIs based on the ID of a security group, call the [DescribeInstances](~~25506~~) operation and specify the `SecurityGroupId` parameter.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Specifies whether the user of the ENI is an Alibaba Cloud service or a distributor.
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The state of the ENI. Valid values:
        /// 
        /// *   Available: The ENI is available.
        /// *   Attaching: The ENI is being attached to an instance.
        /// *   InUse: The ENI is attached to an instance.
        /// *   Detaching: The ENI is being detached from an instance.
        /// *   Deleting: The ENI is being deleted.
        /// 
        /// This parameter is empty by default, which indicates that ENIs in all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags to use for query.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfacesRequestTag> Tag { get; set; }
        public class DescribeNetworkInterfacesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the ENI. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the ENI. Valid values of N: 1 to 20.
            /// 
            /// If a single tag is specified to query ENIs, up to 1,000 ENIs that have this tag can be returned. If multiple tags are specified to query ENIs, up to 1,000 ENIs that have all these tags can be returned. To query more than 1,000 resources that have specified tags, call the [ListTagResources](~~110425~~) operation.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the ENI. Valid values:
        /// 
        /// *   Primary
        /// *   Secondary
        /// 
        /// This parameter is empty by default, which indicates that both primary and secondary ENIs are queried.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the vSwitch with which the ENI is associated.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the ENI belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
