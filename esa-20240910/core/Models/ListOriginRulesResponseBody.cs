// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListOriginRulesResponseBodyConfigs> Configs { get; set; }
        public class ListOriginRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The configuration type. You can use this parameter to query for global or rule-specific configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: The global configuration.</para>
            /// </description></item>
            /// <item><description><para><c>rule</c>: A rule-specific configuration.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Overrides the DNS record for the origin request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("DnsRecord")]
            [Validation(Required=false)]
            public string DnsRecord { get; set; }

            /// <summary>
            /// <para>Specifies whether to follow 302 redirects from the origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302Enable")]
            [Validation(Required=false)]
            public string Follow302Enable { get; set; }

            /// <summary>
            /// <para>The maximum number of 302 redirects to follow. Valid range: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Follow302MaxTries")]
            [Validation(Required=false)]
            public string Follow302MaxTries { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain the original request parameters when following a redirect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302RetainArgs")]
            [Validation(Required=false)]
            public string Follow302RetainArgs { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain the original request header when following a redirect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302RetainHeader")]
            [Validation(Required=false)]
            public string Follow302RetainHeader { get; set; }

            /// <summary>
            /// <para>The host to use for the origin request after following a 302 redirect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Follow302TargetHost")]
            [Validation(Required=false)]
            public string Follow302TargetHost { get; set; }

            /// <summary>
            /// <para>The <c>Host</c> header carried in the origin request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("OriginHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            /// <summary>
            /// <para>The origin server port used for origin requests over HTTP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("OriginHttpPort")]
            [Validation(Required=false)]
            public string OriginHttpPort { get; set; }

            /// <summary>
            /// <para>The origin server port used for origin requests over HTTPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4433</para>
            /// </summary>
            [NameInMap("OriginHttpsPort")]
            [Validation(Required=false)]
            public string OriginHttpsPort { get; set; }

            /// <summary>
            /// <para>Specifies whether mTLS is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OriginMtls")]
            [Validation(Required=false)]
            public string OriginMtls { get; set; }

            /// <summary>
            /// <para>The read timeout, in seconds, for the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OriginReadTimeout")]
            [Validation(Required=false)]
            public string OriginReadTimeout { get; set; }

            /// <summary>
            /// <para>The protocol used for origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>http</c>: Use the HTTP protocol for origin requests.</para>
            /// </description></item>
            /// <item><description><para><c>https</c>: Use the HTTPS protocol for origin requests.</para>
            /// </description></item>
            /// <item><description><para><c>follow</c>: Use the same protocol as the client request.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("OriginScheme")]
            [Validation(Required=false)]
            public string OriginScheme { get; set; }

            /// <summary>
            /// <para>The SNI carried in the origin request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("OriginSni")]
            [Validation(Required=false)]
            public string OriginSni { get; set; }

            /// <summary>
            /// <para>Specifies whether to verify the origin server certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OriginVerify")]
            [Validation(Required=false)]
            public string OriginVerify { get; set; }

            /// <summary>
            /// <para>Specifies whether to use range-based requests to retrieve files from the origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enables range requests.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disables range requests.</para>
            /// </description></item>
            /// <item><description><para><c>force</c>: Forces range requests.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            /// <summary>
            /// <para>The size of each chunk for range requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1MB</para>
            /// </summary>
            [NameInMap("RangeChunkSize")]
            [Validation(Required=false)]
            public string RangeChunkSize { get; set; }

            /// <summary>
            /// <para>The rule content, which uses a conditional expression to match user requests. This parameter is not required for global configurations. It supports two use cases:</para>
            /// <list type="bullet">
            /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule is enabled. This parameter is not required for global configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name. This parameter is not required for global configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule execution order. Lower values indicate higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The site configuration version. If versioning is enabled for the site, this parameter specifies which version to use. The default is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
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
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
