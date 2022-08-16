// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficeWatermark : TeaModel {
        [NameInMap("FillStyle")]
        [Validation(Required=false)]
        public string FillStyle { get; set; }

        [NameInMap("Font")]
        [Validation(Required=false)]
        public string Font { get; set; }

        [NameInMap("Horizontal")]
        [Validation(Required=false)]
        public long? Horizontal { get; set; }

        [NameInMap("Rotate")]
        [Validation(Required=false)]
        public float? Rotate { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public long? Vertical { get; set; }

    }

}
