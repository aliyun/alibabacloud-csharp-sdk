// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerCollectDataRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: yyyy-mm-ddThh:mm:ssZ (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-05T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Valid values: <b>5m</b>, <b>1h</b>, and <b>1d</b>. The supported time granularity varies based on the time span specified by <c>StartTime</c> and <c>EndTime</c>:</para>
        /// <list type="bullet">
        /// <item><description>Within 3 days: <b>5m</b>, <b>1h</b>, and <b>1d</b>.</description></item>
        /// <item><description>4 to 7 days: <b>1h</b> and <b>1d</b>.</description></item>
        /// <item><description>More than 7 days: <b>1d</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The metric type. You can specify multiple metrics, up to three.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Percentage data is returned in decimal format.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Quality of Service (QoS) metrics for playback quality:</para>
        /// <list type="bullet">
        /// <item><description>Vv: Number of plays.</description></item>
        /// <item><description>RealVv: Actual play volume.</description></item>
        /// <item><description>FirstFrame: First frame time.</description></item>
        /// <item><description>SecondPlayRate: 1-second startup rate.</description></item>
        /// <item><description>SlowPlayRate: Slow startup rate.</description></item>
        /// <item><description>StuckCountRate: Stuttering count rate.</description></item>
        /// <item><description>SeekDuration: Seek duration.</description></item>
        /// <item><description>StuckDuration100s: Stuttering duration per 100 seconds.</description></item>
        /// <item><description>StuckCount100s: Stuttering count per 100 seconds.</description></item>
        /// <item><description>PlayFailRate: Playback failure rate.</description></item>
        /// <item><description>SeedFailRate: Unstarted playback rate.</description></item>
        /// <item><description>AvgPlayBitrate: Average playback bitrate.</description></item>
        /// <item><description>AvgStartBitrate: Average startup bitrate.</description></item>
        /// <item><description>ErrorCount100s: Error count per 100 seconds.</description></item>
        /// </list>
        /// <para>Quality of Experience (QoE) metrics for playback experience:</para>
        /// <list type="bullet">
        /// <item><description>Uv: Number of playback users.</description></item>
        /// <item><description>AvgPerVv: Average number of plays per user.</description></item>
        /// <item><description>AvgVideoDuration: Average video duration.</description></item>
        /// <item><description>AvgPerPlayDuration: Average playback duration per user.</description></item>
        /// <item><description>AvgPerCompletionVv: Average number of completed plays per user.</description></item>
        /// <item><description>CompletionVv: Completed play volume.</description></item>
        /// <item><description>CompletionRate: Completion rate.</description></item>
        /// <item><description>AvgPlayDuration: Average playback duration.</description></item>
        /// <item><description>JumpRate5s: 5-second bounce rate.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Vv,Uv,AvgPerVv</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The operating system of the playback terminal. You can specify this parameter to perform a filtered query for the playback data of a specific operating system. Valid values: <b>Android</b>, <b>iOS</b>, <b>Harmony</b>, <b>Windows</b>, <b>macOS</b>, and <b>Linux</b>.
        /// The valid values vary based on the terminal type:</para>
        /// <list type="bullet">
        /// <item><description><b>native</b>: Android, iOS, and Harmony.</description></item>
        /// <item><description><b>web</b>: Android, iOS, Harmony, Windows, macOS, and Linux.</description></item>
        /// </list>
        /// <para>Separate multiple operating systems with #_#.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android、iOS、Windows</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The time range used to confirm the period-over-period analysis, in days (d).</para>
        /// <para>For example, if you set the value to 1d (1 day), the period-over-period time range is from StartTime-1d to EndTime-1d.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query historical playback data for the last year.</description></item>
        /// <item><description>The time range for a single query cannot exceed 31 days.</description></item>
        /// <item><description>The time range is a left-closed and right-open interval [StartTime, EndTime).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-24T00:55:06Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The terminal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web</b>: Web client.</description></item>
        /// <item><description><b>mobile</b>: Native client.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
