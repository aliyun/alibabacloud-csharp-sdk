// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusMonitoringStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the monitoring configuration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitoringName")]
        [Validation(Required=false)]
        public string MonitoringName { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The status of the monitoring configuration. Valid values: run and stop. The status of Probe cannot be modified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the monitoring configuration. 
        /// Valid values for a Prometheus instance for Container Service: serviceMonitor, podMonitor, and customJob. 
        /// Valid value for a Prometheus instance for ECS: customJob. 
        /// The status of probe cannot be modified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
