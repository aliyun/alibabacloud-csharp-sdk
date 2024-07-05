// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// The method that is used to delete images. Valid values:
        /// 
        /// *   **ImageURL**: deletes images based on URLs.
        /// *   **ImageId**: deletes images based on image IDs.
        /// *   **VideoId**: deletes images associated with a video based on the video ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeleteImageType")]
        [Validation(Required=false)]
        public string DeleteImageType { get; set; }

        /// <summary>
        /// The ID of the image file. You can specify multiple image IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the image ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Media Files** > **Image** to view the image ID. This method is applicable to images that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the ImageId parameter from the response to the [CreateUploadImage](https://help.aliyun.com/document_detail/55619.html) operation.
        /// *   Obtain the value of the ImageId parameter from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload images.
        /// 
        /// > This parameter is required only if you set **DeleteImageType** to **ImageId**.
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// The type of images that you want to delete. The images are associated with the video. This parameter is required only if you set **DeleteImageType** to **VideoId**. Valid values:
        /// 
        /// *   **CoverSnapshot**: thumbnail snapshot.
        /// *   **NormalSnapshot**: normal snapshot.
        /// *   **SpriteSnapshot**: sprite snapshot.
        /// *   **SpriteOriginSnapshot**: sprite source snapshot.
        /// *   **All**: images of all the preceding types. If this parameter is not set to All, you can specify multiple types and separate the types with commas (,).
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The URL of the image. You can obtain the value of ImageURL from the response to the [CreateUploadImage](https://help.aliyun.com/document_detail/55619.html) operation. You can specify multiple URLs. Separate multiple URLs with commas (,).
        /// 
        /// > This parameter is required only if you set **DeleteImageType** to **ImageURL**.
        /// </summary>
        [NameInMap("ImageURLs")]
        [Validation(Required=false)]
        public string ImageURLs { get; set; }

        /// <summary>
        /// The ID of the video file. You can use one of the following methods to obtain the video ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the media file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the VideoId parameter from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation.
        /// *   Obtain the value of the VideoId parameter from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload media files.
        /// 
        /// > This parameter is required only if you set **DeleteImageType** to **VideoId**.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
