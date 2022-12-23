// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the media asset.
        /// </summary>
        [NameInMap("AttachedMediaList")]
        [Validation(Required=false)]
        public List<GetAttachedMediaInfoResponseBodyAttachedMediaList> AttachedMediaList { get; set; }
        public class GetAttachedMediaInfoResponseBodyAttachedMediaList : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The list of categories.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<GetAttachedMediaInfoResponseBodyAttachedMediaListCategories> Categories { get; set; }
            public class GetAttachedMediaInfoResponseBodyAttachedMediaListCategories : TeaModel {
                /// <summary>
                /// The ID of the video category.
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// The name of the category.
                /// - The value can be up to 64 bytes in length.
                /// - The string must be encoded in the UTF-8 format.
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// The level of the category. A value of 0 indicates a level 1 category.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// The ID of the parent category. The parent category ID of a level 1 category is -1.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// The time when the auxiliary media asset was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the auxiliary media asset.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the auxiliary media asset.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The time when the auxiliary media asset was updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The status of the auxiliary media asset. Valid values:
            /// - **Uploading**: The auxiliary media asset is being uploaded. This is the initial status.
            /// - **Normal**: The auxiliary media asset is uploaded.
            /// - **UploadFail**: The auxiliary media asset fails to be uploaded.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The OSS bucket where the auxiliary media asset is stored.
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// The tags of the auxiliary media asset.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The title of the auxiliary media asset.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The type of the auxiliary media asset. Valid values:
            /// - **watermark**
            /// - **subtitle**
            /// - **material**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The URL of the auxiliary media asset.
            /// > If a CDN domain name is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// The IDs of the auxiliary media assets that do not exist.
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
