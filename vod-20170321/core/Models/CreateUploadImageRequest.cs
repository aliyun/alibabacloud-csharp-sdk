// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The category ID of the image. You can use one of the following methods to obtain the category ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. On the Categories page, you can view the category ID of the image.
        /// *   Obtain the value of CateId from the response to the [AddCategory](~~56401~~) operation.
        /// *   Obtain the value of CateId from the response to the [GetCategories](~~56406~~) operation.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The description of the image.
        /// 
        /// *   The description can be up to 1,024 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The file name extension of the image. Default value: png. Valid values:
        /// 
        /// *   **png**
        /// *   **jpg**
        /// *   **jpeg**
        /// *   **gif**
        /// </summary>
        [NameInMap("ImageExt")]
        [Validation(Required=false)]
        public string ImageExt { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   **default**: the default image type.
        /// *   **cover**: the thumbnail.
        /// 
        /// > Only images of the **default** type can be managed in the ApsaraVideo VOD console.
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("OriginalFileName")]
        [Validation(Required=false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// The storage location. Perform the following operations to obtain the storage location:
        /// 
        /// Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, view the storage location.
        /// 
        /// > If you specify a storage location, video files are uploaded to the specified location.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The tags of the image. Take note of the following items:
        /// 
        /// *   Each tag can be up to 32 characters in length.
        /// *   You can specify a maximum of 16 tags for an image.
        /// *   Separate multiple tags with commas (,).
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The title of the image. Take note of the following items:
        /// 
        /// *   The title can be up to 128 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations. For example, you can specify callback configurations and upload acceleration configurations. The value is a JSON string. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
        /// 
        /// > *   The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](~~86071~~).
        /// > *   To use the upload acceleration feature, submit a [ticket](https://ticket-intl.console.aliyun.com/#/ticket/createIndex) to enable this feature. For more information, see [Overview](~~55396~~).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
