// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CheckCommercialStatusRequest : TeaModel {
        /// <summary>
        /// The region ID. Default value: cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ARMS sub-service. Valid values:
        /// 
        /// *   apm: Application Monitoring
        /// *   rum: RUM
        /// *   prometheus: Managed Service for Prometheus
        /// *   xtrace: Managed Service for OpenTelemetry
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
