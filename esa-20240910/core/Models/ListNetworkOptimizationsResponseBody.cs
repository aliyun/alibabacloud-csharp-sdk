// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListNetworkOptimizationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations returned in the response body.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListNetworkOptimizationsResponseBodyConfigs> Configs { get; set; }
        public class ListNetworkOptimizationsResponseBodyConfigs : TeaModel {
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
            /// <item><description>global: global configuration.</description></item>
            /// <item><description>rule: rule configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable gRPC. This feature is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Grpc")]
            [Validation(Required=false)]
            public string Grpc { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/2 back-to-origin. This feature is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public string Http2Origin { get; set; }

            /// <summary>
            /// <para>The rule content, which uses conditional expressions to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
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
            /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the smart routing service. This feature is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SmartRouting")]
            [Validation(Required=false)]
            public string SmartRouting { get; set; }

            /// <summary>
            /// <para>The maximum upload file size, in MB. Valid values: 100 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("UploadMaxFilesize")]
            [Validation(Required=false)]
            public string UploadMaxFilesize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable WebSocket. This feature is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Websocket")]
            [Validation(Required=false)]
            public string Websocket { get; set; }

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
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
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
