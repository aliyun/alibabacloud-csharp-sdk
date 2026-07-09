// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The name of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate the request during troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735574400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public GetPipelineStatsResponseBodySummary Summary { get; set; }
        public class GetPipelineStatsResponseBodySummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2500</para>
            /// </summary>
            [NameInMap("avgElapsedMs")]
            [Validation(Required=false)]
            public long? AvgElapsedMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cancelledRuns")]
            [Validation(Required=false)]
            public long? CancelledRuns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1735660800</para>
            /// </summary>
            [NameInMap("committedWatermark")]
            [Validation(Required=false)]
            public long? CommittedWatermark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failedRuns")]
            [Validation(Required=false)]
            public long? FailedRuns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("scheduleLagSeconds")]
            [Validation(Required=false)]
            public long? ScheduleLagSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44</para>
            /// </summary>
            [NameInMap("succeededRuns")]
            [Validation(Required=false)]
            public long? SucceededRuns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("successRate")]
            [Validation(Required=false)]
            public double? SuccessRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3221225472</para>
            /// </summary>
            [NameInMap("totalOutputBytes")]
            [Validation(Required=false)]
            public long? TotalOutputBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200000</para>
            /// </summary>
            [NameInMap("totalOutputRows")]
            [Validation(Required=false)]
            public long? TotalOutputRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5368709120</para>
            /// </summary>
            [NameInMap("totalProcessedBytes")]
            [Validation(Required=false)]
            public long? TotalProcessedBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1500000</para>
            /// </summary>
            [NameInMap("totalProcessedRows")]
            [Validation(Required=false)]
            public long? TotalProcessedRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44</para>
            /// </summary>
            [NameInMap("totalRuns")]
            [Validation(Required=false)]
            public long? TotalRuns { get; set; }

        }

        [NameInMap("timeSeries")]
        [Validation(Required=false)]
        public List<GetPipelineStatsResponseBodyTimeSeries> TimeSeries { get; set; }
        public class GetPipelineStatsResponseBodyTimeSeries : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2500</para>
            /// </summary>
            [NameInMap("avgElapsedMs")]
            [Validation(Required=false)]
            public long? AvgElapsedMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>322122547</para>
            /// </summary>
            [NameInMap("outputBytes")]
            [Validation(Required=false)]
            public long? OutputBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80000</para>
            /// </summary>
            [NameInMap("outputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>536870912</para>
            /// </summary>
            [NameInMap("processedBytes")]
            [Validation(Required=false)]
            public long? ProcessedBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("processedRows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("runs")]
            [Validation(Required=false)]
            public long? Runs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("succeededRuns")]
            [Validation(Required=false)]
            public long? SucceededRuns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1735574400</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
