// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorsResponseBody : TeaModel {
        /// <summary>
        /// The list of IPv6 Translation Service instances.
        /// </summary>
        [NameInMap("Ipv6Translators")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorsResponseBodyIpv6Translators Ipv6Translators { get; set; }
        public class DescribeIPv6TranslatorsResponseBodyIpv6Translators : TeaModel {
            [NameInMap("Ipv6Translator")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator> Ipv6Translator { get; set; }
            public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator : TeaModel {
                /// <summary>
                /// The IPv4 address allocated to the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("AllocateIpv4Addr")]
                [Validation(Required=false)]
                public string AllocateIpv4Addr { get; set; }

                /// <summary>
                /// The IPv6 address allocated to the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                /// <summary>
                /// The bandwidth of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("AvailableBandwidth")]
                [Validation(Required=false)]
                public string AvailableBandwidth { get; set; }

                /// <summary>
                /// The bandwidth of the IPv6 Translation Service instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The business status of the IPv6 Translation Service instance. Valid values:
                /// 
                /// *   **Normal**
                /// *   **FinancialLocked**
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The timestamp when the IPv6 Translation Service instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The timestamp when IPv6 Translation Service instance expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The IDs of IPv6 mapping entries of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Ipv6TranslatorEntryIds")]
                [Validation(Required=false)]
                public DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds Ipv6TranslatorEntryIds { get; set; }
                public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds : TeaModel {
                    [NameInMap("Ipv6TranslatorEntryId")]
                    [Validation(Required=false)]
                    public List<string> Ipv6TranslatorEntryId { get; set; }

                }

                /// <summary>
                /// The ID of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                /// <summary>
                /// The name of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The billing method of the IPv6 Translation Service instance.
                /// 
                /// *   **Prepay**: subscription
                /// *   **Postpay**: pay-as-you-go
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The region of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The specification of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The status of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
