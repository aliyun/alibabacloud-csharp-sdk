// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAccessWhitelistResponseBody : TeaModel {
        /// <summary>
        /// The Elastic Compute Service (ECS) security groups that are associated with the cluster.
        /// </summary>
        [NameInMap("DBClusterSecurityGroups")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups DBClusterSecurityGroups { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroups : TeaModel {
            [NameInMap("DBClusterSecurityGroup")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup> DBClusterSecurityGroup { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyDBClusterSecurityGroupsDBClusterSecurityGroup : TeaModel {
                /// <summary>
                /// The ID of the ECS security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The name of the ECS security group.
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

        }

        /// <summary>
        /// The details about the cluster.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhitelistResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAccessWhitelistResponseBodyItems : TeaModel {
            [NameInMap("DBClusterIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray> DBClusterIPArray { get; set; }
            public class DescribeDBClusterAccessWhitelistResponseBodyItemsDBClusterIPArray : TeaModel {
                /// <summary>
                /// The attributes of the IP whitelist group. Set this parameter to **hidden** to hide the IP whitelist group in the console.
                /// 
                /// > *   The IP whitelist group that has appeared in the console cannot be hidden.
                /// > *   This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// The name of the IP whitelist group. The group name must be 2 to 120 characters in length and consists of lowercase letters and digits. It must start with a letter, and end with a letter or a digit.
                /// 
                /// *   If the specified whitelist group name does not exist, the whitelist group is created.
                /// *   If the specified whitelist group name exists, the whitelist group is modified.
                /// *   If you do not specify this parameter, the default group is modified.
                /// 
                /// > *   You can create a maximum of 50 IP whitelist groups for a cluster.
                /// >*   This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// The IP addresses or Classless Inter-Domain Routing (CIDR) blocks in the IP whitelist group. You can add 1,000 IP addresses or CIDR blocks to all the IP whitelist groups. Separate multiple IP addresses with commas (,). The following two formats are supported:
                /// 
                /// *   IP addresses. Example: 10.23.12.24.
                /// *   CIDR blocks. Example: 10.23.12.24/24. 24 indicates the length of the prefix of the CIDR block. The length is the range of 1 to 32.
                /// 
                /// >  This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
                /// </summary>
                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
