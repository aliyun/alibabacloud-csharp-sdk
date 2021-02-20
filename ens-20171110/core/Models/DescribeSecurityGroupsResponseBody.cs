// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
                public string CreationTime { get; set; }
                public string SecurityGroupId { get; set; }
                public string SecurityGroupName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
