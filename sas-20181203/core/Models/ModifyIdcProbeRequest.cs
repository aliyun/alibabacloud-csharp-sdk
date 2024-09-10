// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyIdcProbeRequest : TeaModel {
        /// <summary>
        /// The name of the data center.
        /// </summary>
        [NameInMap("IdcName")]
        [Validation(Required=false)]
        public string IdcName { get; set; }

        /// <summary>
        /// The region ID of the data center.
        /// </summary>
        [NameInMap("IdcRegion")]
        [Validation(Required=false)]
        public string IdcRegion { get; set; }

        /// <summary>
        /// The scan interval.
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// The settings of the CIDR block.
        /// </summary>
        [NameInMap("IpSegments")]
        [Validation(Required=false)]
        public string IpSegments { get; set; }

        /// <summary>
        /// The Linux port.
        /// </summary>
        [NameInMap("LinuxPort")]
        [Validation(Required=false)]
        public string LinuxPort { get; set; }

        /// <summary>
        /// The unit of the scan interval. Valid values:
        /// 
        /// *   **day**
        /// *   **hour**
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The usage status. Valid values:
        /// 
        /// *   **0**: enabled.
        /// *   **1**: disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The UUID of the server. Separate multiple UUIDs with commas (,).
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// The Windows port.
        /// </summary>
        [NameInMap("WinPort")]
        [Validation(Required=false)]
        public string WinPort { get; set; }

    }

}
