// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateMarkerRequest : TeaModel {
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        [NameInMap("LabelId")]
        [Validation(Required=false)]
        public string LabelId { get; set; }

        [NameInMap("SampleId")]
        [Validation(Required=false)]
        public string SampleId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("MarkerId")]
        [Validation(Required=false)]
        public string MarkerId { get; set; }

    }

}
