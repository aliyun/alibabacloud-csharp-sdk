// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpsApplicationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Alt-Svc header. Disabled by default. Valid values:</para>
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
        [NameInMap("AltSvc")]
        [Validation(Required=false)]
        public string AltSvc { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the <c>clear</c> parameter in the Alt-Svc header. Disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The parameter is included.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The parameter is not included.</para>
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
        /// <para>The Max Age for the Alt-Svc header, in seconds. The default is 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("AltSvcMa")]
        [Validation(Required=false)]
        public string AltSvcMa { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the <c>persist</c> parameter in the Alt-Svc header. Disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The parameter is included.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The parameter is not included.</para>
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
        /// <para>Specifies whether to enable HTTP Strict Transport Security (HSTS). Disabled by default. Valid values:</para>
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
        [NameInMap("Hsts")]
        [Validation(Required=false)]
        public string Hsts { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the <c>includeSubDomains</c> directive in the HSTS header. Disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The directive is included.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The directive is not included.</para>
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
        /// <para>The value of the <c>max-age</c> directive for the HSTS header, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("HstsMaxAge")]
        [Validation(Required=false)]
        public string HstsMaxAge { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HSTS Preload by including the <c>preload</c> directive in the HSTS header. Disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The directive is included.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The directive is not included.</para>
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
        /// <para>Specifies whether to enable Force HTTPS. Disabled by default. Valid values:</para>
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
        [NameInMap("HttpsForce")]
        [Validation(Required=false)]
        public string HttpsForce { get; set; }

        /// <summary>
        /// <para>The Redirection Status Code to use when Force HTTPS is enabled. Valid values:</para>
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
        /// <para>Specifies whether to reject TLS Handshake Requests that do not include an SNI. Disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Rejects requests without an SNI.</para>
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
        /// <para>Specifies whether to enable Server Name Indication (SNI) verification. Disabled by default. Valid values:</para>
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
        [NameInMap("HttpsSniVerify")]
        [Validation(Required=false)]
        public string HttpsSniVerify { get; set; }

        /// <summary>
        /// <para>Specifies the allowlist of SNI values. Separate multiple values with a space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc edf</para>
        /// </summary>
        [NameInMap("HttpsSniWhitelist")]
        [Validation(Required=false)]
        public string HttpsSniWhitelist { get; set; }

        /// <summary>
        /// <para>The content of the Rule, which is a Conditional Expression that matches user Requests. This parameter is optional when adding a Global Configuration. Supported use cases include:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, use a custom expression. For example: <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether to enable the rule. This parameter is optional when adding a Global Configuration. Valid values:</para>
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
        /// <para>The name of the Rule. This parameter is optional when adding a Global Configuration.</para>
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
        /// <para>The ID of the Site. You can get this ID by calling the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The Site\&quot;s configuration Version. For Sites with version management enabled, this parameter specifies the Version to which the configuration applies. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
