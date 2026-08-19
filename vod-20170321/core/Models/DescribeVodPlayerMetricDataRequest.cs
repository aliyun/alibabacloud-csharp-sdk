// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerMetricDataRequest : TeaModel {
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
        /// <para>The metric dimension filters. A dimension consists of a dimension type (Field), an operator (Op), and a dimension value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of three dimensions can be specified.</description></item>
        /// <item><description>When the Metrics parameter includes the following four metrics, Filters do not take effect: Uv (playback users), AvgPerVv (average plays per user), AvgPerPlayDuration (average play duration per user), and AvgPerCompletionVv (average completion plays per user).</description></item>
        /// <item><description>For provinces and countries, pass the regionCode.</description></item>
        /// <item><description>Separate multiple values with #_#.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Valid values for dimension type (Field):</para>
        /// <list type="bullet">
        /// <item><description>SdkVersion: SDK version.</description></item>
        /// <item><description>AppVersion: app version.</description></item>
        /// <item><description>Codec: codec.</description></item>
        /// <item><description>VideoType: video format.</description></item>
        /// <item><description>Network: network type.</description></item>
        /// <item><description>Country: country.</description></item>
        /// <item><description>Isp: ISP.</description></item>
        /// <item><description>VideoDefinition: resolution.</description></item>
        /// <item><description>Domain: domain name.</description></item>
        /// <item><description>Province: province.</description></item>
        /// <item><description>IsHw: whether hardware decoding is used.</description></item>
        /// <item><description>ErrorCode: error code.</description></item>
        /// </list>
        /// <para>Valid values for operator (Op): = (equal to), &gt; (greater than), &lt; (less than), and != (not equal to).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>SdkVersion and VideoDefinition support all four operators. Other metrics support only = (equal to) and != (not equal to).</description></item>
        /// </list>
        /// </remarks>
        /// <para>Retrieve dimension values by calling DescribeVodPlayerDimensionData.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;Field&quot;: &quot;codec&quot;,
        ///     &quot;Op&quot;: &quot;=&quot;,
        ///     &quot;Value&quot;: &quot;h265#<em>#h264&quot;
        ///   },
        ///   {
        ///     &quot;Field&quot;: &quot;os&quot;,
        ///     &quot;Op&quot;: &quot;=&quot;,
        ///     &quot;Value&quot;: &quot;Android#</em>#iOS&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The time granularity for querying data. Valid values: <b>5m</b>, <b>1h</b>, and <b>1d</b>. The supported time granularity depends on the time span between <c>StartTime</c> and <c>EndTime</c>:</para>
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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (<b>default</b>): Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The metric types. You can select multiple metrics (up to 3).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Percentage data is returned in decimal form.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Quality of Service (QoS) metrics:</para>
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
        /// <item><description>PlayFailRate: play failure rate.</description></item>
        /// <item><description>SeedFailRate: non-play rate.</description></item>
        /// <item><description>AvgPlayBitrate: average playback bitrate.</description></item>
        /// <item><description>AvgStartBitrate: average start bitrate.</description></item>
        /// <item><description>ErrorCount100s: error count per 100 seconds.</description></item>
        /// </list>
        /// <para>Quality of Experience (QoE) metrics:</para>
        /// <list type="bullet">
        /// <item><description>Uv: playback users.</description></item>
        /// <item><description>AvgPerVv: average plays per user.</description></item>
        /// <item><description>AvgVideoDuration: average video duration.</description></item>
        /// <item><description>AvgPerPlayDuration: average play duration per user.</description></item>
        /// <item><description>AvgPerCompletionVv: average completion plays per user.</description></item>
        /// <item><description>CompletionVv: completion count.</description></item>
        /// <item><description>CompletionRate: completion rate.</description></item>
        /// <item><description>AvgPlayDuration: average play duration.</description></item>
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
        /// <para>The operating system of the player. Specify this parameter to perform a filtered query for playback data of a specific operating system. Valid values: <b>Android</b>, <b>iOS</b>, <b>Harmony</b>, <b>Windows</b>, <b>MacOS</b>, and <b>Linux</b>.
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>5000</b>. Maximum value: <b>5000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-mm-dd</i>t<i>hh:mm:ss</i>z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Supports querying playback data history for the past year.</description></item>
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

        /// <summary>
        /// <para>Returns data for the top N items ranked by play count. If this parameter is not specified, data for all dimensions is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public long? Top { get; set; }

    }

}
