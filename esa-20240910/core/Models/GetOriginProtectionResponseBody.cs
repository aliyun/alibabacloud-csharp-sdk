// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the latest back-to-origin IP address list is automatically enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AutoConfirmIPList")]
        [Validation(Required=false)]
        public string AutoConfirmIPList { get; set; }

        /// <summary>
        /// <para>The back-to-origin IP address whitelist that the site currently uses.</para>
        /// </summary>
        [NameInMap("CurrentIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyCurrentIPWhitelist CurrentIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyCurrentIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The IPv4 addresses or CIDR blocks in the back-to-origin IP address whitelist that the site currently uses.</para>
            /// </summary>
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            /// <summary>
            /// <para>The IPv6 addresses or CIDR blocks in the back-to-origin IP address whitelist that the site currently uses.</para>
            /// </summary>
            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

        /// <summary>
        /// <para>The changes in the back-to-origin IP address whitelist.</para>
        /// </summary>
        [NameInMap("DiffIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyDiffIPWhitelist DiffIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyDiffIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The added back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("AddedIPWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistAddedIPWhitelist AddedIPWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistAddedIPWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IPv6 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

            /// <summary>
            /// <para>The unchanged back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("NoChangeIpWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistNoChangeIpWhitelist NoChangeIpWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistNoChangeIpWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IPv6 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

            /// <summary>
            /// <para>The removed back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("RemovedIPWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistRemovedIPWhitelist RemovedIPWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistRemovedIPWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IPv6 addresses or CIDR blocks in the back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

        }

        /// <summary>
        /// <para>The latest back-to-origin IP address whitelist.</para>
        /// </summary>
        [NameInMap("LatestIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyLatestIPWhitelist LatestIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyLatestIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The IPv4 addresses or CIDR blocks in the latest back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            /// <summary>
            /// <para>The IPv6 addresses or CIDR blocks in the latest back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the back-to-origin IP address whitelist needs to be updated. If the current whitelist differs from the latest one, this parameter returns true.</para>
        /// <list type="bullet">
        /// <item><description><para>true: An update is required.</para>
        /// </description></item>
        /// <item><description><para>false: No update is required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedUpdate")]
        [Validation(Required=false)]
        public bool? NeedUpdate { get; set; }

        /// <summary>
        /// <para>The back-to-origin convergence switch.</para>
        /// <list type="bullet">
        /// <item><description><para>on: enabled.</para>
        /// </description></item>
        /// <item><description><para>off: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginConverge")]
        [Validation(Required=false)]
        public string OriginConverge { get; set; }

        /// <summary>
        /// <para>The origin protection switch.</para>
        /// <list type="bullet">
        /// <item><description><para>on: enabled.</para>
        /// </description></item>
        /// <item><description><para>off: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginProtection")]
        [Validation(Required=false)]
        public string OriginProtection { get; set; }

        /// <summary>
        /// <para>The regional back-to-origin IP address whitelist that the site currently uses.</para>
        /// </summary>
        [NameInMap("RegionalCurrentIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyRegionalCurrentIPWhitelist RegionalCurrentIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyRegionalCurrentIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR blocks and regions in the regional back-to-origin IP address whitelist that the site currently uses.</para>
            /// </summary>
            [NameInMap("RegionalIPv4")]
            [Validation(Required=false)]
            public List<GetOriginProtectionResponseBodyRegionalCurrentIPWhitelistRegionalIPv4> RegionalIPv4 { get; set; }
            public class GetOriginProtectionResponseBodyRegionalCurrentIPWhitelistRegionalIPv4 : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101.66.250.0/25</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The IPv4 region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chinese_mainland</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The IPv6 CIDR blocks and regions in the regional back-to-origin IP address whitelist that the site currently uses.</para>
            /// </summary>
            [NameInMap("RegionalIPv6")]
            [Validation(Required=false)]
            public List<GetOriginProtectionResponseBodyRegionalCurrentIPWhitelistRegionalIPv6> RegionalIPv6 { get; set; }
            public class GetOriginProtectionResponseBodyRegionalCurrentIPWhitelistRegionalIPv6 : TeaModel {
                /// <summary>
                /// <para>The IPv6 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101.66.250.0/25</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The IPv6 region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chinese_mainland</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The IP address whitelist for back-to-origin requests, differentiated by region.</para>
        /// </summary>
        [NameInMap("RegionalDiffIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyRegionalDiffIPWhitelist RegionalDiffIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The added regional back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("AddedIPRegionWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelist AddedIPRegionWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv4")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelistRegionalIPv4> RegionalIPv4 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelistRegionalIPv4 : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv4 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                /// <summary>
                /// <para>The IPv6 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv6")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelistRegionalIPv6> RegionalIPv6 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistAddedIPRegionWhitelistRegionalIPv6 : TeaModel {
                    /// <summary>
                    /// <para>The IPv6 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv6 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

            }

            /// <summary>
            /// <para>The unchanged regional back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("NoChangeIpWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelist NoChangeIpWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv4")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelistRegionalIPv4> RegionalIPv4 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelistRegionalIPv4 : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv4 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                /// <summary>
                /// <para>The IPv6 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv6")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelistRegionalIPv6> RegionalIPv6 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistNoChangeIpWhitelistRegionalIPv6 : TeaModel {
                    /// <summary>
                    /// <para>The IPv6 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv6 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

            }

            /// <summary>
            /// <para>The removed regional back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("RemovedIPRegionWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelist RemovedIPRegionWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelist : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv4")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelistRegionalIPv4> RegionalIPv4 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelistRegionalIPv4 : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv4 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                /// <summary>
                /// <para>The IPv6 CIDR blocks and regions in the regional back-to-origin IP address whitelist.</para>
                /// </summary>
                [NameInMap("RegionalIPv6")]
                [Validation(Required=false)]
                public List<GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelistRegionalIPv6> RegionalIPv6 { get; set; }
                public class GetOriginProtectionResponseBodyRegionalDiffIPWhitelistRemovedIPRegionWhitelistRegionalIPv6 : TeaModel {
                    /// <summary>
                    /// <para>The IPv6 CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.250.0/25</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The IPv6 region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinese_mainland</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The latest regional back-to-origin IP address whitelist.</para>
        /// </summary>
        [NameInMap("RegionalLatestIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyRegionalLatestIPWhitelist RegionalLatestIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyRegionalLatestIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR blocks and regions in the latest regional back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("RegionalIPv4")]
            [Validation(Required=false)]
            public List<GetOriginProtectionResponseBodyRegionalLatestIPWhitelistRegionalIPv4> RegionalIPv4 { get; set; }
            public class GetOriginProtectionResponseBodyRegionalLatestIPWhitelistRegionalIPv4 : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101.66.250.0/25</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The IPv4 region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chinese_mainland</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The IPv6 CIDR blocks and regions in the latest regional back-to-origin IP address whitelist.</para>
            /// </summary>
            [NameInMap("RegionalIPv6")]
            [Validation(Required=false)]
            public List<GetOriginProtectionResponseBodyRegionalLatestIPWhitelistRegionalIPv6> RegionalIPv6 { get; set; }
            public class GetOriginProtectionResponseBodyRegionalLatestIPWhitelistRegionalIPv6 : TeaModel {
                /// <summary>
                /// <para>The IPv6 CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101.66.250.0/25</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The IPv6 region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chinese_mainland</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
