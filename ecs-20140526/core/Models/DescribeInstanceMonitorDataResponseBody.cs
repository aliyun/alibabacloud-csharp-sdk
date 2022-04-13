// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeInstanceMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("InstanceMonitorData")]
            [Validation(Required=false)]
            public List<DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData> InstanceMonitorData { get; set; }
            public class DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData : TeaModel {
                public int? BPSRead { get; set; }
                public int? BPSWrite { get; set; }
                public int? CPU { get; set; }
                public float? CPUAdvanceCreditBalance { get; set; }
                public float? CPUCreditBalance { get; set; }
                public float? CPUCreditUsage { get; set; }
                public float? CPUNotpaidSurplusCreditUsage { get; set; }
                public int? IOPSRead { get; set; }
                public int? IOPSWrite { get; set; }
                public string InstanceId { get; set; }
                public int? InternetBandwidth { get; set; }
                public int? InternetRX { get; set; }
                public int? InternetTX { get; set; }
                public int? IntranetBandwidth { get; set; }
                public int? IntranetRX { get; set; }
                public int? IntranetTX { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
