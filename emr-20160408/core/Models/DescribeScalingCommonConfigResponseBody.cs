// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeScalingCommonConfigResponseBody : TeaModel {
        [NameInMap("AutoScalingConfigDecommissionQueryInterval")]
        [Validation(Required=false)]
        public long? AutoScalingConfigDecommissionQueryInterval { get; set; }

        [NameInMap("AutoScalingConfigSystemDiskSize")]
        [Validation(Required=false)]
        public int? AutoScalingConfigSystemDiskSize { get; set; }

        [NameInMap("AutoScalingCoolDownTime")]
        [Validation(Required=false)]
        public int? AutoScalingCoolDownTime { get; set; }

        [NameInMap("AutoScalingGroupMaxSizeLimit")]
        [Validation(Required=false)]
        public int? AutoScalingGroupMaxSizeLimit { get; set; }

        [NameInMap("AutoScalingGroupMinSizeLimit")]
        [Validation(Required=false)]
        public int? AutoScalingGroupMinSizeLimit { get; set; }

        [NameInMap("AutoScalingHookHeartbeatDefaultTime")]
        [Validation(Required=false)]
        public int? AutoScalingHookHeartbeatDefaultTime { get; set; }

        [NameInMap("AutoScalingMNSScalingThreadSleepTime")]
        [Validation(Required=false)]
        public long? AutoScalingMNSScalingThreadSleepTime { get; set; }

        [NameInMap("AutoScalingRuleAlarmDelayLimit")]
        [Validation(Required=false)]
        public int? AutoScalingRuleAlarmDelayLimit { get; set; }

        [NameInMap("AutoScalingRuleAlarmSilentTime")]
        [Validation(Required=false)]
        public int? AutoScalingRuleAlarmSilentTime { get; set; }

        [NameInMap("AutoScalingRuleMinDelayLimit")]
        [Validation(Required=false)]
        public int? AutoScalingRuleMinDelayLimit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
