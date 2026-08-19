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
        /// <para>The end time of the query. Format: yyyy-mm-ddthh:mm:ssz (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-05T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for the query data. Valid values: <b>5m</b>, <b>1h</b>, and <b>1d</b>. The supported time granularity varies based on the time span specified by <c>StartTime</c> and <c>EndTime</c>:</para>
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
        /// <para>The metric type. You can specify up to 3 metrics.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Percentage data is returned in decimal format.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Playback quality (QoS) metrics:</para>
        /// <list type="bullet">
        /// <item><description>Vv: play count.</description></item>
        /// <item><description>RealVv: actual play count.</description></item>
        /// <item><description>FirstFrame: first frame time.</description></item>
        /// <item><description>SecondPlayRate: instant play rate.</description></item>
        /// <item><description>SlowPlayRate: slow play rate.</description></item>
        /// <item><description>StuckCountRate: stuttering rate by count.</description></item>
        /// <item><description>SeekDuration: seek duration.</description></item>
        /// <item><description>StuckDuration100s: stuttering duration per 100 seconds.</description></item>
        /// <item><description>StuckCount100s: stuttering count per 100 seconds.</description></item>
        /// <item><description>PlayFailRate: playback failure rate.</description></item>
        /// <item><description>SeedFailRate: non-play rate.</description></item>
        /// <item><description>AvgPlayBitrate: average playback bitrate.</description></item>
        /// <item><description>AvgStartBitrate: average initial bitrate.</description></item>
        /// <item><description>ErrorCount100s: error count per 100 seconds.</description></item>
        /// </list>
        /// <para>Playback experience (QoE) metrics:</para>
        /// <list type="bullet">
        /// <item><description>Uv: unique viewers.</description></item>
        /// <item><description>AvgPerVv: average plays per user.</description></item>
        /// <item><description>AvgVideoDuration: average video duration.</description></item>
        /// <item><description>AvgPerPlayDuration: average playback duration per user.</description></item>
        /// <item><description>AvgPerCompletionVv: average completion count per user.</description></item>
        /// <item><description>CompletionVv: completion count.</description></item>
        /// <item><description>CompletionRate: completion rate.</description></item>
        /// <item><description>AvgPlayDuration: average playback duration.</description></item>
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
        /// <para>The operating system of the playback device. Specify this parameter to perform a filtered query for playback data of a specific operating system. Valid values: <b>Android</b>, <b>iOS</b>, <b>Harmony</b>, <b>Windows</b>, <b>MacOS</b>, and <b>Linux</b>.
        /// The available values vary by terminal type:</para>
        /// <list type="bullet">
        /// <item><description><b>native</b>: Android, iOS, Harmony.</description></item>
        /// <item><description><b>web</b>: Android, iOS, Harmony, Windows, MacOs, Linux.</description></item>
        /// </list>
        /// <para>Separate multiple values with #_#.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android、iOS、Windows</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The time range for period-over-period analysis, in days (d).</para>
        /// <para>For example, if you set this parameter to 1d (1 day), the period-over-period data is retrieved from the time range of StartTime-1d to EndTime-1d.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-mm-dd</i>t<i>hh:mm:ss</i>z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Playback data from the last year can be queried.</description></item>
        /// <item><description>The time range for a single query cannot exceed 31 days.</description></item>
        /// <item><description>The time interval is left-closed and right-open [StartTime, EndTime).</description></item>
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
        /// <item><description><b>web</b>: web.</description></item>
        /// <item><description><b>mobile</b>: native.</description></item>
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
