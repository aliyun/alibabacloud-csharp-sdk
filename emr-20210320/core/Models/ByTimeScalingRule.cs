// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ByTimeScalingRule : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("LaunchExpirationTime")]
        [Validation(Required=false)]
        public int? LaunchExpirationTime { get; set; }

        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public long? LaunchTime { get; set; }

        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

    }

}
