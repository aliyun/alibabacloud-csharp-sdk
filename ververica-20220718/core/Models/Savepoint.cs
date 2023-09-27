// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Savepoint : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("nativeFormat")]
        [Validation(Required=false)]
        public bool? NativeFormat { get; set; }

        [NameInMap("savepointId")]
        [Validation(Required=false)]
        public string SavepointId { get; set; }

        [NameInMap("savepointLocation")]
        [Validation(Required=false)]
        public string SavepointLocation { get; set; }

        [NameInMap("savepointOrigin")]
        [Validation(Required=false)]
        public string SavepointOrigin { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public SavepointStatus Status { get; set; }

        [NameInMap("stopWithDrainEnabled")]
        [Validation(Required=false)]
        public bool? StopWithDrainEnabled { get; set; }

    }

}
