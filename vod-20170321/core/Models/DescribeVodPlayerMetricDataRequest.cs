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
        /// <para>The metric dimension filter. A dimension consists of a dimension type (Field), an operator (Op), and a dimension value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify up to three dimensions.</description></item>
        /// <item><description>If the Metrics parameter includes any of the following four metrics, the Filters parameter does not take effect: Uv (number of playback users), AvgPerVv (average number of playbacks per user), AvgPerPlayDuration (average playback duration per user), and AvgPerCompletionVv (average number of completions per user).</description></item>
        /// <item><description>Use regionCode to specify provinces and countries.</description></item>
        /// <item><description>Separate multiple values with #_#.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Valid values for the dimension type (Field):</para>
        /// <list type="bullet">
        /// <item><description>SdkVersion: the SDK version.</description></item>
        /// <item><description>AppVersion: the app version.</description></item>
        /// <item><description>Codec: the codec.</description></item>
        /// <item><description>VideoType: the video format.</description></item>
        /// <item><description>Network: the network type.</description></item>
        /// <item><description>Country: the country.</description></item>
        /// <item><description>Isp: the ISP.</description></item>
        /// <item><description>VideoDefinition: the resolution.</description></item>
        /// <item><description>Domain: the domain name.</description></item>
        /// <item><description>Province: the province.</description></item>
        /// <item><description>IsHw: whether hardware decoding is used.</description></item>
        /// <item><description>ErrorCode: the error code.</description></item>
        /// </list>
        /// <para>Valid values for the operator (Op): = (equal to), &gt; (greater than), &lt; (less than), and != (not equal to).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Operator availability: The SdkVersion and VideoDefinition metrics support all four operators. Other metrics support only = (equal to) and != (not equal to).</description></item>
        /// </list>
        /// </remarks>
        /// <para>To obtain dimension values, call the DescribeVodPlayerDimensionData operation.</para>
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
        /// <para>The metric types. You can select multiple metrics, up to a maximum of three.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Percentage data is returned in decimal format.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Quality of Service (QoS) metrics for playback:</para>
        /// <list type="bullet">
        /// <item><description>Vv: the number of playbacks.</description></item>
        /// <item><description>RealVv: the actual playback volume.</description></item>
        /// <item><description>FirstFrame: the first frame loading time.</description></item>
        /// <item><description>SecondPlayRate: the 1-second startup rate.</description></item>
        /// <item><description>SlowPlayRate: the slow startup rate.</description></item>
        /// <item><description>StuckCountRate: the stuttering rate by count.</description></item>
        /// <item><description>SeekDuration: the seek duration.</description></item>
        /// <item><description>StuckDuration100s: the stuttering duration per 100 seconds.</description></item>
        /// <item><description>StuckCount100s: the number of stuttering events per 100 seconds.</description></item>
        /// <item><description>PlayFailRate: the playback failure rate.</description></item>
        /// <item><description>SeedFailRate: the non-startup rate.</description></item>
        /// <item><description>AvgPlayBitrate: the average playback bitrate.</description></item>
        /// <item><description>AvgStartBitrate: the average startup bitrate.</description></item>
        /// <item><description>ErrorCount100s: the number of errors per 100 seconds.</description></item>
        /// </list>
        /// <para>Quality of Experience (QoE) metrics for playback:</para>
        /// <list type="bullet">
        /// <item><description>Uv: the number of playback users.</description></item>
        /// <item><description>AvgPerVv: the average number of playbacks per user.</description></item>
        /// <item><description>AvgVideoDuration: the average video duration.</description></item>
        /// <item><description>AvgPerPlayDuration: the average playback duration per user.</description></item>
        /// <item><description>AvgPerCompletionVv: the average number of completions per user.</description></item>
        /// <item><description>CompletionVv: the completion volume.</description></item>
        /// <item><description>CompletionRate: the completion rate.</description></item>
        /// <item><description>AvgPlayDuration: the average playback duration.</description></item>
        /// <item><description>JumpRate5s: the 5-second bounce rate.</description></item>
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
        /// <para>The operating system of the playback client. You can specify this parameter to perform a filtered query for playback data of a specific operating system. Valid values: <b>Android</b>, <b>iOS</b>, <b>Harmony</b>, <b>Windows</b>, <b>macOS</b>, and <b>Linux</b>.
        /// The available values vary based on the terminal type:</para>
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
        /// <para>The start time of the query. Format: <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query playback data history for up to one year.</description></item>
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
        /// <item><description><b>web</b>: the web client.</description></item>
        /// <item><description><b>mobile</b>: the native client.</description></item>
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
        /// <para>The number of top data entries by playback volume to return. If you do not specify this parameter, all dimension data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public long? Top { get; set; }

    }

}
