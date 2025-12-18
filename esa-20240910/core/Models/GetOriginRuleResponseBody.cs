// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginRuleResponseBody : TeaModel {
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
        /// <para>The configuration type to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: global configurations.</description></item>
        /// <item><description>rule: rule configurations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The hostname that overrides the resolved hostname of an incoming request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("DnsRecord")]
        [Validation(Required=false)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// <para>302 follow switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Follow302Enable")]
        [Validation(Required=false)]
        public string Follow302Enable { get; set; }

        /// <summary>
        /// <para>The maximum number of 302 follow times. Valid values: 1 to 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Follow302MaxTries")]
        [Validation(Required=false)]
        public string Follow302MaxTries { get; set; }

        /// <summary>
        /// <para>Retains the original request parameters switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Follow302RetainArgs")]
        [Validation(Required=false)]
        public string Follow302RetainArgs { get; set; }

        /// <summary>
        /// <para>Retain the original request header switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Follow302RetainHeader")]
        [Validation(Required=false)]
        public string Follow302RetainHeader { get; set; }

        /// <summary>
        /// <para>Target Host</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("Follow302TargetHost")]
        [Validation(Required=false)]
        public string Follow302TargetHost { get; set; }

        /// <summary>
        /// <para>The Host header in origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <para>The origin port that is accessed when the HTTP protocol is used to back to the origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("OriginHttpPort")]
        [Validation(Required=false)]
        public string OriginHttpPort { get; set; }

        /// <summary>
        /// <para>The origin port that is accessed when the HTTPS protocol is used to back to the origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4433</para>
        /// </summary>
        [NameInMap("OriginHttpsPort")]
        [Validation(Required=false)]
        public string OriginHttpsPort { get; set; }

        /// <summary>
        /// <para>The MTLS switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginMtls")]
        [Validation(Required=false)]
        public string OriginMtls { get; set; }

        /// <summary>
        /// <para>The read timeout period (in seconds) on the origin.</para>
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
        /// <item><description>http: HTTP.</description></item>
        /// <item><description>https: HTTPS.</description></item>
        /// <item><description>follow: follows the protocol used by the client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("OriginScheme")]
        [Validation(Required=false)]
        public string OriginScheme { get; set; }

        /// <summary>
        /// <para>The SNI in origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginSni")]
        [Validation(Required=false)]
        public string OriginSni { get; set; }

        /// <summary>
        /// <para>The origin certificate verification switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OriginVerify")]
        [Validation(Required=false)]
        public string OriginVerify { get; set; }

        /// <summary>
        /// <para>Use range requests to download an object from the source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// <item><description>force: enables range origin fetch by force.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// <para>The size of the range part. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>512KB</description></item>
        /// <item><description>1MB</description></item>
        /// <item><description>2MB</description></item>
        /// <item><description>4MB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1MB</para>
        /// </summary>
        [NameInMap("RangeChunkSize")]
        [Validation(Required=false)]
        public string RangeChunkSize { get; set; }

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
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description>true: Match all incoming requests.</description></item>
        /// <item><description>Set the value to a custom expression, for example, (http.host eq &quot;video.example.com&quot;): Match the specified request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. Valid values: You do not need to set this parameter when you add global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. You do not need to set this parameter when you add global configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. The smaller the value, the higher the priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The version number of the configurations. You can use this parameter to specify a version of your website to apply the feature settings. By default, version 0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
