// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusRemoteWriteRequest : TeaModel {
        /// <summary>
        /// The ID of the Prometheus instance.
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
        /// The name of the remote write configuration item.
        /// </summary>
        [NameInMap("RemoteWriteName")]
        [Validation(Required=false)]
        public string RemoteWriteName { get; set; }

        /// <summary>
        /// The remote write configuration. Specify the value in the YAML format.
        /// </summary>
        [NameInMap("RemoteWriteYaml")]
        [Validation(Required=false)]
        public string RemoteWriteYaml { get; set; }

    }

}
