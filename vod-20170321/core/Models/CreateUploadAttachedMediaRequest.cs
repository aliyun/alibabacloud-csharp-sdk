// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. If you have activated the multi-application service, specify the ID of the application to add the watermark template in the specified application. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The type of the auxiliary media asset. Valid values:
        /// 
        /// *   **watermark**
        /// *   **subtitle**
        /// *   **material**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The ID of the category. Separate multiple IDs with commas (,). You can specify up to five IDs. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories** to view the category ID of the media file.
        /// *   Obtain the category ID from the response to the [AddCategory](~~AddCategory~~) operation that you call to create a category.
        /// *   Obtain the category ID from the response to the [GetCategories](~~GetCategories~~) operation that you call to query categories.
        /// </summary>
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        /// <summary>
        /// The description of the auxiliary media asset. Take note of the following items:
        /// 
        /// *   The description can be up to 1,024 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The source file URL of the auxiliary media asset.
        /// 
        /// >  The file name extension is optional. If the file name extension that you specified for this parameter is different from the value of MediaExt, the value of MediaExt takes effect.
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
        /// The file name extension of the auxiliary media asset.
        /// 
        /// *   Valid values for watermarks: **png, gif, apng, and mov**
        /// *   Valid values for subtitles: **srt, ass, stl, ttml, and vtt**
        /// *   Valid values for materials: **jpg, gif, png, mp4, mat, zip, and apk**
        /// </summary>
        [NameInMap("MediaExt")]
        [Validation(Required=false)]
        public string MediaExt { get; set; }

        /// <summary>
        /// The storage address. Perform the following operations to obtain the storage address:
        /// 
        /// Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, view the storage address.
        /// 
        /// >  If you leave this parameter empty, the auxiliary media asset is uploaded to the default storage address. If you specify this parameter, the auxiliary media asset is uploaded to the specified storage address.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The one or more tags of the auxiliary media asset. Take note of the following items:
        /// 
        /// *   You can specify a maximum of 16 tags.
        /// *   If you need to specify multiple tags, separate the tags with commas (,).
        /// *   Each tag can be up to 32 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The title of the auxiliary media asset. The following rules apply:
        /// 
        /// *   The title cannot exceed 128 bytes.
        /// *   The title must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations. For example, you can specify callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see [Request parameters](~~86952#section-6fg-qll-v3w~~).
        /// 
        /// > *   The callback configurations take effect only after you specify the HTTP callback URL and select the specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// > *   If you want to enable the upload acceleration feature, submit a ticket. For more information, see [Overview](https://help.aliyun.com/document_detail/55396.html). For more information about how to submit a ticket, see [Contact us](https://help.aliyun.com/document_detail/464625.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
