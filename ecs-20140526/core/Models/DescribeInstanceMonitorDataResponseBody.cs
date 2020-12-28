// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public List<DescribeInstanceMonitorDataResponseBodyMonitorData> MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("CPUCreditBalance")]
            [Validation(Required=false)]
            public float? CPUCreditBalance { get; set; }

            [NameInMap("BPSRead")]
            [Validation(Required=false)]
            public int? BPSRead { get; set; }

            [NameInMap("InternetTX")]
            [Validation(Required=false)]
            public int? InternetTX { get; set; }

            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            [NameInMap("CPUCreditUsage")]
            [Validation(Required=false)]
            public float? CPUCreditUsage { get; set; }

            [NameInMap("IOPSWrite")]
            [Validation(Required=false)]
            public int? IOPSWrite { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IntranetTX")]
            [Validation(Required=false)]
            public int? IntranetTX { get; set; }

            [NameInMap("BPSWrite")]
            [Validation(Required=false)]
            public int? BPSWrite { get; set; }

            [NameInMap("CPUNotpaidSurplusCreditUsage")]
            [Validation(Required=false)]
            public float? CPUNotpaidSurplusCreditUsage { get; set; }

            [NameInMap("IOPSRead")]
            [Validation(Required=false)]
            public int? IOPSRead { get; set; }

            [NameInMap("CPUAdvanceCreditBalance")]
            [Validation(Required=false)]
            public float? CPUAdvanceCreditBalance { get; set; }

            [NameInMap("InternetBandwidth")]
            [Validation(Required=false)]
            public int? InternetBandwidth { get; set; }

            [NameInMap("InternetRX")]
            [Validation(Required=false)]
            public int? InternetRX { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("IntranetRX")]
            [Validation(Required=false)]
            public int? IntranetRX { get; set; }

            [NameInMap("IntranetBandwidth")]
            [Validation(Required=false)]
            public int? IntranetBandwidth { get; set; }

        }

    }

}
