// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessRulesResponseBody : TeaModel {
        /// <summary>
        /// The rules in the permission group.
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
                /// The ID of the rule.
                /// </summary>
                [NameInMap("AccessRuleId")]
                [Validation(Required=false)]
                public string AccessRuleId { get; set; }

                /// <summary>
                /// The IPv6 address or CIDR block of the authorized object.
                /// </summary>
                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                /// <summary>
                /// The priority of the rule.
                /// 
                /// If multiple rules are attached to the authorized object, the rule with the highest priority takes effect.
                /// 
                /// Valid values: 1 to 100. The value 1 indicates the highest priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The access permissions of the authorized object on the file system.
                /// 
                /// Valid values:
                /// 
                /// *   RDWR (default): the read and write permissions
                /// *   RDONLY: the read-only permissions
                /// </summary>
                [NameInMap("RWAccess")]
                [Validation(Required=false)]
                public string RWAccess { get; set; }

                /// <summary>
                /// The IP address or CIDR block of the authorized object.
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// The access permissions for different types of users in the authorized object.
                /// 
                /// Valid values:
                /// 
                /// *   no_squash: allows access from root users to the file system.
                /// *   root_squash: grants root users the least permissions as the nobody user.
                /// *   all_squash: grants all users the least permissions as the nobody user.
                /// 
                /// The nobody user has the least permissions in Linux and can access only the public content of the file system. This ensures the security of the file system.
                /// </summary>
                [NameInMap("UserAccess")]
                [Validation(Required=false)]
                public string UserAccess { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
