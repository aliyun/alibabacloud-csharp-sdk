// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpsApplicationConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of HTTPS application configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpsApplicationConfigurationsResponseBodyConfigs> Configs { get; set; }
        public class ListHttpsApplicationConfigurationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>Whether to enable the Alt-Svc feature. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The Alt-Svc feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The Alt-Svc feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvc")]
            [Validation(Required=false)]
            public string AltSvc { get; set; }

            /// <summary>
            /// <para>Whether the Alt-Svc header includes the <c>clear</c> parameter. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The <c>clear</c> parameter is included.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The <c>clear</c> parameter is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcClear")]
            [Validation(Required=false)]
            public string AltSvcClear { get; set; }

            /// <summary>
            /// <para>The Alt-Svc max-age in seconds. Default: <c>86400</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("AltSvcMa")]
            [Validation(Required=false)]
            public string AltSvcMa { get; set; }

            /// <summary>
            /// <para>Whether the Alt-Svc header includes the <c>persist</c> parameter. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The <c>persist</c> parameter is included.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The <c>persist</c> parameter is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcPersist")]
            [Validation(Required=false)]
            public string AltSvcPersist { get; set; }

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
            /// <para>The type of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: A global configuration.</para>
            /// </description></item>
            /// <item><description><para><c>rule</c>: A rule-based configuration.</para>
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
            /// <para>Whether to enable HSTS. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: HSTS is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: HSTS is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Hsts")]
            [Validation(Required=false)]
            public string Hsts { get; set; }

            /// <summary>
            /// <para>Whether the HSTS header includes the <c>includeSubDomains</c> directive. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The <c>includeSubDomains</c> directive is included.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The <c>includeSubDomains</c> directive is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsIncludeSubdomains")]
            [Validation(Required=false)]
            public string HstsIncludeSubdomains { get; set; }

            /// <summary>
            /// <para>The HSTS <c>max-age</c>, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public string HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Whether the HSTS header includes the <c>preload</c> directive. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The <c>preload</c> directive is included.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The <c>preload</c> directive is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public string HstsPreload { get; set; }

            /// <summary>
            /// <para>Whether to enable HTTPS redirection. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: HTTPS redirection is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: HTTPS redirection is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsForce")]
            [Validation(Required=false)]
            public string HttpsForce { get; set; }

            /// <summary>
            /// <para>The status code for HTTPS redirection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>301</c></para>
            /// </description></item>
            /// <item><description><para><c>302</c></para>
            /// </description></item>
            /// <item><description><para><c>307</c></para>
            /// </description></item>
            /// <item><description><para><c>308</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("HttpsForceCode")]
            [Validation(Required=false)]
            public string HttpsForceCode { get; set; }

            /// <summary>
            /// <para>Whether to reject TLS handshake requests that lack an SNI. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Requests that lack an SNI are rejected.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Requests that lack an SNI are not rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsNoSniDeny")]
            [Validation(Required=false)]
            public string HttpsNoSniDeny { get; set; }

            /// <summary>
            /// <para>Whether to enable SNI verification. Default: <c>off</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: SNI verification is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: SNI verification is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsSniVerify")]
            [Validation(Required=false)]
            public string HttpsSniVerify { get; set; }

            /// <summary>
            /// <para>The SNI allowlist. Separate multiple values with a space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc edf</para>
            /// </summary>
            [NameInMap("HttpsSniWhitelist")]
            [Validation(Required=false)]
            public string HttpsSniWhitelist { get; set; }

            /// <summary>
            /// <para>The content of the rule, a conditional expression that matches user requests. This parameter is not required for a global configuration. The following use cases are supported:</para>
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
            /// <para>Whether the rule is enabled. This parameter is not required for a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: The rule is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: The rule is disabled.</para>
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
            /// <para>The name of the rule. This parameter is not required for a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution priority of the rule. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The site configuration version. For sites with version management, this specifies the version to which the configuration applies. Default: <c>0</c>.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
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
