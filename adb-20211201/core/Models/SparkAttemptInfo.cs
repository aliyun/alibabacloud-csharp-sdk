// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAttemptInfo : TeaModel {
        [NameInMap("AttemptId")]
        [Validation(Required=false)]
        public string AttemptId { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Detail Detail { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
