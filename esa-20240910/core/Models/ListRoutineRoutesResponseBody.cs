// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListRoutineRoutesResponseBodyConfigs> Configs { get; set; }
        public class ListRoutineRoutesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The bypass mode. Valid values:</para>
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
            [NameInMap("Bypass")]
            [Validation(Required=false)]
            public string Bypass { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35281609698****</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The type of configuration. You can query global configurations or rule-based configurations based on this parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: A global configuration.</para>
            /// </description></item>
            /// <item><description><para><c>rule</c>: A rule-based configuration.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable fallback to origin. If this feature is enabled, the request is routed to the origin server when an exception occurs in the edge function, such as exceeding the CPU usage limit. Valid values:</para>
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
            [NameInMap("Fallback")]
            [Validation(Required=false)]
            public string Fallback { get; set; }

            /// <summary>
            /// <para>The configuration mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>simple</c>: Simple mode.</para>
            /// </description></item>
            /// <item><description><para><c>custom</c>: Custom mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Indicates whether the route is enabled. Valid values:</para>
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
            [NameInMap("RouteEnable")]
            [Validation(Required=false)]
            public string RouteEnable { get; set; }

            /// <summary>
            /// <para>The route name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_route</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// <para>The edge function routine name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-routine1</para>
            /// </summary>
            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

            /// <summary>
            /// <para>The rule content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule execution order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>554889455535696</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The site configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>The timeout period. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public string Timeout { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
