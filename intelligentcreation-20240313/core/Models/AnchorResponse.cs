// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class AnchorResponse : TeaModel {
        [NameInMap("anchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("anchorMaterialName")]
        [Validation(Required=false)]
        public string AnchorMaterialName { get; set; }

        [NameInMap("anchorType")]
        [Validation(Required=false)]
        public string AnchorType { get; set; }

        [NameInMap("coverHeight")]
        [Validation(Required=false)]
        public int? CoverHeight { get; set; }

        [NameInMap("coverRate")]
        [Validation(Required=false)]
        public string CoverRate { get; set; }

        [NameInMap("coverThumbnailUrl")]
        [Validation(Required=false)]
        public string CoverThumbnailUrl { get; set; }

        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("coverWeight")]
        [Validation(Required=false)]
        public int? CoverWeight { get; set; }

        [NameInMap("digitalHumanType")]
        [Validation(Required=false)]
        public string DigitalHumanType { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("resourceTypeDesc")]
        [Validation(Required=false)]
        public string ResourceTypeDesc { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("supportBgChange")]
        [Validation(Required=false)]
        public int? SupportBgChange { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

    }

}
