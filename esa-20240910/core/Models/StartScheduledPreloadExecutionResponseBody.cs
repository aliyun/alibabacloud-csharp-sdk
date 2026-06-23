// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class StartScheduledPreloadExecutionResponseBody : TeaModel {
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
        /// <para>665d3b48621bccf3fe29e1a7</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The execution interval between each batch of the scheduled prefetch plan, in seconds.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65C66B7B-671A-8297-9187-2R5477247B76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of URLs in each batch of the scheduled prefetch.</para>
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
        /// <item><description><b>waiting</b>: Waiting to be executed.</description></item>
        /// <item><description><b>running</b>: Being executed.</description></item>
        /// <item><description><b>finished</b>: Execution completed.</description></item>
        /// <item><description><b>failed</b>: Execution failed.</description></item>
        /// <item><description><b>stopped</b>: Execution paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>waiting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
