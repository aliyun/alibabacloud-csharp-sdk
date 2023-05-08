// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshClustersRequest : TeaModel {
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
