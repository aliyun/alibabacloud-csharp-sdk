// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLivePullToPushRequest : TeaModel {
        /// <summary>
        /// <para>The HTTP callback URL. By default, this parameter is left empty.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The URL is used to receive callbacks related to the task.</para>
        /// </description></item>
        /// <item><description><para>The URL can be up to 2,000 characters in length.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, no callbacks are returned for events related to the task.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://callback*****.com">https://callback*****.com</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The destination URL to which the stream is relayed.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The supported protocol for the URL is RTMP.</para>
        /// </description></item>
        /// <item><description><para>The URL can be up to 2,000 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://pushtest.********.aliyunlive.com/pulltest493/pulltest-w434</para>
        /// </summary>
        [NameInMap("DstUrl")]
        [Validation(Required=false)]
        public string DstUrl { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// </description></item>
        /// <item><description><para>The time range specified by the StartTime and EndTime parameters cannot exceed seven days.</para>
        /// </description></item>
        /// <item><description><para>The end time must be later than the start time.</para>
        /// </description></item>
        /// <item><description><para>The end time must be later than the current time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The file index, which specifies the sequence of the file where the playback starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FileIndex")]
        [Validation(Required=false)]
        public int? FileIndex { get; set; }

        /// <summary>
        /// <para>The offset of the position where the system starts to read the video resource. Unit: seconds. Valid values: positive numbers.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter indicates an offset from the first frame of the first video resource in the list.</para>
        /// </description></item>
        /// <item><description><para>This parameter is applicable to only video resources from ApsaraVideo VOD or a third party.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the task is started. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// <item><description>ap-southeast-5: Indonesia (Jakarta)</description></item>
        /// <item><description>cn-beijing: China (Beijing)</description></item>
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of playbacks after the first playback is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): specifies that the video list is played only once.</description></item>
        /// <item><description>\-1: specifies that the video list is played in loop mode.</description></item>
        /// <item><description>Positive integer: specifies the number of times the video list repeats after the first playback is complete.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is applicable to only video resources from ApsaraVideo VOD or a third party.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNumber")]
        [Validation(Required=false)]
        public int? RepeatNumber { get; set; }

        /// <summary>
        /// <para>The number of retries allowed. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// <para>The retry interval. Unit: seconds. Valid values: [60,300]. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// <para>The protocol of the source stream.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rtmp</description></item>
        /// <item><description>rtsp</description></item>
        /// <item><description>srt</description></item>
        /// <item><description>http-flv</description></item>
        /// <item><description>flv</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you set the <b>SourceType</b> parameter to live, but does not take effect if you set the SourceType parameter to vod or url.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

        /// <summary>
        /// <para>The type of the source stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>live: a live stream</description></item>
        /// <item><description>vod: a list of ApsaraVideo VOD resources</description></item>
        /// <item><description>url: a list of video resources from a third party</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The source URLs.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If SourceType is set to live, you can specify only one streaming URL.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to vod or url, you can specify up to 30 IDs or URLs.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to live, the supported protocols for URLs are Real-Time Messaging Protocol (RTMP), Real-Time Streaming Protocol (RTSP), Secure Reliable Transport Protocol (SRT), and HTTP-FLV.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to vod, specify the IDs of media assets from ApsaraVideo VOD.</para>
        /// </description></item>
        /// <item><description><para>If SourceType is set to url, the supported protocols for URLs are MP4 and HTTP-FLV.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testurls</para>
        /// </summary>
        [NameInMap("SourceUrls")]
        [Validation(Required=false)]
        public List<string> SourceUrls { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// </description></item>
        /// <item><description><para>The time range specified by the StartTime and EndTime parameters cannot exceed seven days.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-26T10:30:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the task. Default value: &quot;&quot;. Fuzzy search for task names is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
