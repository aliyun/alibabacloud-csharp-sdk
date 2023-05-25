// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the security group.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// 
        /// > This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.
        /// </summary>
        [NameInMap("FuzzyQuery")]
        [Validation(Required=false)]
        public bool? FuzzyQuery { get; set; }

        /// <summary>
        /// The ID of the resource group to which the security groups belong. When you use this parameter to filter resources, the number of resources in the specified resource group cannot exceed 1,000. You can call the [ListResourceGroups](~~158855~~) operation to query the most recent resource group list.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of how you specify this parameter.
        /// </summary>
        [NameInMap("IsQueryEcsCount")]
        [Validation(Required=false)]
        public bool? IsQueryEcsCount { get; set; }

        /// <summary>
        /// The network type of the security group. Valid values:
        /// 
        /// *   vpc: virtual private cloud (VPC)
        /// *   classic: classic network
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The name of the security group.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. If you specify the MaxResults parameter, the `MaxResults` and `NextToken` parameters are used for a paged query.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
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
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// 
        /// > This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IDs of security groups. The value is a JSON array that consists of up to 100 security group IDs. Separate the IDs with commas (,).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags of the security group.
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
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the security groups belong.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public string SecurityGroupIds { get; set; }

        /// <summary>
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Set this parameter to the NextToken value that is returned when you called the DescribeInstanceTypes operation last time. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// The tags of the security group.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSecurityGroupsRequestTag> Tag { get; set; }
        public class DescribeSecurityGroupsRequestTag : TeaModel {
            /// <summary>
            /// The tag values of the security group. You can specify up to 20 tag values for the security group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values of the security group.
            /// 
            /// > This parameter will be removed in the future. We recommend that you use the Tag.N.Value parameter to ensure future compatibility.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the security group. Valid values:
        /// 
        /// *   normal: basic security group
        /// *   enterprise: advanced security group
        /// 
        /// > If you do not specify this parameter, basic and advanced security groups are queried.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
