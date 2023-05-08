// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class AddClusterIntoServiceMeshRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 添加集群时不检查目标集群是否存在istio-system namespace，一般用于自建istio 迁移ASM 场景
        /// </summary>
        [NameInMap("IgnoreNamespaceCheck")]
        [Validation(Required=false)]
        public bool? IgnoreNamespaceCheck { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
