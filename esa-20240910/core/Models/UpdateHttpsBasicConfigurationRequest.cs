// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpsBasicConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The custom cipher suite to use when <c>CiphersuiteGroup</c> is set to <c>custom</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
        /// </summary>
        [NameInMap("Ciphersuite")]
        [Validation(Required=false)]
        public string Ciphersuite { get; set; }

        /// <summary>
        /// <para>The cipher suite group. Default value: <c>all</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>all</c>: All cipher suites.</para>
        /// </description></item>
        /// <item><description><para><c>strict</c>: strong cipher suites.</para>
        /// </description></item>
        /// <item><description><para><c>custom</c>: custom cipher suites.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("CiphersuiteGroup")]
        [Validation(Required=false)]
        public string CiphersuiteGroup { get; set; }

        /// <summary>
        /// <para>The configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTP/2 is enabled. Default value: <c>on</c>. Valid values:</para>
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
        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTP/3 is enabled. Default value: <c>on</c>. Valid values:</para>
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
        [NameInMap("Http3")]
        [Validation(Required=false)]
        public string Http3 { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTPS is enabled. Default value: <c>on</c>. Valid values:</para>
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
        [NameInMap("Https")]
        [Validation(Required=false)]
        public string Https { get; set; }

        /// <summary>
        /// <para>Indicates whether OCSP stapling is enabled. Default value: <c>off</c>. Valid values:</para>
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
        [NameInMap("OcspStapling")]
        [Validation(Required=false)]
        public string OcspStapling { get; set; }

        /// <summary>
        /// <para>The conditional expression used to match incoming requests. This parameter is not required when you add a global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, for example, <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>The rule name. This parameter is not required when you add a global configuration.</para>
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
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231231221****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Indicates whether TLS 1.0 is enabled. Default value: <c>off</c>. Valid values:</para>
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
        [NameInMap("Tls10")]
        [Validation(Required=false)]
        public string Tls10 { get; set; }

        /// <summary>
        /// <para>Indicates whether TLS 1.1 is enabled. Default value: <c>off</c>. Valid values:</para>
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
        [NameInMap("Tls11")]
        [Validation(Required=false)]
        public string Tls11 { get; set; }

        /// <summary>
        /// <para>Indicates whether TLS 1.2 is enabled. Default value: <c>off</c>. Valid values:</para>
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
        [NameInMap("Tls12")]
        [Validation(Required=false)]
        public string Tls12 { get; set; }

        /// <summary>
        /// <para>Indicates whether TLS 1.3 is enabled. Default value: <c>off</c>. Valid values:</para>
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
        [NameInMap("Tls13")]
        [Validation(Required=false)]
        public string Tls13 { get; set; }

    }

}
