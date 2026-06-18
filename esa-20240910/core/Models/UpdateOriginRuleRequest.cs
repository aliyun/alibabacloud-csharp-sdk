// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginRuleRequest : TeaModel {
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
        /// <para>Overrides the DNS record for the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("DnsRecord")]
        [Validation(Required=false)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// <para>Indicates whether to follow 302 redirects for origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Follows 302 redirects.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not follow 302 redirects.</para>
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
        /// <para>The maximum number of 302 redirects to follow. The value must be an integer from 1 to 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Follow302MaxTries")]
        [Validation(Required=false)]
        public string Follow302MaxTries { get; set; }

        /// <summary>
        /// <para>Indicates whether to retain the original request parameters when following a 302 redirect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Retains the parameters.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not retain the parameters.</para>
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
        /// <para>Indicates whether to retain the original request headers when following a 302 redirect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Retains the headers.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not retain the headers.</para>
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
        /// <para>The <c>Host</c> header for the redirected origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("Follow302TargetHost")]
        [Validation(Required=false)]
        public string Follow302TargetHost { get; set; }

        /// <summary>
        /// <para>The <c>Host</c> header for the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <para>The origin server port for HTTP requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("OriginHttpPort")]
        [Validation(Required=false)]
        public string OriginHttpPort { get; set; }

        /// <summary>
        /// <para>The origin server port for HTTPS requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4433</para>
        /// </summary>
        [NameInMap("OriginHttpsPort")]
        [Validation(Required=false)]
        public string OriginHttpsPort { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable mutual TLS (mTLS) for origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables mTLS.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables mTLS.</para>
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
        /// <para>The read timeout period for the origin server, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OriginReadTimeout")]
        [Validation(Required=false)]
        public string OriginReadTimeout { get; set; }

        /// <summary>
        /// <para>The protocol for origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>http</c>: The origin request uses HTTP.</para>
        /// </description></item>
        /// <item><description><para><c>https</c>: The origin request uses HTTPS.</para>
        /// </description></item>
        /// <item><description><para><c>follow</c>: The origin request uses the same protocol as the client request.</para>
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
        /// <para>The Server Name Indication (SNI) for the origin request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginSni")]
        [Validation(Required=false)]
        public string OriginSni { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable origin certificate verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables verification.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables verification.</para>
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
        /// <para>Indicates whether to use range requests when fetching files from the origin server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables range requests.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables range requests.</para>
        /// </description></item>
        /// <item><description><para><c>force</c>: Enforces range requests.</para>
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
        /// <para>The size of each chunk for range requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>512KB</para>
        /// </description></item>
        /// <item><description><para>1MB</para>
        /// </description></item>
        /// <item><description><para>2MB</para>
        /// </description></item>
        /// <item><description><para>4MB</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1MB</para>
        /// </summary>
        [NameInMap("RangeChunkSize")]
        [Validation(Required=false)]
        public string RangeChunkSize { get; set; }

        /// <summary>
        /// <para>The rule content, which is a conditional expression that matches user requests. This parameter is not required when you add a global configuration.</para>
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
        /// <para>Indicates whether the rule is enabled. This parameter is not required when you add a global configuration. Valid values:</para>
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
        /// <para>The rule name. This parameter is not required when you add a global configuration.</para>
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
        /// <para>The site ID. You can get this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
