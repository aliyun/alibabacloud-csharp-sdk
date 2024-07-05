// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The category ID of the image. You can use one of the following methods to obtain the category ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Categories**. On the Categories page, you can view the category ID of the image.
        /// *   Obtain the value of CateId from the response to the [AddCategory](https://help.aliyun.com/document_detail/56401.html) operation.
        /// *   Obtain the value of CateId from the response to the [GetCategories](https://help.aliyun.com/document_detail/56406.html) operation.
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
        /// The file name extension of the image. Valid values:
        /// 
        /// *   **png** (default)
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
        /// > You can manage only images of the **default** type in the ApsaraVideo VOD console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The name of the source file.
        /// 
        /// > The name must contain a file name extension. The file name extension is not case-sensitive.
        /// </summary>
        [NameInMap("OriginalFileName")]
        [Validation(Required=false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// The storage address. Perform the following operations to obtain the storage address: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, view the storage address.
        /// 
        /// > If you specify a storage address, media files are uploaded to the specified address.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The tags of the image. The following rules apply:
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
        /// The title of the image. The following rules apply:
        /// 
        /// *   The title can be up to 128 characters in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The custom configurations, including callback configurations and upload acceleration configurations. The value must be a JSON string. For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](https://help.aliyun.com/document_detail/86952.html) topic.
        /// 
        /// > *   The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// >*   If you want to enable the upload acceleration feature, [submit a request on Yida](https://yida.alibaba-inc.com/o/ticketapply). For more information, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
