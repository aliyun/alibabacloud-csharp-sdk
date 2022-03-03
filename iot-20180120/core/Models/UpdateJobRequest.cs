// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateJobRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("RolloutConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> RolloutConfig { get; set; }

        [NameInMap("TimeoutConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> TimeoutConfig { get; set; }

    }

}
