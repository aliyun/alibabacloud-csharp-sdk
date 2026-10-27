// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetScriptTrendingReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the statistics. The parameter value must be a UNIX timestamp in milliseconds. It indicates the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970. The following limits apply:</para>
        /// <ol>
        /// <item><description><para>Time range: You can query data by hour for up to 7 days or by day for up to 180 days.</para>
        /// </description></item>
        /// <item><description><para>Alignment with time granularity: If you query data by hour, the minutes, seconds, and milliseconds must be 0. If you query data by day, the hours, minutes, seconds, and milliseconds must be 0. If the specified timestamp is not aligned with the time granularity, the system automatically rounds it up to the next valid time.</para>
        /// </description></item>
        /// </ol>
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
        /// <para>12f407b22cbe4890ac595f09985848d5</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>891264b9-5883-4068-94a6-241ceb8d51e4</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The start time of the statistics. The parameter value is a UNIX timestamp in milliseconds. It indicates the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970. The following limits apply:</para>
        /// <ol>
        /// <item><description><para>Valid start time: You can query data collected within the last 365 days from the current date.</para>
        /// </description></item>
        /// <item><description><para>Alignment with time granularity: If you query data by hour, the minutes, seconds, and milliseconds must be 0. If you query data by day, the hours, minutes, seconds, and milliseconds must be 0.</para>
        /// </description></item>
        /// <item><description><para>If the specified timestamp is not aligned with the time granularity, the system automatically rounds it up to the next valid time.</para>
        /// </description></item>
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
