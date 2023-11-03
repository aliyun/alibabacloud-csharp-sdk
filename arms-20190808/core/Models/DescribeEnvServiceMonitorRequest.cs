// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvServiceMonitorRequest : TeaModel {
        /// <summary>
        /// The ID of the environment instance.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The namespace where the ServiceMonitor is located.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the ServiceMonitor.
        /// </summary>
        [NameInMap("ServiceMonitorName")]
        [Validation(Required=false)]
        public string ServiceMonitorName { get; set; }

    }

}
