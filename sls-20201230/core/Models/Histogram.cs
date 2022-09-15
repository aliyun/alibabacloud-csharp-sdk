// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Histogram : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
