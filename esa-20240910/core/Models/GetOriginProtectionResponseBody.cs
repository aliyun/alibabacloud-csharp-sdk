// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP whitelist for origin protection used by the website.</para>
        /// </summary>
        [NameInMap("CurrentIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyCurrentIPWhitelist CurrentIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyCurrentIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The IP whitelist for origin protection used by the website, specified as IPv4 addresses or CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            /// <summary>
            /// <para>The IP whitelist for origin protection used by the website, specified as IPv6 addresses or CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

        /// <summary>
        /// <para>The IP whitelist for origin protection that has been updated.</para>
        /// </summary>
        [NameInMap("DiffIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyDiffIPWhitelist DiffIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyDiffIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The new IP whitelist for origin protection.</para>
            /// </summary>
            [NameInMap("AddedIPWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistAddedIPWhitelist AddedIPWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistAddedIPWhitelist : TeaModel {
                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv4 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv6 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

            /// <summary>
            /// <para>The IP whitelist for origin protection that remains unchanged.</para>
            /// </summary>
            [NameInMap("NoChangeIpWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistNoChangeIpWhitelist NoChangeIpWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistNoChangeIpWhitelist : TeaModel {
                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv4 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv6 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

            /// <summary>
            /// <para>The IP whitelist for origin protection that has been deleted.</para>
            /// </summary>
            [NameInMap("RemovedIPWhitelist")]
            [Validation(Required=false)]
            public GetOriginProtectionResponseBodyDiffIPWhitelistRemovedIPWhitelist RemovedIPWhitelist { get; set; }
            public class GetOriginProtectionResponseBodyDiffIPWhitelistRemovedIPWhitelist : TeaModel {
                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv4 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv4")]
                [Validation(Required=false)]
                public List<string> IPv4 { get; set; }

                /// <summary>
                /// <para>The IP whitelist for origin protection, specified as IPv6 addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("IPv6")]
                [Validation(Required=false)]
                public List<string> IPv6 { get; set; }

            }

        }

        /// <summary>
        /// <para>The latest IP whitelist for origin protection.</para>
        /// </summary>
        [NameInMap("LatestIPWhitelist")]
        [Validation(Required=false)]
        public GetOriginProtectionResponseBodyLatestIPWhitelist LatestIPWhitelist { get; set; }
        public class GetOriginProtectionResponseBodyLatestIPWhitelist : TeaModel {
            /// <summary>
            /// <para>The latest IP whitelist for origin protection, specified as IPv4 addresses or CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv4")]
            [Validation(Required=false)]
            public List<string> IPv4 { get; set; }

            /// <summary>
            /// <para>The latest IP whitelist for origin protection, specified as IPv6 addresses or CIDR blocks.</para>
            /// </summary>
            [NameInMap("IPv6")]
            [Validation(Required=false)]
            public List<string> IPv6 { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the IP whitelist for origin protection needs to be updated. If the currently used IP whitelist is different from the latest IP whitelist, it needs to be updated, and the value is true.</para>
        /// <list type="bullet">
        /// <item><description>true: The update is required.</description></item>
        /// <item><description>false: No update is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedUpdate")]
        [Validation(Required=false)]
        public bool? NeedUpdate { get; set; }

        /// <summary>
        /// <para>Indicates whether IP convergence is enabled.</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginConverge")]
        [Validation(Required=false)]
        public string OriginConverge { get; set; }

        /// <summary>
        /// <para>Indicates whether origin protection is enabled.</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginProtection")]
        [Validation(Required=false)]
        public string OriginProtection { get; set; }

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
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
