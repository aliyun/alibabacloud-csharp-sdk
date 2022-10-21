// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingActivity : TeaModel {
        [NameInMap("Cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EssScalingRuleId")]
        [Validation(Required=false)]
        public string EssScalingRuleId { get; set; }

        [NameInMap("ExpectNum")]
        [Validation(Required=false)]
        public int? ExpectNum { get; set; }

        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalCapacity")]
        [Validation(Required=false)]
        public int? TotalCapacity { get; set; }

        [NameInMap("Transition")]
        [Validation(Required=false)]
        public string Transition { get; set; }

    }

}
