// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainResponseBody : TeaModel {
        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("OutPutDomains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDomainResponseBodyOutPutDomains> OutPutDomains { get; set; }
        public class DescribeDcdnWafDomainResponseBodyOutPutDomains : TeaModel {
            /// <summary>
            /// The status of the ACL. Valid values:
            /// 
            /// *   0: disabled
            /// *   1: enabled
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public int? AclStatus { get; set; }

            /// <summary>
            /// The status of protection against HTTP flood attacks. Valid values:
            /// 
            /// *   0: disabled
            /// *   1: enabled
            /// </summary>
            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public int? CcStatus { get; set; }

            /// <summary>
            /// The domain name that has WAF enabled.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The status of the domain name. Valid values:
            /// 
            /// *   1: The domain name is added to WAF, or the domain name is valid.
            /// *   10: The domain name is being added to WAF.
            /// *   11: The domain name failed to be added to WAF.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The status of WAF. Valid values:
            /// 
            /// *   0: disabled
            /// *   1: enabled
            /// </summary>
            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public int? WafStatus { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of accelerated domain names returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
