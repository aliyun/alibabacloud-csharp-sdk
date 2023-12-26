// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class GetOpenNLURequest : TeaModel {
        [NameInMap("Examples")]
        [Validation(Required=false)]
        public string Examples { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Sentence")]
        [Validation(Required=false)]
        public string Sentence { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

    }

}
