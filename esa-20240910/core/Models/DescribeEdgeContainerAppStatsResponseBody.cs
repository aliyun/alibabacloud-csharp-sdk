// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeEdgeContainerAppStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The average CPU usage as a percentage of the limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("CpuUsageSecondsQuotaRateAvg")]
        [Validation(Required=false)]
        public double? CpuUsageSecondsQuotaRateAvg { get; set; }

        /// <summary>
        /// <para>Average CPU core usage, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuUsageSecondsTotalAvg")]
        [Validation(Required=false)]
        public double? CpuUsageSecondsTotalAvg { get; set; }

        /// <summary>
        /// <para>The average read IO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FsReadsBytesAvgAvg")]
        [Validation(Required=false)]
        public double? FsReadsBytesAvgAvg { get; set; }

        /// <summary>
        /// <para>The average write IO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FsWritesBytesAvgAvg")]
        [Validation(Required=false)]
        public double? FsWritesBytesAvgAvg { get; set; }

        /// <summary>
        /// <para>The average memory usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("MemoryRssAvg")]
        [Validation(Required=false)]
        public double? MemoryRssAvg { get; set; }

        /// <summary>
        /// <para>The average memory usage as a percentage of the limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MemoryRssQuotaRateAvg")]
        [Validation(Required=false)]
        public double? MemoryRssQuotaRateAvg { get; set; }

        /// <summary>
        /// <para>The average pod ready rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PodReadyRateAvg")]
        [Validation(Required=false)]
        public double? PodReadyRateAvg { get; set; }

        /// <summary>
        /// <para>The time and value of each data point for the chart.</para>
        /// </summary>
        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<DescribeEdgeContainerAppStatsResponseBodyPoints> Points { get; set; }
        public class DescribeEdgeContainerAppStatsResponseBodyPoints : TeaModel {
            /// <summary>
            /// <para>The CPU usage as a percentage of the limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("ContainerCpuUsageSecondsQuotaRate")]
            [Validation(Required=false)]
            public double? ContainerCpuUsageSecondsQuotaRate { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ContainerCpuUsageSecondsTotal")]
            [Validation(Required=false)]
            public double? ContainerCpuUsageSecondsTotal { get; set; }

            /// <summary>
            /// <para>The read IO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContainerFsReadsBytesAvg")]
            [Validation(Required=false)]
            public double? ContainerFsReadsBytesAvg { get; set; }

            /// <summary>
            /// <para>The write IO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContainerFsWritesBytesAvg")]
            [Validation(Required=false)]
            public double? ContainerFsWritesBytesAvg { get; set; }

            /// <summary>
            /// <para>The memory usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("ContainerMemoryRss")]
            [Validation(Required=false)]
            public double? ContainerMemoryRss { get; set; }

            /// <summary>
            /// <para>The memory usage as a percentage of the limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContainerMemoryRssQuotaRate")]
            [Validation(Required=false)]
            public double? ContainerMemoryRssQuotaRate { get; set; }

            /// <summary>
            /// <para>The pod ready rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PodReadyRate")]
            [Validation(Required=false)]
            public double? PodReadyRate { get; set; }

            /// <summary>
            /// <para>The time of the data point. The format is yyyy-MM-ddTHH:mm:ssZ in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-18T15:04:05Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>35C66C7B-671H-4297-9187-2C4477247A78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
