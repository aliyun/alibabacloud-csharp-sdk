// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateRealisticPortraitRequest : TeaModel {
        [NameInMap("ages")]
        [Validation(Required=false)]
        public List<int?> Ages { get; set; }

        [NameInMap("cloth")]
        [Validation(Required=false)]
        public int? Cloth { get; set; }

        [NameInMap("color")]
        [Validation(Required=false)]
        public int? Color { get; set; }

        [NameInMap("custom")]
        [Validation(Required=false)]
        public string Custom { get; set; }

        [NameInMap("face")]
        [Validation(Required=false)]
        public List<int?> Face { get; set; }

        [NameInMap("figure")]
        [Validation(Required=false)]
        public int? Figure { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public int? Gender { get; set; }

        [NameInMap("hairColor")]
        [Validation(Required=false)]
        public int? HairColor { get; set; }

        [NameInMap("hairstyle")]
        [Validation(Required=false)]
        public int? Hairstyle { get; set; }

        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("numbers")]
        [Validation(Required=false)]
        public int? Numbers { get; set; }

        [NameInMap("ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
