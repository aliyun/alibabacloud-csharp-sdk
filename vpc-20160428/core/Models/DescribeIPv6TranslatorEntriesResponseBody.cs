// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorEntriesResponseBody : TeaModel {
        /// <summary>
        /// The IPv6 mapping entries that are queried.
        /// </summary>
        [NameInMap("Ipv6TranslatorEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries Ipv6TranslatorEntries { get; set; }
        public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries : TeaModel {
            [NameInMap("Ipv6TranslatorEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry> Ipv6TranslatorEntry { get; set; }
            public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry : TeaModel {
                /// <summary>
                /// The ID of the associated ACL.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// Indicates whether ACLs are enabled.
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                /// <summary>
                /// The ACL type.
                /// 
                /// *   **white**: a whitelist. IPv6 addresses in the ACL are allowed to access backend services.
                /// *   **black**: a blacklist. IPv6 addresses in the ACL are not allowed to access backend services.
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// The IPv6 address allocated to the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                /// <summary>
                /// The port used by the IPv6 address allocated to the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("AllocateIpv6Port")]
                [Validation(Required=false)]
                public int? AllocateIpv6Port { get; set; }

                /// <summary>
                /// The public IP address of the backend IPv4 server.
                /// </summary>
                [NameInMap("BackendIpv4Addr")]
                [Validation(Required=false)]
                public string BackendIpv4Addr { get; set; }

                /// <summary>
                /// The public IPv4 port used by the IPv4 server that needs to provide IPv6 access.
                /// </summary>
                [NameInMap("BackendIpv4Port")]
                [Validation(Required=false)]
                public string BackendIpv4Port { get; set; }

                /// <summary>
                /// The bandwidth specified in the IPv6 mapping entry.
                /// </summary>
                [NameInMap("EntryBandwidth")]
                [Validation(Required=false)]
                public string EntryBandwidth { get; set; }

                /// <summary>
                /// The description of the IPv6 mapping entry.
                /// </summary>
                [NameInMap("EntryDescription")]
                [Validation(Required=false)]
                public string EntryDescription { get; set; }

                /// <summary>
                /// The name of the IPv6 mapping entry.
                /// </summary>
                [NameInMap("EntryName")]
                [Validation(Required=false)]
                public string EntryName { get; set; }

                /// <summary>
                /// The status of the IPv6 mapping entry.
                /// </summary>
                [NameInMap("EntryStatus")]
                [Validation(Required=false)]
                public string EntryStatus { get; set; }

                /// <summary>
                /// The ID of the IPv6 mapping entry.
                /// </summary>
                [NameInMap("Ipv6TranslatorEntryId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorEntryId { get; set; }

                /// <summary>
                /// The ID of the IPv6 Translation Service instance to which the IPv6 mapping entry belongs.
                /// </summary>
                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                /// <summary>
                /// The region of the IPv6 Translation Service instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The protocol.
                /// </summary>
                [NameInMap("TransProtocol")]
                [Validation(Required=false)]
                public string TransProtocol { get; set; }

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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
