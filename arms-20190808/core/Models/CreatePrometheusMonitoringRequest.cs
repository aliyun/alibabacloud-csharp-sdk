// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusMonitoringRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The monitoring configuration. Specify a YAML string.
        /// </summary>
        [NameInMap("ConfigYaml")]
        [Validation(Required=false)]
        public string ConfigYaml { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The status of the monitoring configuration. Valid values: run and stop. 
        /// When not transmitted, the default value: run.
        /// Probe does not support status, this field set empty.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of the monitoring configuration. 
        /// Valid values for a Prometheus instance for Container Service: ServiceMonitor, PodMonitor, CustomJob, and Probe. 
        /// Valid values for a Prometheus instance for ECS: CustomJob and Probe.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
