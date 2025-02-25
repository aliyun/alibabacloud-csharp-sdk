// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Configuration type, which can be used to query global or rule configurations. Value range:</para>
        /// <list type="bullet">
        /// <item><description>global: Query global configuration.</description></item>
        /// <item><description>rule: Query rule configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>Rewrite the DNS resolution record for the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("DnsRecord")]
        [Validation(Required=false)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// <para>HOST carried in the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <para>Source site port accessed when using the HTTP protocol for origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("OriginHttpPort")]
        [Validation(Required=false)]
        public string OriginHttpPort { get; set; }

        /// <summary>
        /// <para>Source site port accessed when using the HTTPS protocol for origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4433</para>
        /// </summary>
        [NameInMap("OriginHttpsPort")]
        [Validation(Required=false)]
        public string OriginHttpsPort { get; set; }

        /// <summary>
        /// <para>Protocol used for the origin request. Value range:</para>
        /// <list type="bullet">
        /// <item><description>http: Use HTTP protocol for origin.</description></item>
        /// <item><description>https: Use HTTPS protocol for origin.</description></item>
        /// <item><description>follow: Follow client protocol for origin.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("OriginScheme")]
        [Validation(Required=false)]
        public string OriginScheme { get; set; }

        /// <summary>
        /// <para>SNI carried in the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginSni")]
        [Validation(Required=false)]
        public string OriginSni { get; set; }

        /// <summary>
        /// <para>Use range chunking method for origin download. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// <item><description>force: Force.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>Rule switch. Value range:</para>
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
        /// <para>Rule execution sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Site version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
