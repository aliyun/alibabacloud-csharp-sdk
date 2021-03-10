// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateJobRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("JobDocument")]
        [Validation(Required=true)]
        public string JobDocument { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("JobFile")]
        [Validation(Required=false)]
        public Dictionary<string, object> JobFile { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=true)]
        public string JobName { get; set; }

        [NameInMap("TimeoutConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> TimeoutConfig { get; set; }

        [NameInMap("RolloutConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> RolloutConfig { get; set; }

        [NameInMap("TargetConfig")]
        [Validation(Required=true)]
        public Dictionary<string, object> TargetConfig { get; set; }

    }

}
