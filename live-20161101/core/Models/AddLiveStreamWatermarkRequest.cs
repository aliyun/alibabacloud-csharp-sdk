// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamWatermarkRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OffsetCorner")]
        [Validation(Required=false)]
        public string OffsetCorner { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        [NameInMap("RefHeight")]
        [Validation(Required=false)]
        public int? RefHeight { get; set; }

        [NameInMap("RefWidth")]
        [Validation(Required=false)]
        public int? RefWidth { get; set; }

        [NameInMap("Transparency")]
        [Validation(Required=false)]
        public int? Transparency { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("XOffset")]
        [Validation(Required=false)]
        public float? XOffset { get; set; }

        [NameInMap("YOffset")]
        [Validation(Required=false)]
        public float? YOffset { get; set; }

    }

}
