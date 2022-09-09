/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class JobStatusDetailValue : TeaModel {
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("timeStamps")]
        [Validation(Required=false)]
        public string TimeStamps { get; set; }

        [NameInMap("jobResult")]
        [Validation(Required=false)]
        public string JobResult { get; set; }

    }

}
