// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv6 mapping entries that are queried.</para>
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
                /// <para>The ID of the associated ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6transacl-bp1de2****</para>
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// <para>Indicates whether ACLs are enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AclStatus")]
                [Validation(Required=false)]
                public string AclStatus { get; set; }

                /// <summary>
                /// <para>The ACL type.</para>
                /// <list type="bullet">
                /// <item><description><b>white</b>: a whitelist. IPv6 addresses in the ACL are allowed to access backend services.</description></item>
                /// <item><description><b>black</b>: a blacklist. IPv6 addresses in the ACL are not allowed to access backend services.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>white</para>
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// <para>The IPv6 address allocated to the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2400:3200:1600::XX</para>
                /// </summary>
                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                /// <summary>
                /// <para>The port used by the IPv6 address allocated to the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("AllocateIpv6Port")]
                [Validation(Required=false)]
                public int? AllocateIpv6Port { get; set; }

                /// <summary>
                /// <para>The public IP address of the backend IPv4 server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.99.XX.XX</para>
                /// </summary>
                [NameInMap("BackendIpv4Addr")]
                [Validation(Required=false)]
                public string BackendIpv4Addr { get; set; }

                /// <summary>
                /// <para>The public IPv4 port used by the IPv4 server that needs to provide IPv6 access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("BackendIpv4Port")]
                [Validation(Required=false)]
                public string BackendIpv4Port { get; set; }

                /// <summary>
                /// <para>The bandwidth specified in the IPv6 mapping entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EntryBandwidth")]
                [Validation(Required=false)]
                public string EntryBandwidth { get; set; }

                /// <summary>
                /// <para>The description of the IPv6 mapping entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("EntryDescription")]
                [Validation(Required=false)]
                public string EntryDescription { get; set; }

                /// <summary>
                /// <para>The name of the IPv6 mapping entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("EntryName")]
                [Validation(Required=false)]
                public string EntryName { get; set; }

                /// <summary>
                /// <para>The status of the IPv6 mapping entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("EntryStatus")]
                [Validation(Required=false)]
                public string EntryStatus { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 mapping entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6transentry-bp1g8bhrde****</para>
                /// </summary>
                [NameInMap("Ipv6TranslatorEntryId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorEntryId { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 Translation Service instance to which the IPv6 mapping entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6trans-bp1858ys****</para>
                /// </summary>
                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                /// <summary>
                /// <para>The region of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
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
