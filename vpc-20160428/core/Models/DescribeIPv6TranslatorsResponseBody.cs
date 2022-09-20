// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorsResponseBody : TeaModel {
        [NameInMap("Ipv6Translators")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorsResponseBodyIpv6Translators Ipv6Translators { get; set; }
        public class DescribeIPv6TranslatorsResponseBodyIpv6Translators : TeaModel {
            [NameInMap("Ipv6Translator")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator> Ipv6Translator { get; set; }
            public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator : TeaModel {
                [NameInMap("AllocateIpv4Addr")]
                [Validation(Required=false)]
                public string AllocateIpv4Addr { get; set; }

                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                [NameInMap("AvailableBandwidth")]
                [Validation(Required=false)]
                public string AvailableBandwidth { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Ipv6TranslatorEntryIds")]
                [Validation(Required=false)]
                public DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds Ipv6TranslatorEntryIds { get; set; }
                public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds : TeaModel {
                    [NameInMap("Ipv6TranslatorEntryId")]
                    [Validation(Required=false)]
                    public List<string> Ipv6TranslatorEntryId { get; set; }

                }

                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
