// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeScalingActivityResponseBody : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExpectNum")]
        [Validation(Required=false)]
        public int? ExpectNum { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingRuleId")]
        [Validation(Required=false)]
        public string ScalingRuleId { get; set; }

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
