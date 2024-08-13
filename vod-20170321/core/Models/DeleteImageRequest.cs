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
        /// The ID of the image. You can specify up to 20 image IDs and separate them with commas (,). You can use one of the following methods to obtain the image ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Media Files** > **Image** to view the image ID.
        /// *   Obtain the image ID from the response to the [CreateUploadImage](~~CreateUploadImage~~) operation that you call to obtain the upload credential and URL.
        /// *   Obtain the image ID from the response to the [SearchMedia](~~SearchMedia~~) operation that you call to query images.
        /// 
        /// >  This parameter takes effect and is required only if you set **DeleteImageType** to **ImageId**.
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// The type of images that you want to delete. The images are associated with the video. Valid values:
        /// 
        /// *   **CoverSnapshot**: thumbnail snapshot.
        /// *   **NormalSnapshot**: regular snapshot.
        /// *   **SpriteSnapshot**: sprite snapshot.
        /// *   **SpriteOriginSnapshot**: sprite source snapshot.
        /// *   **All**: images of all the preceding types. You can specify multiple types other than `All` for this parameter. Separate multiple types with commas (,).
        /// 
        /// >  This parameter takes effect and is required only if you set **DeleteImageType** to **VideoId**.
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The URL of the image. You can obtain the value of `ImageURL` from the response to the [CreateUploadImage](~~CreateUploadImage~~) operation. You can specify up to 20 URLs and separate them with commas (,).
        /// 
        /// >  This parameter takes effect and is required only if you set **DeleteImageType** to **ImageURL**.
        /// </summary>
        [NameInMap("ImageURLs")]
        [Validation(Required=false)]
        public string ImageURLs { get; set; }

        /// <summary>
        /// The ID of the video. You can specify only one ID. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the media file.
        /// *   Obtain the video ID from the response to the [CreateUploadVideo](~~CreateUploadVideo~~) operation that you call to obtain the upload credential and URL.
        /// *   Obtain the video ID from the response to the [SearchMedia](~~SearchMedia~~) operation that you call to query videos.
        /// 
        /// >  This parameter takes effect and is required only if you set **DeleteImageType** to **VideoId**.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
