// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of the instance.</para>
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
                /// <para>The read bandwidth of the cloud disks (system disk and data disks). Unit: Byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BPSRead")]
                [Validation(Required=false)]
                public int? BPSRead { get; set; }

                /// <summary>
                /// <para>The write bandwidth of the cloud disks (system disk and data disks). Unit: Byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13585</para>
                /// </summary>
                [NameInMap("BPSWrite")]
                [Validation(Required=false)]
                public int? BPSWrite { get; set; }

                /// <summary>
                /// <para>The vCPU utilization of the instance. Unit: percent (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public int? CPU { get; set; }

                /// <summary>
                /// <para>The overdrawn CPU credits of the burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("CPUAdvanceCreditBalance")]
                [Validation(Required=false)]
                public float? CPUAdvanceCreditBalance { get; set; }

                /// <summary>
                /// <para>The total number of CPU credits of the burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("CPUCreditBalance")]
                [Validation(Required=false)]
                public float? CPUCreditBalance { get; set; }

                /// <summary>
                /// <para>The number of CPU credits consumed by the burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("CPUCreditUsage")]
                [Validation(Required=false)]
                public float? CPUCreditUsage { get; set; }

                /// <summary>
                /// <para>The unpaid overdrawn CPU credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CPUNotpaidSurplusCreditUsage")]
                [Validation(Required=false)]
                public float? CPUNotpaidSurplusCreditUsage { get; set; }

                /// <summary>
                /// <para>The number of read I/O operations per second on the cloud disks (system disk and data disks).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// <para>The number of write I/O operations per second on the cloud disks (system disk and data disks).</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1a36962lrhj4****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The public bandwidth of the instance. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InternetBandwidth")]
                [Validation(Required=false)]
                public int? InternetBandwidth { get; set; }

                /// <summary>
                /// <para>The Internet traffic received by the instance during the period that is specified by the <c>Period</c> parameter. The period starts from the point in time that is specified by the <c>TimeStamp</c> parameter. Unit: Kbit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public int? InternetRX { get; set; }

                /// <summary>
                /// <para>The Internet traffic sent by the instance during the period that is specified by the <c>Period</c> parameter. The period starts from the point in time that is specified by the <c>TimeStamp</c> parameter. Unit: Kbit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>343</para>
                /// </summary>
                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public int? InternetTX { get; set; }

                /// <summary>
                /// <para>The internal bandwidth of the instance. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("IntranetBandwidth")]
                [Validation(Required=false)]
                public int? IntranetBandwidth { get; set; }

                /// <summary>
                /// <para>The internal data traffic received by the instance during the period that is specified by the <c>Period</c> parameter. The period starts from the point in time that is specified by the <c>TimeStamp</c> parameter. Unit: Kbit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("IntranetRX")]
                [Validation(Required=false)]
                public int? IntranetRX { get; set; }

                /// <summary>
                /// <para>The internal data traffic sent by the instance during the period that is specified by the <c>Period</c> parameter. The period starts from the point in time that is specified by the <c>TimeStamp</c> parameter. Unit: Kbit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>343</para>
                /// </summary>
                [NameInMap("IntranetTX")]
                [Validation(Required=false)]
                public int? IntranetTX { get; set; }

                /// <summary>
                /// <para>The timestamp of the monitoring data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-10-30T05:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
