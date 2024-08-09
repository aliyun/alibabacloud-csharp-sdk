// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Relation : TeaModel {
        [NameInMap("destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
