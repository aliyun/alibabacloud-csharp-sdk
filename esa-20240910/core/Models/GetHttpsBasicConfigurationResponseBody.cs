// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetHttpsBasicConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Custom cipher suite, indicating the specific encryption algorithm selected when CiphersuiteGroup is set to custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
        /// </summary>
        [NameInMap("Ciphersuite")]
        [Validation(Required=false)]
        public string Ciphersuite { get; set; }

        /// <summary>
        /// <para>Cipher suite group, default is all cipher suites. Value range:</para>
        /// <list type="bullet">
        /// <item><description>all: All cipher suites.</description></item>
        /// <item><description>strict: Strong cipher suites.</description></item>
        /// <item><description>custom: Custom cipher suites.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("CiphersuiteGroup")]
        [Validation(Required=false)]
        public string CiphersuiteGroup { get; set; }

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
        /// <item><description>global: Query global configuration;</description></item>
        /// <item><description>rule: Query rule configuration;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>Whether to enable HTTP2, default is enabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        /// <summary>
        /// <para>Whether to enable HTTP3, which is enabled by default. The value can be:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled. </description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http3")]
        [Validation(Required=false)]
        public string Http3 { get; set; }

        /// <summary>
        /// <para>Whether to enable HTTPS, default is enabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Https")]
        [Validation(Required=false)]
        public string Https { get; set; }

        /// <summary>
        /// <para>Whether to enable OCSP, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OcspStapling")]
        [Validation(Required=false)]
        public string OcspStapling { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Matching rule content.</para>
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
        /// <para>Whether to enable TLS1.0, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls10")]
        [Validation(Required=false)]
        public string Tls10 { get; set; }

        /// <summary>
        /// <para>Whether to enable TLS1.1, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls11")]
        [Validation(Required=false)]
        public string Tls11 { get; set; }

        /// <summary>
        /// <para>Whether to enable TLS1.2, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls12")]
        [Validation(Required=false)]
        public string Tls12 { get; set; }

        /// <summary>
        /// <para>Whether to enable TLS1.3, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable.</description></item>
        /// <item><description>off: Disable.</description></item>
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
