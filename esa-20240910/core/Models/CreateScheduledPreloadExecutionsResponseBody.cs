// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about prefetch plans that failed to be added.</para>
        /// </summary>
        [NameInMap("FailedExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodyFailedExecutions> FailedExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodyFailedExecutions : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15685865xxx14622</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The end time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03T02:43:35Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The prefetch plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66599bd7397885b43804901c</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The interval between each batch execution of the scheduled prefetch plan. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The prefetch task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3af3621bccf3fe29e1a4</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The number of URLs to prefetch per batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            /// <summary>
            /// <para>The start time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-02T02:43:35Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the scheduled prefetch plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waiting</b>: Waiting to be executed.</description></item>
            /// <item><description><b>running</b>: Being executed.</description></item>
            /// <item><description><b>finished</b>: Execution completed.</description></item>
            /// <item><description><b>failed</b>: Execution failed.</description></item>
            /// <item><description><b>stopped</b>: Execution paused.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The list of failure messages for plans that failed to be added.</para>
        /// </summary>
        [NameInMap("FailedMessages")]
        [Validation(Required=false)]
        public List<string> FailedMessages { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of prefetch plans that were successfully added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The information about prefetch plans that were successfully added.</para>
        /// </summary>
        [NameInMap("SuccessExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodySuccessExecutions> SuccessExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodySuccessExecutions : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15685865xxx14622</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The end time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03T02:43:35Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The prefetch plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66599bd7397885b43804901c</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The interval between each batch execution of the scheduled prefetch plan. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The prefetch task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3af3621bccf3fe29e1a4</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The number of URLs to prefetch per batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            /// <summary>
            /// <para>The start time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-02T02:43:35Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the scheduled prefetch plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waiting</b>: Waiting to be executed.</description></item>
            /// <item><description><b>running</b>: Being executed.</description></item>
            /// <item><description><b>finished</b>: Execution completed.</description></item>
            /// <item><description><b>failed</b>: Execution failed.</description></item>
            /// <item><description><b>stopped</b>: Execution paused.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of plans requested to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
