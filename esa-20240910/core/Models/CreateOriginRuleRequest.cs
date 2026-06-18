// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateOriginRuleRequest : TeaModel {
        /// <summary>
        /// <para>Overrides the DNS Record for Origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("DnsRecord")]
        [Validation(Required=false)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// <para>Specifies whether to follow 302 redirects from the Origin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables following redirects.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables following redirects.</para>
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
        /// <para>Specifies whether to retain the original request parameters when following a 302 redirect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Retains the request parameters.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not retain the request parameters.</para>
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
        /// <para>Specifies whether to retain the original request header when following a 302 redirect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Retains the request header.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not retain the request header.</para>
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
        /// <para>The Origin <c>Host</c> header to use after a 302 redirect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("Follow302TargetHost")]
        [Validation(Required=false)]
        public string Follow302TargetHost { get; set; }

        /// <summary>
        /// <para>The <c>Host</c> header to use in Origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <para>The Origin Port to use for HTTP Origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("OriginHttpPort")]
        [Validation(Required=false)]
        public string OriginHttpPort { get; set; }

        /// <summary>
        /// <para>The Origin Port to use for HTTPS Origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4433</para>
        /// </summary>
        [NameInMap("OriginHttpsPort")]
        [Validation(Required=false)]
        public string OriginHttpsPort { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable mutual Transport Layer Security (mTLS) for Origin connections. Valid values:</para>
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
        /// <para>The Origin read timeout in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OriginReadTimeout")]
        [Validation(Required=false)]
        public string OriginReadTimeout { get; set; }

        /// <summary>
        /// <para>The protocol for Origin requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>http</c>: Uses the HTTP protocol.</para>
        /// </description></item>
        /// <item><description><para><c>https</c>: Uses the HTTPS protocol.</para>
        /// </description></item>
        /// <item><description><para><c>follow</c>: Uses the same protocol as the client request.</para>
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
        /// <para>The Server Name Indication (SNI) to use in Origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginSni")]
        [Validation(Required=false)]
        public string OriginSni { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Origin Certificate Verification. Valid values:</para>
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
        /// <para>Specifies whether to use range requests to download files from the Origin. Valid values:</para>
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
        /// <para>The size of each chunk for range requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>512KB</c></para>
        /// </description></item>
        /// <item><description><para><c>1MB</c></para>
        /// </description></item>
        /// <item><description><para><c>2MB</c></para>
        /// </description></item>
        /// <item><description><para><c>4MB</c></para>
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
        /// <para>The content of the rule, a Conditional Expression that matches user requests. Not required when creating a Global Configuration. There are two scenarios:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression. Example: <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether to enable the rule. Not required when creating a Global Configuration. Valid values:</para>
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
        /// <para>The rule name. Not required when creating a Global Configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The priority of the rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340035003106221</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>For sites with version management enabled, this specifies the version to which the configuration applies. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
