// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class GetPredictResultRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("TraceTag")]
        [Validation(Required=false)]
        public string TraceTag { get; set; }

    }

}
