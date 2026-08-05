// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLivePullToPushRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL. Default value: empty.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URL that receives task-related callbacks.</description></item>
        /// <item><description>Maximum length: 2000 characters.</description></item>
        /// <item><description>If this parameter is not specified, task events are not sent as callbacks.</description></item>
        /// <item><description>The update takes effect when the next event is triggered.</description></item>
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
        /// <para>The end time of the task.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</description></item>
        /// <item><description>EndTime must be later than StartTime.</description></item>
        /// <item><description>EndTime must be later than the current time.</description></item>
        /// <item><description>If the task has already ended, this update does not take effect.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T14:30:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The video index. Default value: 0.</para>
        /// <remarks>
        /// <para>Update this parameter while the task is stopped. The update takes effect after the task is restarted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FileIndex")]
        [Validation(Required=false)]
        public int? FileIndex { get; set; }

        /// <summary>
        /// <para>The start offset of the video file, in seconds. The value must be greater than 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specifies the position relative to the first frame from which to start reading.</description></item>
        /// <item><description>This parameter applies only to video-on-demand or third-party video streams.</description></item>
        /// <item><description>This parameter takes effect only when the first video in the playlist is played.</description></item>
        /// <item><description>Update this parameter while the task is stopped. The update takes effect after the task is restarted.</description></item>
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
        /// <para>The region where the task is launched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ap-southeast-1 (Singapore)</description></item>
        /// <item><description>ap-southeast-5 (Indonesia)</description></item>
        /// <item><description>cn-beijing (Beijing)</description></item>
        /// <item><description>cn-shanghai (Shanghai).</description></item>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of times playback repeats after the playlist finishes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): no repeat.</description></item>
        /// <item><description>-1: loop indefinitely.</description></item>
        /// <item><description>Other positive integers: the number of times playback repeats after the playlist finishes.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to video-on-demand or third-party video streams.</description></item>
        /// <item><description>The update takes effect immediately.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatNumber")]
        [Validation(Required=false)]
        public int? RepeatNumber { get; set; }

        /// <summary>
        /// <para>The list of source stream URLs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For the live type, only one complete live streaming URL is supported.</description></item>
        /// <item><description>For the vod and url types, up to 30 URLs can be specified.</description></item>
        /// <item><description>The live type supports RTMP, SRT, and HTTP-FLV protocols.</description></item>
        /// <item><description>For the vod type, specify ApsaraVideo VOD media asset IDs.</description></item>
        /// <item><description>The url type supports MP4 and HTTP-FLV protocols.</description></item>
        /// <item><description>For live source streams, the update takes effect immediately. For video file source streams, the update takes effect after the currently playing video ends, and playback restarts from the beginning of the updated video list.</description></item>
        /// <item><description>Update this parameter while the task is stopped. The update takes effect after the task is restarted.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>changedtesturl</para>
        /// </summary>
        [NameInMap("SourceUrls")]
        [Validation(Required=false)]
        public List<string> SourceUrls { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</description></item>
        /// <item><description>If the task has already started running, this update does not take effect.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-23T15:30:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd245384-4067-4f91-9d75-9666a6bc****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
