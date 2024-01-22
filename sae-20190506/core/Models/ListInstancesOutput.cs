// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListInstancesOutput : TeaModel {
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<InstanceInfo> Instances { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("versionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, VersionStatus> VersionStatus { get; set; }

    }

}
