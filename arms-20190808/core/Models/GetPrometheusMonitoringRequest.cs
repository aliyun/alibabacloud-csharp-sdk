// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusMonitoringRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the monitoring configuration.
        /// </summary>
        [NameInMap("MonitoringName")]
        [Validation(Required=false)]
        public string MonitoringName { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the monitoring configuration. 
        /// Valid values for a Prometheus instance for Container Service: serviceMonitor, podMonitor, customJob, and probe. 
        /// Valid values for a Prometheus instance for ECS: customJob and probe.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
