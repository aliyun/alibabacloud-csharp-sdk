// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectMaterialsResponseBody : TeaModel {
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public List<AddEditingProjectMaterialsResponseBodyMaterialList> MaterialList { get; set; }
        public class AddEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public int? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

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

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            [NameInMap("SpriteConfig")]
            [Validation(Required=false)]
            public string SpriteConfig { get; set; }

            [NameInMap("Sprites")]
            [Validation(Required=false)]
            public List<string> Sprites { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
