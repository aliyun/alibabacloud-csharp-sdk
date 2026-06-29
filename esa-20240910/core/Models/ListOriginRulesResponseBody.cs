// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations in the response.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListOriginRulesResponseBodyConfigs> Configs { get; set; }
        public class ListOriginRulesResponseBodyConfigs : TeaModel {
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
            /// <para>The configuration type. You can query global or rule configurations based on this parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: Query global configurations.</description></item>
            /// <item><description>rule: Query rule configurations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The rewritten DNS resolution record for back-to-origin requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("DnsRecord")]
            [Validation(Required=false)]
            public string DnsRecord { get; set; }

            /// <summary>
            /// <para>The back-to-origin 302 redirect follow switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302Enable")]
            [Validation(Required=false)]
            public string Follow302Enable { get; set; }

            /// <summary>
            /// <para>The maximum number of 302 redirect follows. Valid values: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Follow302MaxTries")]
            [Validation(Required=false)]
            public string Follow302MaxTries { get; set; }

            /// <summary>
            /// <para>The switch for retaining original request parameters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302RetainArgs")]
            [Validation(Required=false)]
            public string Follow302RetainArgs { get; set; }

            /// <summary>
            /// <para>The switch for retaining original request headers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Follow302RetainHeader")]
            [Validation(Required=false)]
            public string Follow302RetainHeader { get; set; }

            /// <summary>
            /// <para>The back-to-origin host after 302 redirect modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Follow302TargetHost")]
            [Validation(Required=false)]
            public string Follow302TargetHost { get; set; }

            /// <summary>
            /// <para>The HOST carried in the back-to-origin request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("OriginHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            /// <summary>
            /// <para>The origin server port accessed when using the HTTP protocol for back-to-origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("OriginHttpPort")]
            [Validation(Required=false)]
            public string OriginHttpPort { get; set; }

            /// <summary>
            /// <para>The origin server port accessed when using the HTTPS protocol for back-to-origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4433</para>
            /// </summary>
            [NameInMap("OriginHttpsPort")]
            [Validation(Required=false)]
            public string OriginHttpsPort { get; set; }

            /// <summary>
            /// <para>The mTLS switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OriginMtls")]
            [Validation(Required=false)]
            public string OriginMtls { get; set; }

            /// <summary>
            /// <para>The origin server read timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OriginReadTimeout")]
            [Validation(Required=false)]
            public string OriginReadTimeout { get; set; }

            /// <summary>
            /// <para>The protocol used for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>http: Use the HTTP protocol for back-to-origin.</description></item>
            /// <item><description>https: Use the HTTPS protocol for back-to-origin.</description></item>
            /// <item><description>follow: Follow the client protocol for back-to-origin.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("OriginScheme")]
            [Validation(Required=false)]
            public string OriginScheme { get; set; }

            /// <summary>
            /// <para>The SNI carried in the back-to-origin request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("OriginSni")]
            [Validation(Required=false)]
            public string OriginSni { get; set; }

            /// <summary>
            /// <para>The origin server certificate verification switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OriginVerify")]
            [Validation(Required=false)]
            public string OriginVerify { get; set; }

            /// <summary>
            /// <para>Use range-based slicing for back-to-origin file downloads. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enable.</description></item>
            /// <item><description>off: Disable.</description></item>
            /// <item><description>force: Force enable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            /// <summary>
            /// <para>The range chunk size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1MB</para>
            /// </summary>
            [NameInMap("RangeChunkSize")]
            [Validation(Required=false)]
            public string RangeChunkSize { get; set; }

            /// <summary>
            /// <para>The rule content, which uses conditional expressions to match user requests. You do not need to set this parameter when adding a global configuration. There are two usage scenarios:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specified requests: Set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
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
            /// <para>The rule name. You do not need to set this parameter when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution order of the rule. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>The current page number, same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
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
