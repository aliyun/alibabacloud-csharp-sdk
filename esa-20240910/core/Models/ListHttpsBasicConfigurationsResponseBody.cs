// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpsBasicConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations returned.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpsBasicConfigurationsResponseBodyConfigs> Configs { get; set; }
        public class ListHttpsBasicConfigurationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The custom cipher suite, which specifies the encryption algorithms selected when CiphersuiteGroup is set to custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
            /// </summary>
            [NameInMap("Ciphersuite")]
            [Validation(Required=false)]
            public string Ciphersuite { get; set; }

            /// <summary>
            /// <para>The cipher suite group. All cipher suites are enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: all cipher suites.</description></item>
            /// <item><description>strict: strong cipher suites.</description></item>
            /// <item><description>custom: custom cipher suites.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>strict</para>
            /// </summary>
            [NameInMap("CiphersuiteGroup")]
            [Validation(Required=false)]
            public string CiphersuiteGroup { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The configuration type. You can use this parameter to query global or rule configurations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: queries global configurations.</description></item>
            /// <item><description>rule: queries rule configurations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/2. HTTP/2 is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Http2")]
            [Validation(Required=false)]
            public string Http2 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/3. HTTP/3 is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Http3")]
            [Validation(Required=false)]
            public string Http3 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTPS. HTTPS is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: enabled.</para>
            /// </description></item>
            /// <item><description><para>off: disabled.</para>
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
            /// <para>Specifies whether to enable OCSP stapling. OCSP stapling is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OcspStapling")]
            [Validation(Required=false)]
            public string OcspStapling { get; set; }

            /// <summary>
            /// <para>The rule content, which uses a conditional expression to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: set the value to true.</description></item>
            /// <item><description>Match specified requests: set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. You do not need to set this parameter when adding a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name. You do not need to set this parameter when adding a global configuration.</para>
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
            /// <para>Specifies whether to enable TLS 1.0. TLS 1.0 is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Tls10")]
            [Validation(Required=false)]
            public string Tls10 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable TLS 1.1. TLS 1.1 is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Tls11")]
            [Validation(Required=false)]
            public string Tls11 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable TLS 1.2. TLS 1.2 is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Tls12")]
            [Validation(Required=false)]
            public string Tls12 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable TLS 1.3. TLS 1.3 is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Tls13")]
            [Validation(Required=false)]
            public string Tls13 { get; set; }

        }

        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
