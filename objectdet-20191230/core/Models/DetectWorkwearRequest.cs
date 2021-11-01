// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWorkwearRequest : TeaModel {
        [NameInMap("Clothes")]
        [Validation(Required=false)]
        public DetectWorkwearRequestClothes Clothes { get; set; }
        public class DetectWorkwearRequestClothes : TeaModel {
            [NameInMap("MaxNum")]
            [Validation(Required=false)]
            public long? MaxNum { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }
        };

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

    }

}
