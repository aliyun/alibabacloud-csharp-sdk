// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// The maximum number of snapshots. Default value: **1**.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The height of each snapshot. Valid values: `[8,4096]`. By default, the height of the video source is used. Unit: pixels.
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        /// <summary>
        /// The snapshot interval. The value must be **greater than or equal to 0**.
        /// 
        /// *   Unit: seconds.
        /// *   Default value: **1**.
        /// *   If you set this parameter to **0**, snapshots are captured at even intervals based on the video duration divided by the value of the Count parameter.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// The ID of the snapshot template.
        /// 
        /// *   We recommend that you create a snapshot template before you specify the template ID. For more information about how to create a snapshot template, see [AddVodTemplate](~~99406~~).
        /// *   If you set the SnapshotTemplateId parameter, all the other request parameters except the Action and VideoId parameters are ignored.
        /// </summary>
        [NameInMap("SnapshotTemplateId")]
        [Validation(Required=false)]
        public string SnapshotTemplateId { get; set; }

        /// <summary>
        /// The point in time when the first snapshot is captured.
        /// 
        /// *   Unit: milliseconds.
        /// *   Default value: **0**.
        /// </summary>
        [NameInMap("SpecifiedOffsetTime")]
        [Validation(Required=false)]
        public long? SpecifiedOffsetTime { get; set; }

        /// <summary>
        /// The playback positions at which you want to capture snapshots. Unit: milliseconds. You can specify up to 30 playback positions in a request.
        /// </summary>
        [NameInMap("SpecifiedOffsetTimes")]
        [Validation(Required=false)]
        public List<long?> SpecifiedOffsetTimes { get; set; }

        /// <summary>
        /// The sprite snapshot configuration. If you set this parameter, sprite snapshots are generated. For more information, see [SpriteSnapshotConfig](~~86952~~).
        /// </summary>
        [NameInMap("SpriteSnapshotConfig")]
        [Validation(Required=false)]
        public string SpriteSnapshotConfig { get; set; }

        /// <summary>
        /// The custom configurations including the configuration of transparent data transmission and callback configurations. The value must be a JSON string. For more information, see [UserData](~~86952~~).
        /// 
        /// >  To use the message callback feature, you must specify an HTTP callback URL and the callback events in the ApsaraVideo VOD console. Otherwise, the callback settings do not take effect.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   After you upload a video in the ApsaraVideo VOD console, you can log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com) and choose **Media Files** > **Audio/Video** to view the ID of the video.
        /// *   Obtain the video ID from the response to the [CreateUploadVideo](~~55407~~) operation that you called to obtain the upload URL and credential.
        /// *   Obtain the video ID from the response to the [SearchMedia](~~86044~~) operation that you called to query media information after the audio or video file is uploaded.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// The width of each snapshot. Valid values: `[8,4096]`. By default, the width of the video source is used. Unit: pixels.
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

    }

}
