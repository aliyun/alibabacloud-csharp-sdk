// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentRestoreStrategy : TeaModel {
        [NameInMap("allowNonRestoredState")]
        [Validation(Required=false)]
        public bool? AllowNonRestoredState { get; set; }

        [NameInMap("jobStartTimeInMs")]
        [Validation(Required=false)]
        public long? JobStartTimeInMs { get; set; }

        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("savepointId")]
        [Validation(Required=false)]
        public string SavepointId { get; set; }

    }

}
