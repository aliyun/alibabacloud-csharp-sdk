// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessRulesResponseBody : TeaModel {
        [NameInMap("AccessRules")]
        [Validation(Required=false)]
        public DescribeAccessRulesResponseBodyAccessRules AccessRules { get; set; }
        public class DescribeAccessRulesResponseBodyAccessRules : TeaModel {
            [NameInMap("AccessRule")]
            [Validation(Required=false)]
            public List<DescribeAccessRulesResponseBodyAccessRulesAccessRule> AccessRule { get; set; }
            public class DescribeAccessRulesResponseBodyAccessRulesAccessRule : TeaModel {
                [NameInMap("AccessGroupName")]
                [Validation(Required=false)]
                public string AccessGroupName { get; set; }

                [NameInMap("AccessRuleId")]
                [Validation(Required=false)]
                public string AccessRuleId { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("RWAccess")]
                [Validation(Required=false)]
                public string RWAccess { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

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
