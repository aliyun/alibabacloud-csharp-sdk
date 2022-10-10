// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAccessWhitelistResponseBody : TeaModel {
        [NameInMap("DBClusterSecurityGroups")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups DBClusterSecurityGroups { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups : TeaModel {
            [NameInMap("DBClusterSecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup> DBClusterSecurityGroup { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup : TeaModel {
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

        }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyItems : TeaModel {
            [NameInMap("DBClusterIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray> DBClusterIPArray { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray : TeaModel {
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
