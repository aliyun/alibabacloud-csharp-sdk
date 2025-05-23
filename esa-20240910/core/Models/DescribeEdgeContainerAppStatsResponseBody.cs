// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeEdgeContainerAppStatsResponseBody : TeaModel {
        [NameInMap("CpuUsageSecondsQuotaRateAvg")]
        [Validation(Required=false)]
        public double? CpuUsageSecondsQuotaRateAvg { get; set; }

        [NameInMap("CpuUsageSecondsTotalAvg")]
        [Validation(Required=false)]
        public double? CpuUsageSecondsTotalAvg { get; set; }

        [NameInMap("FsReadsBytesAvgAvg")]
        [Validation(Required=false)]
        public double? FsReadsBytesAvgAvg { get; set; }

        [NameInMap("FsWritesBytesAvgAvg")]
        [Validation(Required=false)]
        public double? FsWritesBytesAvgAvg { get; set; }

        [NameInMap("MemoryRssAvg")]
        [Validation(Required=false)]
        public double? MemoryRssAvg { get; set; }

        [NameInMap("MemoryRssQuotaRateAvg")]
        [Validation(Required=false)]
        public double? MemoryRssQuotaRateAvg { get; set; }

        [NameInMap("PodReadyRateAvg")]
        [Validation(Required=false)]
        public double? PodReadyRateAvg { get; set; }

        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<DescribeEdgeContainerAppStatsResponseBodyPoints> Points { get; set; }
        public class DescribeEdgeContainerAppStatsResponseBodyPoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("ContainerCpuUsageSecondsQuotaRate")]
            [Validation(Required=false)]
            public double? ContainerCpuUsageSecondsQuotaRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ContainerCpuUsageSecondsTotal")]
            [Validation(Required=false)]
            public double? ContainerCpuUsageSecondsTotal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContainerFsReadsBytesAvg")]
            [Validation(Required=false)]
            public double? ContainerFsReadsBytesAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContainerFsWritesBytesAvg")]
            [Validation(Required=false)]
            public double? ContainerFsWritesBytesAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("ContainerMemoryRss")]
            [Validation(Required=false)]
            public double? ContainerMemoryRss { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContainerMemoryRssQuotaRate")]
            [Validation(Required=false)]
            public double? ContainerMemoryRssQuotaRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PodReadyRate")]
            [Validation(Required=false)]
            public double? PodReadyRate { get; set; }

            /// <summary>
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
