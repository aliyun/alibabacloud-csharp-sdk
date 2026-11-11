// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListErrorPagesRedirectRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code redirection configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListErrorPagesRedirectRulesResponseBodyConfigs> Configs { get; set; }
        public class ListErrorPagesRedirectRulesResponseBodyConfigs : TeaModel {
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
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: Global configuration.</description></item>
            /// <item><description>rule: Rule configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The error code redirection.</para>
            /// </summary>
            [NameInMap("ErrorPagesRedirect")]
            [Validation(Required=false)]
            public List<ListErrorPagesRedirectRulesResponseBodyConfigsErrorPagesRedirect> ErrorPagesRedirect { get; set; }
            public class ListErrorPagesRedirectRulesResponseBodyConfigsErrorPagesRedirect : TeaModel {
                /// <summary>
                /// <para>The response status code used by the node when responding to the client with a redirect address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>400</description></item>
                /// <item><description>403</description></item>
                /// <item><description>404</description></item>
                /// <item><description>405</description></item>
                /// <item><description>414</description></item>
                /// <item><description>416</description></item>
                /// <item><description>500</description></item>
                /// <item><description>501</description></item>
                /// <item><description>502</description></item>
                /// <item><description>503</description></item>
                /// <item><description>504</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>The target URL after redirection.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/test">http://example.com/test</a></para>
                /// </summary>
                [NameInMap("TargetURL")]
                [Validation(Required=false)]
                public string TargetURL { get; set; }

            }

            /// <summary>
            /// <para>The rule content. Uses a conditional expression to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specific requests: Set the value to a custom expression, such as (http.host eq &quot;video.example.com&quot;).</description></item>
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
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 500. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
