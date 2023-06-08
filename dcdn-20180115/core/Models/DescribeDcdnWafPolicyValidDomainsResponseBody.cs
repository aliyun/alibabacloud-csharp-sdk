// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPolicyValidDomainsResponseBody : TeaModel {
        /// <summary>
        /// The information about the protected domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafPolicyValidDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDcdnWafPolicyValidDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// The protected domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The policy that is bound to the domain name.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafPolicyValidDomainsResponseBodyDomainsPolicies> Policies { get; set; }
            public class DescribeDcdnWafPolicyValidDomainsResponseBodyDomainsPolicies : TeaModel {
                /// <summary>
                /// The ID of the rule.
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
                /// The type of the policy.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
            /// Indicates whether the protection policy is the default policy. Valid values:
            /// 
            /// *   default: The protection policy is the default policy.
            /// *   custom: The protection policy is not the default policy.
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// The page number of the returned page, which is the same as the PageNumber parameter in request parameters.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names returned per page, which is the same as the PageSize parameter in request parameters.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain names returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
