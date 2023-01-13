// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateJobShrinkRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JobDocument")]
        [Validation(Required=true)]
        public string JobDocument { get; set; }

        [NameInMap("JobFile")]
        [Validation(Required=false)]
        public string JobFileShrink { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=true)]
        public string JobName { get; set; }

        [NameInMap("RolloutConfig")]
        [Validation(Required=false)]
        public string RolloutConfigShrink { get; set; }

        [NameInMap("ScheduledTime")]
        [Validation(Required=false)]
        public long? ScheduledTime { get; set; }

        [NameInMap("TargetConfig")]
        [Validation(Required=true)]
        public string TargetConfigShrink { get; set; }

        [NameInMap("TimeoutConfig")]
        [Validation(Required=false)]
        public string TimeoutConfigShrink { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
