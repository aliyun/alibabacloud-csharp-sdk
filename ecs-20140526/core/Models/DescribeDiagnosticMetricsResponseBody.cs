// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic metrics.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricsResponseBodyMetrics> Metrics { get; set; }
        public class DescribeDiagnosticMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <para>The description of the diagnostic metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU diagnostic</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the diagnostic metric needs to be assessed by running a Cloud Assistant command in a guest operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GuestMetric")]
            [Validation(Required=false)]
            public bool? GuestMetric { get; set; }

            /// <summary>
            /// <para>The category of the diagnostic metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("MetricCategory")]
            [Validation(Required=false)]
            public string MetricCategory { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GuestOS.WinFirewall</para>
            /// </summary>
            [NameInMap("MetricId")]
            [Validation(Required=false)]
            public string MetricId { get; set; }

            /// <summary>
            /// <para>The name of the diagnostic metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU diagnostic</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The resource type supported by the diagnostic metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The operating system type supported by the diagnostic metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Windows</description></item>
            /// <item><description>Linux</description></item>
            /// <item><description>All: Windows and Linux</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("SupportedOperatingSystem")]
            [Validation(Required=false)]
            public string SupportedOperatingSystem { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
