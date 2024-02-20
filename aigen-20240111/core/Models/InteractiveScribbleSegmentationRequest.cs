// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class InteractiveScribbleSegmentationRequest : TeaModel {
        [NameInMap("EdgeFeathering")]
        [Validation(Required=false)]
        public string EdgeFeathering { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("IntegratedMaskUrl")]
        [Validation(Required=false)]
        public string IntegratedMaskUrl { get; set; }

        [NameInMap("MaskImageUrl")]
        [Validation(Required=false)]
        public string MaskImageUrl { get; set; }

        [NameInMap("NegScribbleImageUrl")]
        [Validation(Required=false)]
        public string NegScribbleImageUrl { get; set; }

        [NameInMap("PosScribbleImageUrl")]
        [Validation(Required=false)]
        public string PosScribbleImageUrl { get; set; }

        [NameInMap("PostprocessOption")]
        [Validation(Required=false)]
        public string PostprocessOption { get; set; }

        [NameInMap("ReturnForm")]
        [Validation(Required=false)]
        public string ReturnForm { get; set; }

        [NameInMap("ReturnFormat")]
        [Validation(Required=false)]
        public string ReturnFormat { get; set; }

    }

}
