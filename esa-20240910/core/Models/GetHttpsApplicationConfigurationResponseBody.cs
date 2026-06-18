// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetHttpsApplicationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Alt-Svc feature, which is disabled by default. Valid values:</para>
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
        /// <para>Specifies whether to include the <c>clear</c> parameter in the Alt-Svc header, which is disabled by default. Valid values:</para>
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
        [NameInMap("AltSvcClear")]
        [Validation(Required=false)]
        public string AltSvcClear { get; set; }

        /// <summary>
        /// <para>The Alt-Svc max-age, in seconds. Default: <c>86400</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("AltSvcMa")]
        [Validation(Required=false)]
        public string AltSvcMa { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the <c>persist</c> parameter in the Alt-Svc header, which is disabled by default. Valid values:</para>
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
        [NameInMap("AltSvcPersist")]
        [Validation(Required=false)]
        public string AltSvcPersist { get; set; }

        /// <summary>
        /// <para>The configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The configuration type. You can query for a global or rule configuration based on this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>global</c>: a global configuration.</para>
        /// </description></item>
        /// <item><description><para><c>rule</c>: a rule configuration.</para>
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
        /// <para>Specifies whether to enable HSTS, which is disabled by default. Valid values:</para>
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
        /// <para>Specifies whether to include subdomains in the HSTS policy, which is disabled by default. Valid values:</para>
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
        [NameInMap("HstsIncludeSubdomains")]
        [Validation(Required=false)]
        public string HstsIncludeSubdomains { get; set; }

        /// <summary>
        /// <para>The value of the <c>max-age</c> directive for HSTS, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("HstsMaxAge")]
        [Validation(Required=false)]
        public string HstsMaxAge { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HSTS preload, which is disabled by default. Valid values:</para>
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
        [NameInMap("HstsPreload")]
        [Validation(Required=false)]
        public string HstsPreload { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable force HTTPS, which is disabled by default. Valid values:</para>
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
        /// <para>The status code for the force HTTPS redirect. Valid values:</para>
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
        /// <para>Specifies whether to deny TLS handshakes that lack an SNI, which is disabled by default. Valid values:</para>
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
        [NameInMap("HttpsNoSniDeny")]
        [Validation(Required=false)]
        public string HttpsNoSniDeny { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SNI verification, which is disabled by default. Valid values:</para>
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
        /// <para>The SNI allowlist. Separate multiple values with a space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc edf</para>
        /// </summary>
        [NameInMap("HttpsSniWhitelist")]
        [Validation(Required=false)]
        public string HttpsSniWhitelist { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3790430-3A06-535F-A424-0998BD9A6C9F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The conditional expression used to match user requests. This parameter is not required for a global configuration. There are two scenarios:</para>
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
        /// <para>Specifies whether to enable the rule. This parameter is not required for a global configuration. Valid values:</para>
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
        /// <para>The rule name. This parameter is not required for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with configuration versioning enabled, this parameter specifies the applicable site version. The default is version <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
