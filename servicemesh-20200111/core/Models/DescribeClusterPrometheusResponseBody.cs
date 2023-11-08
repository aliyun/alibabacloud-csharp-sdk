// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterPrometheusResponseBody : TeaModel {
        /// <summary>
        /// The public endpoint of the Prometheus service that is used to monitor a cluster in the ASM instance.
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public string Prometheus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
