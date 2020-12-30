// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Ipv6Translators")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorsResponseBodyIpv6Translators Ipv6Translators { get; set; }
        public class DescribeIPv6TranslatorsResponseBodyIpv6Translators : TeaModel {
            [NameInMap("Ipv6Translator")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator> Ipv6Translator { get; set; }
            public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator : TeaModel {
                public string Status { get; set; }
                public string Spec { get; set; }
                public long? CreateTime { get; set; }
                public string PayType { get; set; }
                public string AllocateIpv4Addr { get; set; }
                public string Ipv6TranslatorId { get; set; }
                public DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds Ipv6TranslatorEntryIds { get; set; }
                public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds : TeaModel {
                    [NameInMap("Ipv6TranslatorEntryId")]
                    [Validation(Required=false)]
                    public List<string> Ipv6TranslatorEntryId { get; set; }

                }
                public string AvailableBandwidth { get; set; }
                public string RegionId { get; set; }
                public long? EndTime { get; set; }
                public int? Bandwidth { get; set; }
                public string Description { get; set; }
                public string BusinessStatus { get; set; }
                public string AllocateIpv6Addr { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
