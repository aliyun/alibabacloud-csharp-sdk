// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the category. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories** to view the category ID of the media file.
        /// *   Obtain the value of CateId from the response to the [AddCategory](~~AddCategory~~) operation.
        /// *   Obtain the value of CateId from the response to the [GetCategories](~~GetCategories~~) operation.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The URL of the custom video thumbnail.
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the audio or video file.
        /// 
        /// *   The value can be up to 1,024 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the source file.
        /// 
        /// *   The name must contain a file name extension, which is not case-sensitive.
        /// *   For more information about file name extensions supported by ApsaraVideo VOD, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The size of the source file. Unit: bytes.
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// The storage address. Perform the following operations to obtain the storage address: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, view the storage address.
        /// 
        /// >  If you leave this parameter empty, audio and video files are uploaded to the default storage address. If you specify a storage address, audio and video files are uploaded to the specified address.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The tags of the audio or video file.
        /// 
        /// *   You can specify a maximum of 16 tags.
        /// *   If you want to specify multiple tags, separate the tags with commas (,).
        /// *   Each tag can be up to 32 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose Configuration Management > Media Processing > Transcoding Template Groups. On the Transcoding Template Groups page, you can view the ID of the transcoding template group.[](https://vod.console.aliyun.com)************
        /// *   Obtain the value of the TranscodeTemplateGroupId parameter from the response to the [AddTranscodeTemplateGroup](https://help.aliyun.com/document_detail/102665.html) operation that you called to create a transcoding template group.
        /// *   Obtain the value of the TranscodeTemplateGroupId parameter from the response to the [ListTranscodeTemplateGroup](https://help.aliyun.com/document_detail/102669.html) operation that you called to query transcoding template groups.
        /// 
        /// > *   If you specify both WorkflowId and TemplateGroupId, the value of the WorkflowId parameter takes effect.
        /// > *   If this parameter is not specified, transcoding is performed based on the default transcoding template group. If the transcoding template group ID is specified, transcoding is performed based on the specified template group.
        /// > *   If the **No Transcoding** template group is used, only the [FileUploadComplete](https://help.aliyun.com/document_detail/55630.html) event notification is returned after a video is uploaded. The [StreamTranscodeComplete](https://help.aliyun.com/document_detail/55636.html) event notification is not returned.
        /// > *   If you use the **No Transcoding** template group to upload videos, only videos in the format of MP4, FLV, MP3, M3U8, or WebM can be played. Videos in other formats can only be stored in ApsaraVideo VOD. You can view the file name extension to obtain the video format. If you want to use ApsaraVideo Player, make sure that the version of the player is V3.1.0 or later.
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The title of the audio or video file.
        /// 
        /// *   The title can be up to 128 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations such as callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see [Request parameters](https://help.aliyun.com/document_detail/86952.html).
        /// 
        /// > *   The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// >*   If you want to enable the upload acceleration feature, [submit a request on Yida](https://yida.alibaba-inc.com/o/ticketapply). For more information, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the workflow. To view the ID of the workflow, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Workflows**.
        /// 
        /// > If you specify the WorkflowId and TemplateGroupId parameters, the value of the WorkflowId parameter takes effect. For more information, see [Workflows](https://help.aliyun.com/document_detail/115347.html).
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
