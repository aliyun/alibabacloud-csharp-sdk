// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The bypass mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
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
        /// <para>352816******</para>
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
        /// <para>The back-to-origin on exception switch. When enabled, if the function encounters an exception such as CPU usage exceeding the limit, the request is forwarded to the origin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
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
        /// <item><description>simple: simple mode.</description></item>
        /// <item><description>custom: custom mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The route switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
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
        /// <para>The Edge Routine name.</para>
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
        /// <para>The version number of the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>The Edge Routine timeout period. Valid values: 5 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public string Timeout { get; set; }

    }

}
