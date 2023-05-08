// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ModifyApiServerEipResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("ApiServerEipId")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// The type of the operation. Valid values:
        /// 
        /// *   `UnBindEip`: disassociates an EIP from the API server.
        /// *   `BindEip`: associates an EIP with the API server.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
