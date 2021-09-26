// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeScalingCommonConfigResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// autoScalingHookHeartbeatDefaultTime
        /// </summary>
        [NameInMap("AutoScalingHookHeartbeatDefaultTime")]
        [Validation(Required=false)]
        public long? AutoScalingHookHeartbeatDefaultTime { get; set; }

        [NameInMap("AutoScalingCoolDownTime")]
        [Validation(Required=false)]
        public long? AutoScalingCoolDownTime { get; set; }

        [NameInMap("AutoScalingMNSScalingThreadSleepTime")]
        [Validation(Required=false)]
        public long? AutoScalingMNSScalingThreadSleepTime { get; set; }

        [NameInMap("AutoScalingGroupMinSizeLimit")]
        [Validation(Required=false)]
        public long? AutoScalingGroupMinSizeLimit { get; set; }

        [NameInMap("AutoScalingGroupMaxSizeLimit")]
        [Validation(Required=false)]
        public long? AutoScalingGroupMaxSizeLimit { get; set; }

        [NameInMap("AutoScalingRuleMinDelayLimit")]
        [Validation(Required=false)]
        public long? AutoScalingRuleMinDelayLimit { get; set; }

        [NameInMap("AutoScalingRuleAlarmDelayLimit")]
        [Validation(Required=false)]
        public long? AutoScalingRuleAlarmDelayLimit { get; set; }

        [NameInMap("AutoScalingRuleAlarmSilentTime")]
        [Validation(Required=false)]
        public long? AutoScalingRuleAlarmSilentTime { get; set; }

        [NameInMap("AutoScalingConfigSystemDiskSize")]
        [Validation(Required=false)]
        public long? AutoScalingConfigSystemDiskSize { get; set; }

        [NameInMap("AutoScalingConfigDecommissionQueryInterval")]
        [Validation(Required=false)]
        public long? AutoScalingConfigDecommissionQueryInterval { get; set; }

    }

}
