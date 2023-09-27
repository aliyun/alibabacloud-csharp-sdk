// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStatusRunning : TeaModel {
        [NameInMap("observedFlinkJobRestarts")]
        [Validation(Required=false)]
        public long? ObservedFlinkJobRestarts { get; set; }

        [NameInMap("observedFlinkJobStatus")]
        [Validation(Required=false)]
        public string ObservedFlinkJobStatus { get; set; }

    }

}
