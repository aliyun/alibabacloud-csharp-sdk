// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// The materials.
        /// </summary>
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public List<AddEditingProjectMaterialsResponseBodyMaterialList> MaterialList { get; set; }
        public class AddEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            /// <summary>
            /// The ID of the category.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public int? CateId { get; set; }

            /// <summary>
            /// The category name of the material.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The thumbnail URL.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the material was created. The time follows the ISO 8601 standard in the *YYYY-MM-DD**Thh:mm:ss* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

            /// <summary>
            /// The description of the material.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the material. Unit: seconds. The value is accurate to four decimal places.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// The ID of the material.
            /// </summary>
            [NameInMap("MaterialId")]
            [Validation(Required=false)]
            public string MaterialId { get; set; }

            /// <summary>
            /// The type of the material. Valid values:
            /// 
            /// *   **video**
            /// *   **audio**
            /// *   **image**
            /// </summary>
            [NameInMap("MaterialType")]
            [Validation(Required=false)]
            public string MaterialType { get; set; }

            /// <summary>
            /// The time when the material was last updated. The time follows the ISO 8601 standard in the *YYYY-MM-DD**Thh:mm:ss* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The size of the material.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The URLs of snapshots.
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// The configuration of the sprite snapshot.
            /// </summary>
            [NameInMap("SpriteConfig")]
            [Validation(Required=false)]
            public string SpriteConfig { get; set; }

            /// <summary>
            /// The URLs of sprite snapshots.
            /// </summary>
            [NameInMap("Sprites")]
            [Validation(Required=false)]
            public List<string> Sprites { get; set; }

            /// <summary>
            /// The status of the material. Valid values:
            /// 
            /// *   **Normal**
            /// *   **Uploading**
            /// *   **UploadFail**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag of the material. Multiple tags are separated by commas (,).
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The title of the material.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
