// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page. Valid values: **1** to **100000**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of protection policies returned per page. Valid values: an integer from **1** to **500**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The information about protection policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeDcdnWafPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The type of the protection policy, which is the same as the DefenseScenes field in the QueryArgs parameter.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The number of domain names that use the protection policy.
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public int? DomainCount { get; set; }

            /// <summary>
            /// The time when the protection policy was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the protection policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The name of the protection policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The status of the protection policy, which is the same as the PolicyStatus field in the QueryArgs parameter.
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// Indicates whether this protection policy is the default policy, which is the same as the PolicyType field in the QueryArgs parameter.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The number of protection rules in the protection policy.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of protection policies.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
