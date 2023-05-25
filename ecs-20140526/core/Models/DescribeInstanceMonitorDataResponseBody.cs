// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The monitoring data of the instance.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeInstanceMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("InstanceMonitorData")]
            [Validation(Required=false)]
            public List<DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData> InstanceMonitorData { get; set; }
            public class DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData : TeaModel {
                /// <summary>
                /// The read bandwidth of the cloud disks (system disk and data disks). Unit: Byte/s.
                /// </summary>
                [NameInMap("BPSRead")]
                [Validation(Required=false)]
                public int? BPSRead { get; set; }

                /// <summary>
                /// The write bandwidth of the cloud disks (system disk and data disks). Unit: Byte/s.
                /// </summary>
                [NameInMap("BPSWrite")]
                [Validation(Required=false)]
                public int? BPSWrite { get; set; }

                /// <summary>
                /// The vCPU utilization of the instance. Unit: percent (%).
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public int? CPU { get; set; }

                /// <summary>
                /// The overdrawn CPU credits of the burstable instance.
                /// </summary>
                [NameInMap("CPUAdvanceCreditBalance")]
                [Validation(Required=false)]
                public float? CPUAdvanceCreditBalance { get; set; }

                /// <summary>
                /// The total CPU credits of the burstable instance.
                /// </summary>
                [NameInMap("CPUCreditBalance")]
                [Validation(Required=false)]
                public float? CPUCreditBalance { get; set; }

                /// <summary>
                /// The number of CPU credits consumed by the burstable instance.
                /// </summary>
                [NameInMap("CPUCreditUsage")]
                [Validation(Required=false)]
                public float? CPUCreditUsage { get; set; }

                /// <summary>
                /// The unpaid overdrawn CPU credits.
                /// </summary>
                [NameInMap("CPUNotpaidSurplusCreditUsage")]
                [Validation(Required=false)]
                public float? CPUNotpaidSurplusCreditUsage { get; set; }

                /// <summary>
                /// The number of read I/O operations per second on the cloud disks (system disk and data disks).
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// The number of write I/O operations per second on the cloud disks (system disk and data disks).
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The public bandwidth of the instance. Unit: Kbit/s.
                /// </summary>
                [NameInMap("InternetBandwidth")]
                [Validation(Required=false)]
                public int? InternetBandwidth { get; set; }

                /// <summary>
                /// The public data traffic received by the instance during the period that is specified by the `Period` parameter. The period starts from the point in time that is specified by the `TimeStamp` parameter. Unit: Kbit/s.
                /// </summary>
                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public int? InternetRX { get; set; }

                /// <summary>
                /// The public data traffic sent by the instance during the period that is specified by the `Period` parameter. The period starts from the point in time that is specified by the `TimeStamp` parameter. Unit: Kbit/s.
                /// </summary>
                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public int? InternetTX { get; set; }

                /// <summary>
                /// The internal bandwidth of the instance. Unit: Kbit/s.
                /// </summary>
                [NameInMap("IntranetBandwidth")]
                [Validation(Required=false)]
                public int? IntranetBandwidth { get; set; }

                /// <summary>
                /// The internal data traffic received by the instance during the period that is specified by the `Period` parameter. The period starts from the point in time that is specified by the `TimeStamp` parameter. Unit: Kbit/s.
                /// </summary>
                [NameInMap("IntranetRX")]
                [Validation(Required=false)]
                public int? IntranetRX { get; set; }

                /// <summary>
                /// The internal data traffic sent by the instance during the period that is specified by the `Period` parameter. The period starts from the point in time that is specified by the `TimeStamp` parameter. Unit: Kbit/s.
                /// </summary>
                [NameInMap("IntranetTX")]
                [Validation(Required=false)]
                public int? IntranetTX { get; set; }

                /// <summary>
                /// The timestamp of the monitoring data.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
