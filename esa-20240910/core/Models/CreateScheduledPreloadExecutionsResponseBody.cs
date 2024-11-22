// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about prefetch plans that failed to be created.</para>
        /// </summary>
        [NameInMap("FailedExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodyFailedExecutions> FailedExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodyFailedExecutions : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15685865xxx14622</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The end time of the prefetch plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03T02:43:35Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the prefetch plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66599bd7397885b43804901c</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time interval between each batch execution. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The ID of the prefetch task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3af3621bccf3fe29e1a4</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The number of URLs prefetched in each batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            /// <summary>
            /// <para>The start time of the prefetch plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-02T02:43:35Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the prefetch plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waiting</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>finished</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>stopped</b></description></item>
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
        /// <para>The information about plan failures.</para>
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
        /// <para>The number of prefetch plans that are created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The information about created prefetch plans.</para>
        /// </summary>
        [NameInMap("SuccessExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodySuccessExecutions> SuccessExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodySuccessExecutions : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15685865xxx14622</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The end time of the prefetch plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03T02:43:35Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the prefetch plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66599bd7397885b43804901c</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time interval between each batch execution. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The ID of the prefetch task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>665d3af3621bccf3fe29e1a4</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The number of URLs prefetched in each batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            /// <summary>
            /// <para>The start time of the prefetch plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-02T02:43:35Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the prefetch plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waiting</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>finished</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// <item><description><b>stopped</b></description></item>
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
        /// <para>The total number of new plans requested.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
