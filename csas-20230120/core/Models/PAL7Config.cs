// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7Config : TeaModel {
        /// <summary>
        /// <para>The configuration for anonymous access.</para>
        /// </summary>
        [NameInMap("BypassConfig")]
        [Validation(Required=false)]
        public PAL7ConfigBypassConfig BypassConfig { get; set; }
        public class PAL7ConfigBypassConfig : TeaModel {
            /// <summary>
            /// <para>An array of source IP address ranges that are allowed to anonymously access the application.</para>
            /// </summary>
            [NameInMap("AppBypassFroms")]
            [Validation(Required=false)]
            public List<string> AppBypassFroms { get; set; }

            /// <summary>
            /// <para>The anonymous access mode. The default value is <b>disabled</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disabled</b>: Disables anonymous access.</para>
            /// </description></item>
            /// <item><description><para><b>url</b>: Sets anonymous access at the URL level.</para>
            /// </description></item>
            /// <item><description><para><b>app</b>: Sets anonymous access at the application level.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>An array of rules for anonymous access to URLs.</para>
            /// </summary>
            [NameInMap("UrlBypassRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigBypassConfigUrlBypassRules> UrlBypassRules { get; set; }
            public class PAL7ConfigBypassConfigUrlBypassRules : TeaModel {
                /// <summary>
                /// <para>An array of source IP address ranges that are allowed to anonymously access the application paths.</para>
                /// </summary>
                [NameInMap("Froms")]
                [Validation(Required=false)]
                public List<string> Froms { get; set; }

                /// <summary>
                /// <para>The URL paths that allow anonymous access.</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

            }

        }

        /// <summary>
        /// <para>The certificate ID. This parameter is required when you use a custom proxy domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-xxxx</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The DNS configuration.</para>
        /// </summary>
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public PAL7ConfigDnsConfig DnsConfig { get; set; }
        public class PAL7ConfigDnsConfig : TeaModel {
            /// <summary>
            /// <para>An array of DNS server addresses. The gateway preferentially uses the DNS servers configured here to resolve internal domain names.</para>
            /// </summary>
            [NameInMap("DnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

        }

        /// <summary>
        /// <para>The configuration for rewriting internal network requests in JavaScript.</para>
        /// </summary>
        [NameInMap("JsHookConfig")]
        [Validation(Required=false)]
        public PAL7ConfigJsHookConfig JsHookConfig { get; set; }
        public class PAL7ConfigJsHookConfig : TeaModel {
            /// <summary>
            /// <para>The mode for rewriting internal network requests in JavaScript. The default value is <b>disabled</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disabled</b>: Disables traffic redirection for JavaScript.</para>
            /// </description></item>
            /// <item><description><para><b>whitelist</b>: Enables the whitelist mode to redirect traffic as needed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>An array of rules for rewriting internal network requests in JavaScript.</para>
            /// </summary>
            [NameInMap("ReplaceRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigReplaceRule> ReplaceRules { get; set; }

        }

        /// <summary>
        /// <para>The type of the proxy domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>automatic</b>: Uses a mapped proxy domain name.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: Uses a custom proxy domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>automatic</para>
        /// </summary>
        [NameInMap("ProxyDomainTypes")]
        [Validation(Required=false)]
        public byte[] ProxyDomainTypes { get; set; }

        /// <summary>
        /// <para>The rules for rewriting HTTP request headers.</para>
        /// </summary>
        [NameInMap("RequestHeaderRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigRequestHeaderRewriteConfig RequestHeaderRewriteConfig { get; set; }
        public class PAL7ConfigRequestHeaderRewriteConfig : TeaModel {
            /// <summary>
            /// <para>An array of rewrite operations.</para>
            /// </summary>
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        /// <summary>
        /// <para>The configuration for rewriting HTTP request query parameters.</para>
        /// </summary>
        [NameInMap("RequestQueryRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigRequestQueryRewriteConfig RequestQueryRewriteConfig { get; set; }
        public class PAL7ConfigRequestQueryRewriteConfig : TeaModel {
            /// <summary>
            /// <para>An array of rewrite operations.</para>
            /// </summary>
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        /// <summary>
        /// <para>The configuration for rewriting HTTP response headers.</para>
        /// </summary>
        [NameInMap("ResponseHeaderRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigResponseHeaderRewriteConfig ResponseHeaderRewriteConfig { get; set; }
        public class PAL7ConfigResponseHeaderRewriteConfig : TeaModel {
            /// <summary>
            /// <para>An array of rewrite operations.</para>
            /// </summary>
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        /// <summary>
        /// <para>The configuration for rewriting internal domain names in HTML.</para>
        /// </summary>
        [NameInMap("ResponseRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigResponseRewriteConfig ResponseRewriteConfig { get; set; }
        public class PAL7ConfigResponseRewriteConfig : TeaModel {
            /// <summary>
            /// <para>The rewrite mode. The default value is <b>auto</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disabled</b>: Disables rewriting of internal domain names in HTML.</para>
            /// </description></item>
            /// <item><description><para><b>auto</b>: Enables the automatic mode. The system automatically detects and rewrites internal domain names in HTML.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>An array of rewrite rules.</para>
            /// </summary>
            [NameInMap("ReplaceRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigReplaceRule> ReplaceRules { get; set; }

        }

    }

}
