// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetInstanceTrendingReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the statistical period. The value is a millisecond-level UNIX timestamp that represents the number of milliseconds elapsed since 1970-01-01 00:00:00 UTC. The following constraints apply:</para>
        /// <para>Time range constraint: The maximum time range is 7 days for hourly queries and 180 days for daily queries.
        /// Time granularity alignment: For hourly queries, the minutes, seconds, and milliseconds must be 0. For daily queries, the hours, minutes, seconds, and milliseconds must be 0.
        /// If the specified timestamp is not aligned with the corresponding granularity, the server automatically rounds it up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582103299434</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82b2eaae-ce5c-45f8-8231-f15b6b27e55c</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the statistical period. The value is a millisecond-level UNIX timestamp that represents the number of milliseconds elapsed since 1970-01-01 00:00:00 UTC. The following constraints apply:</para>
        /// <ol>
        /// <item><description>Earliest boundary: The start time can trace back to 00:00:00 of the date 365 calendar days before the current date.</description></item>
        /// <item><description>Time granularity alignment: For hourly queries, the minutes, seconds, and milliseconds must be 0. For daily queries, the hours, minutes, seconds, and milliseconds must be 0.</description></item>
        /// <item><description>If the specified timestamp is not aligned with the corresponding granularity, the server automatically rounds it up.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1582267398628</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The time interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("TimeInterval")]
        [Validation(Required=false)]
        public string TimeInterval { get; set; }

    }

}
