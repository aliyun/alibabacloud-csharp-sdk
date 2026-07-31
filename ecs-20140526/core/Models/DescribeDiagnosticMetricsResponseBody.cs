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
            /// <para>CPU诊断</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether a script needs to be executed in the guest OS.</para>
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
            /// <para>CPU诊断</para>
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
            /// <para>The supported operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Windows: Windows operating systems are supported.</description></item>
            /// <item><description>Linux: Linux operating systems are supported.</description></item>
            /// <item><description>All: both Windows and Linux operating systems are supported.</description></item>
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
        /// <para>The pagination token returned in this call.</para>
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
