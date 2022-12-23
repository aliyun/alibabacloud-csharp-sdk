// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the image.
        /// </summary>
        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public GetImageInfoResponseBodyImageInfo ImageInfo { get; set; }
        public class GetImageInfoResponseBodyImageInfo : TeaModel {
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
            /// The time when the image file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
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
            /// - **CoverSnapshot**: thumbnail snapshot.
            /// - **NormalSnapshot**: normal snapshot.
            /// - **SpriteSnapshot**: sprite snapshot.
            /// - **SpriteOriginSnapshot**: sprite source snapshot.
            /// - **All**: images of all the preceding types. If this parameter is not set to All, you can specify multiple types and separate them with commas (,).
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The information about the image mezzanine file.
            /// </summary>
            [NameInMap("Mezzanine")]
            [Validation(Required=false)]
            public GetImageInfoResponseBodyImageInfoMezzanine Mezzanine { get; set; }
            public class GetImageInfoResponseBodyImageInfoMezzanine : TeaModel {
                /// <summary>
                /// The size of the file. Unit: byte.
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// The OSS URL of the image.
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// The height of the image. Unit: pixel.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// The name of the uploaded file.
                /// </summary>
                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                /// <summary>
                /// The width of the image. Unit: pixel.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// The status of the image. Valid values:
            /// 
            /// - **Uploading**: The image is being uploaded. This is the initial status.
            /// - **Normal**: The image is uploaded.
            /// - **UploadFail**: The image fails to be uploaded.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The OSS bucket where the image is stored.
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// The tag of the image. Multiple tags are separated by commas (,).
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
            /// The URL of the image. If a CDN domain name is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
