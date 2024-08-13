// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfosResponseBody : TeaModel {
        /// <summary>
        /// The image information.
        /// </summary>
        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public List<GetImageInfosResponseBodyImageInfo> ImageInfo { get; set; }
        public class GetImageInfosResponseBodyImageInfo : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The ID of the category.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The name of the category.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The time when the image was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the image.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of the image. Valid values:
            /// 
            /// *   **default**: regular images
            /// *   **cover**: video thumbnail
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The source information about the image.
            /// </summary>
            [NameInMap("Mezzanine")]
            [Validation(Required=false)]
            public GetImageInfosResponseBodyImageInfoMezzanine Mezzanine { get; set; }
            public class GetImageInfosResponseBodyImageInfoMezzanine : TeaModel {
                /// <summary>
                /// The size of the file to be uploaded. Unit: bytes.
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// The OSS URL of the image file.
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// The height of the image. Unit: pixels.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// The URL of the source file.
                /// </summary>
                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                /// <summary>
                /// The width of the image. Unit: pixels.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// The status of the image file. Valid values:
            /// 
            /// *   **Uploading**: The image is being uploaded. This is the initial status.
            /// *   **Normal**: The image is uploaded.
            /// *   **UploadFail**: The image fails to be uploaded.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The bucket in which the image is stored.
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// The tags of the image. Multiple tags are separated by commas (,).
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The title of the image.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The image URL. If a domain name for CDN is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// The IDs of the images that do not exist.
        /// </summary>
        [NameInMap("NonExistImageIds")]
        [Validation(Required=false)]
        public List<string> NonExistImageIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
