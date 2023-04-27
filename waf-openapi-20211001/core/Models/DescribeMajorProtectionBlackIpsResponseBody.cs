// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMajorProtectionBlackIpsResponseBody : TeaModel {
        /// <summary>
        /// An array of IP addresses in the IP address blacklist.
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<DescribeMajorProtectionBlackIpsResponseBodyIpList> IpList { get; set; }
        public class DescribeMajorProtectionBlackIpsResponseBodyIpList : TeaModel {
            /// <summary>
            /// The description of the IP address in the blacklist.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time after which the IP address blacklist becomes invalid. Unit: seconds.
            /// 
            /// >  If the value of this parameter is **0**, the blacklist is permanently valid.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// The most recent time when the IP address blacklist was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The IP address in the IP address blacklist.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The ID of the IP address blacklist rule for major event protection.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The ID of the rule template for major event protection.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of IP addresses in the blacklist.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
