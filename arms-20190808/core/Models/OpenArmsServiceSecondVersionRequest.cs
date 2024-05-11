// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class OpenArmsServiceSecondVersionRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the service. Valid values:
        /// 
        /// *   `arms`: ARMS
        /// *   `arms_app`: Application Monitoring
        /// *   `arms_web`: Browser Monitoring
        /// *   `prometheus_monitor`: Managed Service for Prometheus
        /// *   `synthetic_post`: Synthetic Monitoring
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
