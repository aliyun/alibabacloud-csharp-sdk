// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpsApplicationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the <c>Alt-Svc</c> header. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the Alt-Svc header.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the Alt-Svc header.</para>
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
        /// <para>Specifies whether to include the <c>clear</c> directive in the <c>Alt-Svc</c> header. The directive is not included by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Includes the directive.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include the directive.</para>
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
        /// <para>The max-age for the Alt-Svc header, in seconds. The default is 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("AltSvcMa")]
        [Validation(Required=false)]
        public string AltSvcMa { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the <c>persist</c> directive in the <c>Alt-Svc</c> header. The directive is not included by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Includes the directive.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include the directive.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTP Strict Transport Security (HSTS). This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables HSTS.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables HSTS.</para>
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
        /// <para>Specifies whether to include subdomains in the HSTS policy. Subdomains are not included by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Includes subdomains.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not include subdomains.</para>
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
        /// <para>The HSTS max-age in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("HstsMaxAge")]
        [Validation(Required=false)]
        public string HstsMaxAge { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HSTS Preload. HSTS Preload is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables Preload.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables Preload.</para>
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
        /// <para>Specifies whether to enable Force HTTPS. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables Force HTTPS.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables Force HTTPS.</para>
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
        /// <para>The redirect status code for Force HTTPS. Valid values:</para>
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
        /// <para>Specifies whether to deny TLS handshake requests that do not include an SNI. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Denies requests without an SNI.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Allows requests without an SNI.</para>
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
        /// <para>Specifies whether to enable Server Name Indication (SNI) verification. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables SNI verification.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables SNI verification.</para>
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
        /// <para>The SNI allowlist. Separate multiple hostnames with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc edf</para>
        /// </summary>
        [NameInMap("HttpsSniWhitelist")]
        [Validation(Required=false)]
        public string HttpsSniWhitelist { get; set; }

        /// <summary>
        /// <para>The conditional expression that the rule uses to match requests. This parameter is not required for a global configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, provide a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c></para>
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
        /// <para>Specifies whether to enable the rule. This parameter is not required for a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the rule.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the rule.</para>
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
        /// <para>The rule name. This parameter is not required for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution order of the rule. A lower value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. To obtain this ID, call the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
