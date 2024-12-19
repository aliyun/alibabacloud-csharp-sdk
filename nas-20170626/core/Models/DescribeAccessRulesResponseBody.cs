// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The rules in the permission group.</para>
        /// </summary>
        [NameInMap("AccessRules")]
        [Validation(Required=false)]
        public DescribeAccessRulesResponseBodyAccessRules AccessRules { get; set; }
        public class DescribeAccessRulesResponseBodyAccessRules : TeaModel {
            [NameInMap("AccessRule")]
            [Validation(Required=false)]
            public List<DescribeAccessRulesResponseBodyAccessRulesAccessRule> AccessRule { get; set; }
            public class DescribeAccessRulesResponseBodyAccessRulesAccessRule : TeaModel {
                /// <summary>
                /// <para>The name of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AccessGroupName")]
                [Validation(Required=false)]
                public string AccessGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccessRuleId")]
                [Validation(Required=false)]
                public string AccessRuleId { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: General-purpose File Storage NAS (NAS) file system</description></item>
                /// <item><description>extreme: Extreme NAS file system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The IPv6 address or CIDR block of the authorized object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001:250:6000::***</para>
                /// </summary>
                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                /// <summary>
                /// <para>The priority of the rule.</para>
                /// <para>If multiple rules are attached to the authorized object, the rule with the highest priority takes effect.</para>
                /// <para>Valid values: 1 to 100. The value 1 indicates the highest priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The access permissions of the authorized object on the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RDWR (default): the read and write permissions</description></item>
                /// <item><description>RDONLY: the read-only permissions</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RDWR</para>
                /// </summary>
                [NameInMap("RWAccess")]
                [Validation(Required=false)]
                public string RWAccess { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The IP address or CIDR block of the authorized object.</para>
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// <para>The access permissions for different types of users in the authorized object.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>no_squash: allows access from root users to the file system.</description></item>
                /// <item><description>root_squash: grants root users the least permissions as the nobody user.</description></item>
                /// <item><description>all_squash: grants all users the least permissions as the nobody user.</description></item>
                /// </list>
                /// <para>The nobody user has the least permissions in Linux and can access only the public content of the file system. This ensures the security of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_squash</para>
                /// </summary>
                [NameInMap("UserAccess")]
                [Validation(Required=false)]
                public string UserAccess { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86D89E82-4297-4343-8E1E-A2495B35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
