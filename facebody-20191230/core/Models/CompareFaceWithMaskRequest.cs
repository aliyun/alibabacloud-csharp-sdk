// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceWithMaskRequest : TeaModel {
        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public string ImageURLA { get; set; }

        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public string ImageURLB { get; set; }

        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
