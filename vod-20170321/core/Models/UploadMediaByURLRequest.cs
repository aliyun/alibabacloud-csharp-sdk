// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// ## UploadMetadata
        /// 
        /// | Parameter | Type | Required | Description |
        /// | --------- | ---- | -------- | ----------- |
        /// | SourceURL | String | Yes | The URL of the source file to be uploaded. |
        /// | Title | String | Yes | The title of the media file. The title can be up to 128 bytes in length. The value must be encoded in UTF-8. |
        /// | FileSize | String | No | The size of the media file. |
        /// | Description | String | No | The description of the media file. The description can be up to 1,024 bytes in length. The value must be encoded in UTF-8. |
        /// | CoverURL | String | No | The URL of the custom thumbnail of the media file. |
        /// | CateId | String | No | The category ID of the media file. To view the category ID of the media file, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. |
        /// | Tags | String | No | The one or more tags of the media file. Each tag can be up to 32 bytes in length. You can set a maximum of 16 tags. Separate multiple tags with commas (,). The value must be encoded in UTF-8. |
        /// | TemplateGroupId | String | No | The ID of the transcoding template group. If both the request parameter TemplateGroupId and the nested parameter TemplateGroupId are set, the value of the nested parameter takes effect. |
        /// | WorkflowId | String | No | The ID of the workflow. If both the WorkflowId and TemplateGroupId parameters are set, the value of the WorkflowId parameter takes effect. For more information, see [Workflows](https://www.alibabacloud.com/help/en/apsaravideo-for-vod/latest/workflows). |
        /// | FileExtension | String | No | The file name extension of the media file. For more information about file name extensions supported by ApsaraVideo VOD, see [Overview](https://www.alibabacloud.com/help/en/apsaravideo-for-vod/latest/upload-medias-overview). |
        /// > - Do not include emoticons in the nested parameters, such as Title, Description, and Tags, under the UploadMetadata parameter.
        /// - If you set the TemplateGroupId parameter to VOD_NO_TRANSCODE to upload videos, only the videos in the format of MP4, FLV, MP3, M3U8, or WebM can be played. Videos in the other formats are supported only for storage. You can identify the video format based on the file name extension. If you want to use ApsaraVideo Player, the version must be 3.1.0 or later.
        /// - If you set the TemplateGroupId parameter to VOD_NO_TRANSCODE, only the [FileUploadComplete](https://www.alibabacloud.com/help/en/apsaravideo-for-vod/latest/fileuploadcomplete) but not the [StreamTranscodeComplete](https://www.alibabacloud.com/help/en/apsaravideo-for-vod/latest/streamtranscodecomplete) event notification is returned after the media file is uploaded.
        /// - If a callback is configured, ApsaraVideo VOD sends an [UploadByURLComplete](https://www.alibabacloud.com/help/en/apsaravideo-for-vod/latest/uploadbyurlcomplete) event notification after the media file is uploaded, in addition to the FileUploadComplete and StreamTranscodeComplete event notifications.
        /// - If you specify multiple media files at a time, ApsaraVideo VOD sends an event notification for each media file after the media file is uploaded.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The URL of the source file.
        /// * The URL must contain a file name extension, such as mp4 in `https://****.mp4`.
        ///     * If the URL does not contain a file name extension, you can specify one by setting the `FileExtension` parameter under the `UploadMetadatas` parameter.
        ///     * If the URL contains a file name extension and the `FileExtension` parameter is set, the value of the `FileExtension` parameter is used.
        ///     * For more information about file name extensions supported by ApsaraVideo VOD, see [Overview](~~55396~~).
        /// * URL encoding is required. Separate multiple URLs with commas (,). You can specify a maximum of 20 URLs.
        /// * Special characters may cause upload failures. Therefore, encode URLs before you separate them with commas (,).
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The information about one or more upload jobs.
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The metadata of the media file to be uploaded. The value is a JSON string.
        /// * This parameter takes effect only if the value of the SourceURL parameter matches the URL that is specified by the UploadURLs parameter.
        /// * The JSON-formatted data, such as `[UploadMetadata, UploadMetadata,…]`, must be converted into a JSON string.
        /// * For more information, see the **UploadMetadata** section.
        /// </summary>
        [NameInMap("UploadMetadatas")]
        [Validation(Required=false)]
        public string UploadMetadatas { get; set; }

        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// > This operation is used to asynchronously upload media files. Upload jobs are queued for execution after they are submitted. The completion time of an upload job varies with the number of jobs in the queue.
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
