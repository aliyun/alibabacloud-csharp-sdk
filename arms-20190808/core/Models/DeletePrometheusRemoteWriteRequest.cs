// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeletePrometheusRemoteWriteRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance. Only a Prometheus instance for Container Service or a Prometheus instance for ECS is supported.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The names of the remote write configuration items that you want to delete. Separate configuration items with commas (,).
        /// </summary>
        [NameInMap("RemoteWriteNames")]
        [Validation(Required=false)]
        public string RemoteWriteNames { get; set; }

    }

}
