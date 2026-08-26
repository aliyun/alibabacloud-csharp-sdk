// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLivePullToPushShrinkRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>HTTP callback URL. Default value: empty.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URL that receives task-related callbacks.</description></item>
        /// <item><description>Maximum length is 2000 characters.</description></item>
        /// <item><description>If this parameter is not specified, no task event callbacks will be sent.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://callback*****.com">https://callback*****.com</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Destination URL address for pushing the stream.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The rtmp protocol is supported.</description></item>
        /// <item><description>Maximum length is 2000 characters.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://pushtest.********.aliyunlive.com/pulltest493/pulltest-w434</para>
        /// </summary>
        [NameInMap("DstUrl")]
        [Validation(Required=false)]
        public string DstUrl { get; set; }

        /// <summary>
        /// <para>Task end time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</description></item>
        /// <item><description>EndTime must be later than StartTime.</description></item>
        /// <item><description>EndTime must be later than the current time.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>File index. Starts playback from the nth file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FileIndex")]
        [Validation(Required=false)]
        public int? FileIndex { get; set; }

        [NameInMap("NotifyItemSwitch")]
        [Validation(Required=false)]
        public string NotifyItemSwitch { get; set; }

        /// <summary>
        /// <para>Start offset. The offset value from the beginning of the video file. Unit: seconds. Valid values: greater than 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Indicates the position to start reading from, relative to the first frame (applies to the first video).</description></item>
        /// <item><description>This parameter applies only to VOD or third-party video streams.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>Specifies the region where the task is launched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ap-southeast-1 (Singapore)</description></item>
        /// <item><description>ap-southeast-5 (Indonesia)</description></item>
        /// <item><description>cn-beijing (Beijing)</description></item>
        /// <item><description>cn-shanghai (Shanghai)</description></item>
        /// <item><description>cn-shenzhen (Shenzhen)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Number of times to repeat playback after the initial playback is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): no repeat playback.</description></item>
        /// <item><description>-1: loop indefinitely.</description></item>
        /// <item><description>Other positive integers: number of times to repeat playback after the initial playback is complete.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to VOD or third-party video streams.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNumber")]
        [Validation(Required=false)]
        public int? RepeatNumber { get; set; }

        [NameInMap("ReqAuth")]
        [Validation(Required=false)]
        public string ReqAuth { get; set; }

        /// <summary>
        /// <para>Number of retries. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// <para>Retry interval, in seconds. Valid values: [60, 300]. Default value: 60 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// <para>Source stream protocol name.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rtmp</description></item>
        /// <item><description>srt</description></item>
        /// <item><description>http-flv</description></item>
        /// <item><description>hls<remarks>
        /// <para>This parameter is <b>required only when the SourceType parameter is set to live</b>, and is invalid when the value is vod or url.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

        /// <summary>
        /// <para>Source stream type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>live: live stream.</description></item>
        /// <item><description>vod: ApsaraVideo VOD resource.</description></item>
        /// <item><description>url: third-party video file resource.</description></item>
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
        /// <para>List of source stream URL addresses.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For the live type, only one complete live playback URL is supported.</description></item>
        /// <item><description>For the vod and url types, a maximum of 30 URLs can be specified.</description></item>
        /// <item><description>The live type supports: rtmp, srt, and http-flv protocols.</description></item>
        /// <item><description>For the vod type, specify ApsaraVideo VOD media asset IDs.</description></item>
        /// <item><description>The url type supports: mp4 and http-flv protocols.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceUrls")]
        [Validation(Required=false)]
        public string SourceUrlsShrink { get; set; }

        /// <summary>
        /// <para>Task start time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-26T10:30:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Task name, used to support fuzzy query. Default value: &quot;&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
