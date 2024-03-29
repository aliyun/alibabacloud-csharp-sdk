// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. If the return value of this parameter is empty when MaxResults and NextToken are used for a paged query, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// > This parameter will be deprecated in the future. We recommend that you use NextToken and MaxResults for a paged query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// > This parameter will be deprecated in the future. We recommend that you use NextToken and MaxResults for a paged query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the security group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the security groups.
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public DescribeSecurityGroupsResponseBodySecurityGroups SecurityGroups { get; set; }
        public class DescribeSecurityGroupsResponseBodySecurityGroups : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup : TeaModel {
                /// <summary>
                /// > This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("AvailableInstanceAmount")]
                [Validation(Required=false)]
                public int? AvailableInstanceAmount { get; set; }

                /// <summary>
                /// The time when the security group was created. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the security group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// > This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                /// <summary>
                /// The ID of the resource group to which the security group belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The security group ID.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The name of the security group.
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

                /// <summary>
                /// The type of the security group. Valid values:
                /// 
                /// *   normal: basic security group
                /// *   enterprise: advanced security group
                /// </summary>
                [NameInMap("SecurityGroupType")]
                [Validation(Required=false)]
                public string SecurityGroupType { get; set; }

                /// <summary>
                /// The ID of the distributor to which the security group belongs.
                /// </summary>
                [NameInMap("ServiceID")]
                [Validation(Required=false)]
                public long? ServiceID { get; set; }

                /// <summary>
                /// Indicates whether the user of the security group is an Alibaba Cloud service or a distributor.
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public bool? ServiceManaged { get; set; }

                /// <summary>
                /// The tags of the security groups.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags Tags { get; set; }
                public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag> Tag { get; set; }
                    public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the security group.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the security group.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the VPC to which the security group belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The total number of security groups returned. If `MaxResults` and `NextToken` are specified in the request, the value of this parameter is not returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
