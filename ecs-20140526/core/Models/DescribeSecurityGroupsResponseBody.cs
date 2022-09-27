// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public DescribeSecurityGroupsResponseBodySecurityGroups SecurityGroups { get; set; }
        public class DescribeSecurityGroupsResponseBodySecurityGroups : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup : TeaModel {
                [NameInMap("AvailableInstanceAmount")]
                [Validation(Required=false)]
                public int? AvailableInstanceAmount { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

                [NameInMap("SecurityGroupType")]
                [Validation(Required=false)]
                public string SecurityGroupType { get; set; }

                [NameInMap("ServiceID")]
                [Validation(Required=false)]
                public long? ServiceID { get; set; }

                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public bool? ServiceManaged { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags Tags { get; set; }
                public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag> Tag { get; set; }
                    public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
