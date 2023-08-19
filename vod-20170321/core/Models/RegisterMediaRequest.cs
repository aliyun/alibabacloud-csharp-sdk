// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaRequest : TeaModel {
        /// <summary>
        /// The metadata of the media file that you want to register. The value is a JSON string. You can specify the metadata for a maximum of 10 media files at a time. For more information about the metadata of media files, see the **RegisterMetadata** section of this topic.
        /// </summary>
        [NameInMap("RegisterMetadatas")]
        [Validation(Required=false)]
        public string RegisterMetadatas { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. You can use one of the following methods to obtain the ID of the transcoding template group:
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Transcoding Template Groups**. On the Transcoding Template Groups page, you can view the ID of the transcoding template group.
        /// *   View the value of the TranscodeTemplateGroupId parameter returned by the [AddTranscodeTemplateGroup](~~102665~~) operation that you called to create a transcoding template group.
        /// *   View the value of the TranscodeTemplateGroupId parameter returned by the [ListTranscodeTemplateGroup](~~102669~~) operation that you called to query a transcoding template group.
        /// > *   If you do not need to transcode the media file, set the TemplateGroupId parameter to VOD_NO_TRANSCODE. Otherwise, an exception occurs during video playback. If you need to transcode the media file, specify the ID of the transcoding template group.
        /// > *   If both the WorkflowId and TemplateGroupId parameters are set, the value of the WorkflowId parameter takes effect. For more information, see [Workflows](~~115347~~).
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The custom configurations such as callback configurations. The value is a JSON string. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952#section\_6fg_qll_v3w~~) topic.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the workflow. To view the ID of the workflow, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Workflows**.
        /// > If both the WorkflowId and TemplateGroupId parameters are set, the value of the WorkflowId parameter takes effect. For more information, see [Workflows](~~115347~~).
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
