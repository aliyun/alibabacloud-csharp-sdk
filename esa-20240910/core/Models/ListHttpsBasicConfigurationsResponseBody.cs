// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpsBasicConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body configuration.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpsBasicConfigurationsResponseBodyConfigs> Configs { get; set; }
        public class ListHttpsBasicConfigurationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>Custom ciphersuite, indicating the specific encryption algorithm selected when CiphersuiteGroup is set to custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
            /// </summary>
            [NameInMap("Ciphersuite")]
            [Validation(Required=false)]
            public string Ciphersuite { get; set; }

            /// <summary>
            /// <para>Ciphersuite group, defaults to enabling all ciphersuites. Value range:</para>
            /// <list type="bullet">
            /// <item><description>all: all ciphersuites.</description></item>
            /// <item><description>strict: strong ciphersuites.</description></item>
            /// <item><description>custom: custom ciphersuites.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>strict</para>
            /// </summary>
            [NameInMap("CiphersuiteGroup")]
            [Validation(Required=false)]
            public string CiphersuiteGroup { get; set; }

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
            /// <para>Configuration type, which can be used to query global or rule configurations. Value range:</para>
            /// <list type="bullet">
            /// <item><description>global: Query global configuration.</description></item>
            /// <item><description>rule: Query rule configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Whether to enable HTTP2, default is on. Value range:</para>
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
            /// <para>Whether to enable HTTP3, default is on. Value range:</para>
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
            /// <para>Whether to enable OCSP, default is off. Value range:</para>
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
            /// <para>Rule content, using conditional expressions to match user requests. This parameter is not required when adding a global configuration. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specific requests: Set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Rule switch. This parameter is not required when adding a global configuration. Value range:</para>
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
            /// <para>Rule name. This parameter is not required when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Rule execution order. The smaller the value, the higher the priority.</para>
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

        /// <summary>
        /// <para>Current page number.</para>
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
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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
