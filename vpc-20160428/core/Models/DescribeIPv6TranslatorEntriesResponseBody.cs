// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorEntriesResponseBody : TeaModel {
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

        [NameInMap("Ipv6TranslatorEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries Ipv6TranslatorEntries { get; set; }
        public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries : TeaModel {
            [NameInMap("Ipv6TranslatorEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry> Ipv6TranslatorEntry { get; set; }
            public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry : TeaModel {
                public string EntryStatus { get; set; }
                public string AclType { get; set; }
                public string TransProtocol { get; set; }
                public string EntryDescription { get; set; }
                public string Ipv6TranslatorId { get; set; }
                public string BackendIpv4Addr { get; set; }
                public int? AllocateIpv6Port { get; set; }
                public string Ipv6TranslatorEntryId { get; set; }
                public string BackendIpv4Port { get; set; }
                public string RegionId { get; set; }
                public string EntryBandwidth { get; set; }
                public string AclId { get; set; }
                public string EntryName { get; set; }
                public string AclStatus { get; set; }
                public string AllocateIpv6Addr { get; set; }
            }
        };

    }

}
