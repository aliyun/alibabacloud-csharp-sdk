// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDedicatedClusterMonitorRuleRequest : TeaModel {
        /// <summary>
        /// The alert threshold for CPU utilization. Unit: percentage.
        /// </summary>
        [NameInMap("CpuAlarmThreshold")]
        [Validation(Required=false)]
        public long? CpuAlarmThreshold { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// The alert threshold for disk usage. Unit: percentage.
        /// </summary>
        [NameInMap("DiskAlarmThreshold")]
        [Validation(Required=false)]
        public long? DiskAlarmThreshold { get; set; }

        /// <summary>
        /// The alert threshold for DTS Unit (DU) usage. Unit: percentage.
        /// </summary>
        [NameInMap("DuAlarmThreshold")]
        [Validation(Required=false)]
        public long? DuAlarmThreshold { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The alert threshold for memory usage. Unit: percentage.
        /// </summary>
        [NameInMap("MemAlarmThreshold")]
        [Validation(Required=false)]
        public long? MemAlarmThreshold { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert feature. Valid values:
        /// 
        /// *   **1**: enables the alert feature.
        /// *   **0**: disables the alert feature.
        /// </summary>
        [NameInMap("NoticeSwitch")]
        [Validation(Required=false)]
        public long? NoticeSwitch { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The mobile phone number to which alerts are sent. Separate multiple mobile phone numbers with commas (,).
        /// </summary>
        [NameInMap("Phones")]
        [Validation(Required=false)]
        public string Phones { get; set; }

        /// <summary>
        /// The ID of the region in which the Data Transmission Service (DTS) instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
