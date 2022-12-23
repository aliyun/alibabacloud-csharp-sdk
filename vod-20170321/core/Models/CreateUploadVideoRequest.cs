// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The category ID of the audio or video file. You can use one of the following methods to obtain the category ID:
        /// 
        /// * Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. On the Categories page, you can view the category ID.
        /// * View the value of the CateId parameter returned by the [AddCategory](~~56401~~) operation that you called to create a category.
        /// * View the value of the CateId parameter returned by the [GetCategories](~~56406~~) operation that you called to query a category.
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
        /// * The description can be up to 1,024 characters in length.
        /// * The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the audio or video file.
        /// 
        /// * The name must contain a file name extension, which is not case-sensitive.
        /// * For more information about file name extensions supported by ApsaraVideo VOD, see [Overview](~~55396~~).
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The size of the audio or video file. Unit: byte.
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// The storage location. You can use one of the following methods to obtain the storage location:
        /// 
        /// Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, you can view the storage location.
        /// 
        /// > If this parameter is set to a specific value, the audio or video file is uploaded to the specified storage location.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The one or more tags of the audio or video file.
        /// 
        /// * You can specify a maximum of 16 tags.
        /// * If you need to specify multiple tags, separate the tags with commas (,).
        /// * Each tag can be up to 32 characters in length.
        /// * The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. You can use one of the following methods to obtain the ID of the transcoding template group:
        /// 
        /// * Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Transcoding Template Groups**. On the Transcoding Template Groups page, you can view the ID of the transcoding template group.
        /// * View the value of the TranscodeTemplateGroupId parameter returned by the [AddTranscodeTemplateGroup](~~102665~~) operation that you called to create a transcoding template group.
        /// * View the value of the TranscodeTemplateGroupId parameter returned by the [ListTranscodeTemplateGroup](~~102669~~) operation that you called to query a transcoding template group.
        /// 
        /// > If you leave this parameter empty, the default transcoding template group is used for transcoding. If you set this parameter to the ID of a specific transcoding template group, the specified transcoding template group is used for transcoding.
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The title of the audio or video file.
        /// 
        /// * The title can be up to 128 characters in length.
        /// * The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations, including callback configurations and upload acceleration configurations. The value is a JSON string. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
        /// 
        /// > * The callback configurations take effect only after you specify the HTTP callback URL and select the specific callback events in the ApsaraVideo VOD console. For more information about how to configure an HTTP callback in the ApsaraVideo VOD console, see [Configure callback settings](~~86071~~).
        /// > * To use the upload acceleration feature, submit a [ticket](https://ticket-intl.console.aliyun.com/#/ticket/createIndex) to enable this feature. For more information, see [Overview](~~55396~~).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the workflow. To view the ID of the workflow, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Workflows**.
        /// 
        /// > If both the WorkflowId and TemplateGroupId parameters are set, the value of the WorkflowId parameter takes effect. For more information, see [Workflows](~~115347~~).
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
