// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The type of the media asset. Valid values:
        /// *   **watermark**
        /// *   **subtitle**
        /// *   **material**
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The one or more category IDs of the auxiliary media asset. Separate multiple category IDs with commas (,). A maximum of five category IDs can be specified. You can use one of the following methods to obtain the category ID:
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. On the Categories page, you can view the category ID.
        /// *   View the value of the CateId parameter returned by the [AddCategory](~~56401~~) operation that you called to create a category.
        /// *   View the value of the CateId parameter returned by the [GetCategories](~~56406~~) operation that you called to query a category.
        /// </summary>
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        /// <summary>
        /// The description of the auxiliary media asset. Take note of the following items:
        /// *   The description can be up to 1,024 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the source file.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The size of the auxiliary media asset. Unit: byte.
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public string FileSize { get; set; }

        /// <summary>
        /// The file name extension. Valid values:
        /// *   Valid values for watermarks: **png, gif, apng, and mov**
        /// *   Valid values for subtitles: **srt, ass, stl, ttml, and vtt**
        /// *   Valid values for materials: **jpg, gif, png, mp4, mat, and zip**
        /// </summary>
        [NameInMap("MediaExt")]
        [Validation(Required=false)]
        public string MediaExt { get; set; }

        /// <summary>
        /// The storage location. You can use one of the following methods to obtain the storage location:
        /// 
        /// Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, you can view the storage location.
        /// > If this parameter is set to a specific value, the auxiliary media asset is uploaded to the specified storage location.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The one or more tags of the auxiliary media asset. Take note of the following items:
        /// *   You can specify a maximum of 16 tags.
        /// *   If you need to specify multiple tags, separate the tags with commas (,).
        /// *   Each tag can be up to 32 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The title of the media asset. Take note of the following items:
        /// *   The title can be up to 128 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations, including callback configurations and upload acceleration configurations. The value is a JSON string. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
        /// > *   The callback configurations take effect only after you specify the HTTP callback URL and select the specific callback events in the ApsaraVideo VOD console. For more information about how to configure an HTTP callback in the ApsaraVideo VOD console, see [Configure callback settings](~~86071~~).
        /// > *   To use the upload acceleration feature, submit a [ticket](https://ticket-intl.console.aliyun.com/#/ticket/createIndex) to enable this feature. For more information, see [Overview](~~55396~~).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
