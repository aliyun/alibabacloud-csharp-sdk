// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityGroups")]
        [Validation(Required=true)]
        public DescribeSecurityGroupsResponseSecurityGroups SecurityGroups { get; set; }
        public class DescribeSecurityGroupsResponseSecurityGroups : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=true)]
            public List<DescribeSecurityGroupsResponseSecurityGroupsSecurityGroup> SecurityGroup { get; set; }
            public class DescribeSecurityGroupsResponseSecurityGroupsSecurityGroup : TeaModel {
                public string SecurityGroupId { get; set; }
                public string CreationTime { get; set; }
                public string SecurityGroupName { get; set; }
            }
        };

    }

}
