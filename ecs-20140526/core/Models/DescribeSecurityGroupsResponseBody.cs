// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public DescribeSecurityGroupsResponseBodySecurityGroups SecurityGroups { get; set; }
        public class DescribeSecurityGroupsResponseBodySecurityGroups : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroup : TeaModel {
                public string CreationTime { get; set; }
                public string VpcId { get; set; }
                public bool? ServiceManaged { get; set; }
                public string Description { get; set; }
                public string SecurityGroupId { get; set; }
                public string ResourceGroupId { get; set; }
                public string SecurityGroupName { get; set; }
                public int? EcsCount { get; set; }
                public long? ServiceID { get; set; }
                public string SecurityGroupType { get; set; }
                public int? AvailableInstanceAmount { get; set; }
                public DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags Tags { get; set; }
                public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag> Tag { get; set; }
                    public class DescribeSecurityGroupsResponseBodySecurityGroupsSecurityGroupTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
            }
        };

    }

}
