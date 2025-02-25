// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body configuration.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListOriginRulesResponseBodyConfigs> Configs { get; set; }
        public class ListOriginRulesResponseBodyConfigs : TeaModel {
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
            /// <para>The origin server port accessed when using the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("OriginHttpPort")]
            [Validation(Required=false)]
            public string OriginHttpPort { get; set; }

            /// <summary>
            /// <para>The origin server port to access when using the HTTPS protocol for back-to-origin requests.</para>
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
            /// <item><description>http: Use HTTP protocol for origin requests.</description></item>
            /// <item><description>https: Use HTTPS protocol for origin requests.</description></item>
            /// <item><description>follow: Follow the client\&quot;s protocol for origin requests.</description></item>
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
            /// <para>Use range slicing to download files from the origin. The value range is:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled</description></item>
            /// <item><description>off: disabled</description></item>
            /// <item><description>force: forced</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

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
            /// <item><description>on: Enabled</description></item>
            /// <item><description>off: Disabled</description></item>
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

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The size of each page.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
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
