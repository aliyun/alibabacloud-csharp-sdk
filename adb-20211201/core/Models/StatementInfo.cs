// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StatementInfo : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CompletedTimeInMills")]
        [Validation(Required=false)]
        public long? CompletedTimeInMills { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("Process")]
        [Validation(Required=false)]
        public float? Process { get; set; }

        [NameInMap("StartedTimeInMills")]
        [Validation(Required=false)]
        public long? StartedTimeInMills { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public string StatementId { get; set; }

    }

}
