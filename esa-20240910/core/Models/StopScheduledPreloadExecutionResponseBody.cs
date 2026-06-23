// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class StopScheduledPreloadExecutionResponseBody : TeaModel {
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
        /// <para>2024-05-31T18:10:48.849+08:00</para>
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
        /// <para>The interval between each batch execution of the scheduled prefetch plan, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The prefetch job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>665d3af3621bccf3fe29e1a4</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of URLs prefetched per batch.</para>
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
        /// <para>2024-05-31T17:10:48.849+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the scheduled prefetch plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waiting</b>: waiting to be executed.</description></item>
        /// <item><description><b>running</b>: being executed.</description></item>
        /// <item><description><b>finished</b>: execution completed.</description></item>
        /// <item><description><b>failed</b>: execution failed.</description></item>
        /// <item><description><b>stopped</b>: execution paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
