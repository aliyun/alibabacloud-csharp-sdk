// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeReusableSlbRequest : TeaModel {
        /// <summary>
        /// The ID of the Kubernetes cluster on the data plane.
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// The network type of the SLB instance. Valid values:
        /// 
        /// *   `intranet`
        /// *   `internet`
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
