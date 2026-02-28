// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorEntriesResponseBody : TeaModel {
        [NameInMap("Ipv6TranslatorEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries Ipv6TranslatorEntries { get; set; }
        public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntries : TeaModel {
            [NameInMap("Ipv6TranslatorEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry> Ipv6TranslatorEntry { get; set; }
            public class DescribeIPv6TranslatorEntriesResponseBodyIpv6TranslatorEntriesIpv6TranslatorEntry : TeaModel {
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                [NameInMap("AllocateIpv6Port")]
                [Validation(Required=false)]
                public int? AllocateIpv6Port { get; set; }

                [NameInMap("BackendIpv4Addr")]
                [Validation(Required=false)]
                public string BackendIpv4Addr { get; set; }

                [NameInMap("BackendIpv4Port")]
                [Validation(Required=false)]
                public string BackendIpv4Port { get; set; }

                [NameInMap("EntryBandwidth")]
                [Validation(Required=false)]
                public string EntryBandwidth { get; set; }

                [NameInMap("EntryDescription")]
                [Validation(Required=false)]
                public string EntryDescription { get; set; }

                [NameInMap("EntryName")]
                [Validation(Required=false)]
                public string EntryName { get; set; }

                [NameInMap("EntryStatus")]
                [Validation(Required=false)]
                public string EntryStatus { get; set; }

                [NameInMap("Ipv6TranslatorEntryId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorEntryId { get; set; }

                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("TransProtocol")]
                [Validation(Required=false)]
                public string TransProtocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
