// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// The materials.
        /// </summary>
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public GetEditingProjectMaterialsResponseBodyMaterialList MaterialList { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            [NameInMap("Material")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMaterialListMaterial> Material { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMaterialListMaterial : TeaModel {
                /// <summary>
                /// The category ID of the material.
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
                /// The thumbnail URL of the material.
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The time when the material was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the material.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The duration of the material. The value is rounded to four decimal places. Unit: seconds.
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
                /// The time when the material was last updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The size of the mezzanine file. Unit: byte.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The URLs of material snapshots. The value is an array.
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots Snapshots { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }

                /// <summary>
                /// The source of the sprite.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The configuration of the sprite.
                /// </summary>
                [NameInMap("SpriteConfig")]
                [Validation(Required=false)]
                public string SpriteConfig { get; set; }

                /// <summary>
                /// The URLs of material sprites. The value is an array.
                /// </summary>
                [NameInMap("Sprites")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites Sprites { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites : TeaModel {
                    [NameInMap("Sprite")]
                    [Validation(Required=false)]
                    public List<string> Sprite { get; set; }

                }

                /// <summary>
                /// The status of the material. Valid values:
                /// 
                /// *   **Normal**: The material is in draft.
                /// *   **Producing**: The material is being produced.
                /// *   **Produced**: The material was produced.
                /// *   **ProduceFailed**: The material failed to be produced.
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
