// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public GetEditingProjectMaterialsResponseBodyMaterialList MaterialList { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            [NameInMap("Material")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMaterialListMaterial> Material { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMaterialListMaterial : TeaModel {
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public int? CateId { get; set; }

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

                [NameInMap("MaterialType")]
                [Validation(Required=false)]
                public string MaterialType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots Snapshots { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SpriteConfig")]
                [Validation(Required=false)]
                public string SpriteConfig { get; set; }

                [NameInMap("Sprites")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites Sprites { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites : TeaModel {
                    [NameInMap("Sprite")]
                    [Validation(Required=false)]
                    public List<string> Sprite { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
