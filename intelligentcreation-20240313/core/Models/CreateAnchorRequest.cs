// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAnchorRequest : TeaModel {
        [NameInMap("anchorCategory")]
        [Validation(Required=false)]
        public string AnchorCategory { get; set; }

        [NameInMap("anchorMaterialName")]
        [Validation(Required=false)]
        public string AnchorMaterialName { get; set; }

        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("digitalHumanType")]
        [Validation(Required=false)]
        public string DigitalHumanType { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        [NameInMap("videoOssKey")]
        [Validation(Required=false)]
        public string VideoOssKey { get; set; }

    }

}
