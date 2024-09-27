// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The available address pools of the domain name type.</para>
        /// </summary>
        [NameInMap("DomainAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools DomainAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPools : TeaModel {
            [NameInMap("DomainAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPoolsDomainAddrPool> DomainAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyDomainAddrPoolsDomainAddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testpool</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The available address pools of the IPv4 type.</para>
        /// </summary>
        [NameInMap("Ipv4AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools Ipv4AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPools : TeaModel {
            [NameInMap("Ipv4AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPoolsIpv4AddrPool> Ipv4AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv4AddrPoolsIpv4AddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testpool</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The available address pools of the IPv6 type.</para>
        /// </summary>
        [NameInMap("Ipv6AddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools Ipv6AddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPools : TeaModel {
            [NameInMap("Ipv6AddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPoolsIpv6AddrPool> Ipv6AddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyIpv6AddrPoolsIpv6AddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testpool</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The source regions.</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// <para>The parent line code of the source region. Leave it blank if no parent line exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>telecom</para>
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// <para>The line name of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The name of the source region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The line code of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The code of the source region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2851BA9-CE56-49AF-8D12-4FC6A49EE688</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SelectedDomainLines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedDomainLines SelectedDomainLines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedDomainLines : TeaModel {
            [NameInMap("SelectedDomainLine")]
            [Validation(Required=false)]
            public List<string> SelectedDomainLine { get; set; }

        }

        [NameInMap("SelectedIpv4Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv4Lines SelectedIpv4Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv4Lines : TeaModel {
            [NameInMap("SelectedIpv4Line")]
            [Validation(Required=false)]
            public List<string> SelectedIpv4Line { get; set; }

        }

        [NameInMap("SelectedIpv6Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv6Lines SelectedIpv6Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyAvailableConfigResponseBodySelectedIpv6Lines : TeaModel {
            [NameInMap("SelectedIpv6Line")]
            [Validation(Required=false)]
            public List<string> SelectedIpv6Line { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether we recommend that you set the source region to global.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

    }

}
