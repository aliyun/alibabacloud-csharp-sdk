// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAccessWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The Elastic Compute Service (ECS) security groups that are associated with the cluster.</para>
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
                /// <para>The ID of the ECS security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp**************</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the ECS security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-********************</para>
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The details about the cluster.</para>
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
                /// <para>The attributes of the IP whitelist group. Set this parameter to <b>hidden</b> to hide the IP whitelist group in the console.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The IP whitelist group that has appeared in the console cannot be hidden.</description></item>
                /// <item><description>This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>hidden</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// <para>The name of the IP whitelist group. The group name must be 2 to 120 characters in length and consists of lowercase letters and digits. It must start with a letter, and end with a letter or a digit.</para>
                /// <list type="bullet">
                /// <item><description>If the specified whitelist group name does not exist, the whitelist group is created.</description></item>
                /// <item><description>If the specified whitelist group name exists, the whitelist group is modified.</description></item>
                /// <item><description>If you do not specify this parameter, the default group is modified.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>You can create a maximum of 50 IP whitelist groups for a cluster.</description></item>
                /// <item><description>This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// <para>The IP addresses or Classless Inter-Domain Routing (CIDR) blocks in the IP whitelist group. You can add 1,000 IP addresses or CIDR blocks to all the IP whitelist groups. Separate multiple IP addresses with commas (,). The following two formats are supported:</para>
                /// <list type="bullet">
                /// <item><description>IP addresses. Example: 10.23.12.24.</description></item>
                /// <item><description>CIDR blocks. Example: 10.23.12.24/24. 24 indicates the length of the prefix of the CIDR block. The length is the range of 1 to 32.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter can be specified only when the <b>WhiteListType</b> parameter is set to <b>IP</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>11.<em><b>.</b></em>.<em><b>,11.</b></em>.<em><b>.</b></em></para>
                /// </summary>
                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>559E91A2-CDA3-4E9F-808B-29D738******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
