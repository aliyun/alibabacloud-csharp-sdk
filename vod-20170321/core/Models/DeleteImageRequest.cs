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
        /// *   **ImageURL**: Delete the specified image based on the image URL.
        /// *   **ImageId**: Delete the specified image based on the image ID.
        /// *   **VideoId**: Delete the image that is associated with a video ID.
        /// </summary>
        [NameInMap("DeleteImageType")]
        [Validation(Required=false)]
        public string DeleteImageType { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// *   This parameter only takes effect when the **DeleteImageType** parameter is set to **ImageId**. In this case, you must set this parameter.
        /// *   Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// The type of the image. This parameter only takes effect when the **DeleteImageType** parameter is set to **VideoId**. In this case, you must set this parameter. Valid values:
        /// 
        /// *   **CoverSnapshot**: thumbnail snapshot.
        /// *   **NormalSnapshot**: normal snapshot.
        /// *   **SpriteSnapshot**: sprite snapshot.
        /// *   **SpriteOriginSnapshot**: sprite source snapshot.
        /// *   **All**: images of all the preceding types. If this parameter is not set to All, you can specify multiple types and separate them with commas (,).
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// The URL of the image.
        /// 
        /// *   This parameter only takes effect when the **DeleteImageType** parameter is set to **ImageURL**. In this case, you must set this parameter.
        /// *   Encode multiple image URLs and separate them with commas (,).
        /// *   The use of special characters in image URLs may lead to the failure to delete the images. To prevent such failure, you must encode the image URLs before you concatenate them into a string with commas (,).
        /// </summary>
        [NameInMap("ImageURLs")]
        [Validation(Required=false)]
        public string ImageURLs { get; set; }

        /// <summary>
        /// The ID of the video. This parameter only takes effect when the **DeleteImageType** parameter is set to **VideoId**. In this case, you must set this parameter.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
