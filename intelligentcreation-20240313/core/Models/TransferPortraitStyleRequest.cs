// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class TransferPortraitStyleRequest : TeaModel {
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("numbers")]
        [Validation(Required=false)]
        public int? Numbers { get; set; }

        [NameInMap("redrawAmplitude")]
        [Validation(Required=false)]
        public int? RedrawAmplitude { get; set; }

        [NameInMap("style")]
        [Validation(Required=false)]
        public int? Style { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
