// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class RemoveClusterFromServiceMeshRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 移除集群时，保留istio-system 命名空间
        /// </summary>
        [NameInMap("ReserveNamespace")]
        [Validation(Required=false)]
        public bool? ReserveNamespace { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
