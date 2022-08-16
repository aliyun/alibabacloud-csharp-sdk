// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Codes : TeaModel {
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
