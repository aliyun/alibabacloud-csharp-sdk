// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudBasicMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic metrics.</para>
        /// </summary>
        [NameInMap("BasicMonitors")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudBasicMonitorResponseBodyBasicMonitors> BasicMonitors { get; set; }
        public class DescribeHybridCloudBasicMonitorResponseBodyBasicMonitors : TeaModel {
            [NameInMap("Levle")]
            [Validation(Required=false)]
            public string Levle { get; set; }

            /// <summary>
            /// <para>The metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>basic_monitor_cpu_usage</b>: the CPU.</description></item>
            /// <item><description><b>basic_monitor_memory_usage</b>: the memory.</description></item>
            /// <item><description><b>basic_monitor_disk_usage</b>: the disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic_monitor_cpu_usage</para>
            /// </summary>
            [NameInMap("MonitorName")]
            [Validation(Required=false)]
            public string MonitorName { get; set; }

            /// <summary>
            /// <para>The resource usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.905694</para>
            /// </summary>
            [NameInMap("UseRatio")]
            [Validation(Required=false)]
            public long? UseRatio { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B8AF42B-16A9-5762-AEF3-D148****FE5D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
