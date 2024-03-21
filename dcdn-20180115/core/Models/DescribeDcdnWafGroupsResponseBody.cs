// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
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
        /// The number of WAF rule groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of WAF rule groups.
        /// </summary>
        [NameInMap("WafGroups")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGroupsResponseBodyWafGroups> WafGroups { get; set; }
        public class DescribeDcdnWafGroupsResponseBodyWafGroups : TeaModel {
            /// <summary>
            /// The time when the WAF rule group was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the custom WAF rule group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the WAF rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The policy that is associated with the WAF rule group.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafGroupsResponseBodyWafGroupsPolicies> Policies { get; set; }
            public class DescribeDcdnWafGroupsResponseBodyWafGroupsPolicies : TeaModel {
                /// <summary>
                /// The ID of the policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the policy.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the policy. Valid values:
                /// 
                /// *   **custom**: a custom policy
                /// *   **default**: the default policy
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The number of WAF rules.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// Indicates whether to enable subscription. Valid values:
            /// 
            /// *   **on**
            /// *   **off**
            /// </summary>
            [NameInMap("Subscribe")]
            [Validation(Required=false)]
            public string Subscribe { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
