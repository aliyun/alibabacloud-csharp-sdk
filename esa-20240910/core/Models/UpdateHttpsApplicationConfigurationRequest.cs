// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpsApplicationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Feature switch, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AltSvc")]
        [Validation(Required=false)]
        public string AltSvc { get; set; }

        /// <summary>
        /// <para>Whether the Alt-Svc header includes the clear parameter, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AltSvcClear")]
        [Validation(Required=false)]
        public string AltSvcClear { get; set; }

        /// <summary>
        /// <para>Alt-Svc validity period in seconds, default is 86400 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("AltSvcMa")]
        [Validation(Required=false)]
        public string AltSvcMa { get; set; }

        /// <summary>
        /// <para>Whether the Alt-Svc header includes the persist parameter, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Whether to enable HSTS, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Hsts")]
        [Validation(Required=false)]
        public string Hsts { get; set; }

        /// <summary>
        /// <para>Whether to include subdomains in HSTS, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
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
        /// <para>Whether to enable HSTS preload, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HstsPreload")]
        [Validation(Required=false)]
        public string HstsPreload { get; set; }

        /// <summary>
        /// <para>Whether to enable forced HTTPS, default is disabled. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HttpsForce")]
        [Validation(Required=false)]
        public string HttpsForce { get; set; }

        /// <summary>
        /// <para>Forced HTTPS redirect status code. Values:</para>
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
        /// <para>Rule content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Rule switch. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>Rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
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
