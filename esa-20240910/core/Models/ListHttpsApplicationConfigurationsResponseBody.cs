// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpsApplicationConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpsApplicationConfigurationsResponseBodyConfigs> Configs { get; set; }
        public class ListHttpsApplicationConfigurationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>Alt-Svc feature switch. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvc")]
            [Validation(Required=false)]
            public string AltSvc { get; set; }

            /// <summary>
            /// <para>Whether the Alt-Svc header includes the clear parameter. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcClear")]
            [Validation(Required=false)]
            public string AltSvcClear { get; set; }

            /// <summary>
            /// <para>Alt-Svc validity period in seconds. Default value: 86400 seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("AltSvcMa")]
            [Validation(Required=false)]
            public string AltSvcMa { get; set; }

            /// <summary>
            /// <para>Whether the Alt-Svc header includes the persist parameter. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcPersist")]
            [Validation(Required=false)]
            public string AltSvcPersist { get; set; }

            /// <summary>
            /// <para>Configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>Configuration type. You can use this parameter to query global configurations or rule configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: Query global configurations.</description></item>
            /// <item><description>rule: Query rule configurations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Whether to enable HSTS. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Hsts")]
            [Validation(Required=false)]
            public string Hsts { get; set; }

            /// <summary>
            /// <para>Whether to include subdomains in HSTS. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsIncludeSubdomains")]
            [Validation(Required=false)]
            public string HstsIncludeSubdomains { get; set; }

            /// <summary>
            /// <para>HSTS expiration time in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public string HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Whether to enable HSTS preload. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public string HstsPreload { get; set; }

            /// <summary>
            /// <para>Whether to enable forced HTTPS. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
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
            /// <para>Forced HTTPS redirect status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>301</description></item>
            /// <item><description>302</description></item>
            /// <item><description>307</description></item>
            /// <item><description>308</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("HttpsForceCode")]
            [Validation(Required=false)]
            public string HttpsForceCode { get; set; }

            /// <summary>
            /// <para>Whether to enable denial of TLS handshake requests without SNI. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsNoSniDeny")]
            [Validation(Required=false)]
            public string HttpsNoSniDeny { get; set; }

            /// <summary>
            /// <para>Whether to enable SNI verification. Disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsSniVerify")]
            [Validation(Required=false)]
            public string HttpsSniVerify { get; set; }

            /// <summary>
            /// <para>Specifies the list of allowed SNI whitelist entries, separated by spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc edf</para>
            /// </summary>
            [NameInMap("HttpsSniWhitelist")]
            [Validation(Required=false)]
            public string HttpsSniWhitelist { get; set; }

            /// <summary>
            /// <para>Rule content, using conditional expressions to match user requests. This parameter does not need to be set when adding a global configuration. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specified requests: Set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch. This parameter does not need to be set when adding a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>Rule name. This parameter does not need to be set when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Rule execution order. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: version 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>Current page number, same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
