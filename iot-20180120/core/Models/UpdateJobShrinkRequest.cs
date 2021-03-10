// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateJobShrinkRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("TimeoutConfig")]
        [Validation(Required=false)]
        public string TimeoutConfigShrink { get; set; }

        [NameInMap("RolloutConfig")]
        [Validation(Required=false)]
        public string RolloutConfigShrink { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=true)]
        public string JobId { get; set; }

    }

}
