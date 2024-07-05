// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The custom identifier for deduplication. If you specify this parameter and send a request, an error is returned if a request with the same identifier was sent in the last 10 minutes. A custom identifier can be up to 50 characters in length and can contain letters, digits, hyphens (-), and underscores (_). If you do not specify this parameter or leave this parameter empty, duplicate requests are not filtered.
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// The storage address of the media file.
        /// 
        /// To view the storage address, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/?spm=a2c4g.11186623.2.15.6948257eaZ4m54#/vod/settings/censored). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. If you do not specify a storage address, the default storage address is used.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The ID of the transcoding template group. You can use one of the following methods to obtain the ID of the transcoding template group:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Transcoding Template Groups**. On the Transcoding Template Groups page, view the ID of the transcoding template group.
        /// *   Obtain the value of TranscodeTemplateGroupId from the response to the [AddTranscodeTemplateGroup](https://help.aliyun.com/document_detail/102665.html) operation.
        /// *   Obtain the value of TranscodeTemplateGroupId from the response to the [ListTranscodeTemplateGroup](https://help.aliyun.com/document_detail/102669.html) operation.
        /// 
        /// >-   If you leave this parameter empty, the default transcoding template group is used for transcoding. If you specify this parameter, the specified transcoding template group is used for transcoding.
        /// >-   You can also specify the ID of the transcoding template group in `UploadMetadatas`. If you specify this parameter and TemplateGroupId in UploadMetadatas, the TemplateGroupId in UploadMetadatas takes effect.
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// The metadata of the media file that you want to upload. The value must be a JSON string.
        /// 
        /// *   This parameter takes effect only if SourceURL matches the URL that you specified for UploadURLs.
        /// *   You must convert the JSON-formatted data such as `[UploadMetadata, UploadMetadata,…]` to a JSON string.
        /// *   For more information, see the **UploadMetadata** table.
        /// </summary>
        [NameInMap("UploadMetadatas")]
        [Validation(Required=false)]
        public string UploadMetadatas { get; set; }

        /// <summary>
        /// The URL of the media file.
        /// 
        /// *   You must include a file name extension in the URL, such as `https://****.mp4`.
        /// 
        ///     *   If the URL does not contain a file name extension, specify a file name extension for `FileExtension` in `UploadMetadatas`.
        ///     *   If you specify `FileExtension` when the URL contains a file name extension, the file name extension that you specified for `FileExtension` takes effect.
        ///     *   For more information about file name extensions supported by ApsaraVideo VOD, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// 
        /// *   URL encoding is required. Separate multiple URLs with commas (,). You can specify a maximum of 20 URLs.
        /// 
        /// *   Special characters may cause upload failures. You must encode URLs before you separate them with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// The custom configurations such as callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see [Request parameters](~~86952#UserData~~).
        /// 
        /// >-   The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// >-   If you want to enable the upload acceleration feature, [submit a request on Yida](https://yida.alibaba-inc.com/o/ticketapply). For more information, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the workflow. To view the ID of the workflow, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Workflows**.
        /// 
        /// > If you specify WorkflowId and TemplateGroupId, the value of WorkflowId takes effect. For more information, see [Workflows](https://help.aliyun.com/document_detail/115347.html).
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
