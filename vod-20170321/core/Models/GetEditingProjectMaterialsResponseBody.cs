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
                public int? CateId { get; set; }
                public string CateName { get; set; }
                public string CoverURL { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public float? Duration { get; set; }
                public string MaterialId { get; set; }
                public string MaterialType { get; set; }
                public string ModifiedTime { get; set; }
                public long? Size { get; set; }
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots Snapshots { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }
                public string Source { get; set; }
                public string SpriteConfig { get; set; }
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites Sprites { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites : TeaModel {
                    [NameInMap("Sprite")]
                    [Validation(Required=false)]
                    public List<string> Sprite { get; set; }

                }
                public string Status { get; set; }
                public string Tags { get; set; }
                public string Title { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
