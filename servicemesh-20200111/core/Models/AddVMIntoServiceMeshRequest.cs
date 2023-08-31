// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class AddVMIntoServiceMeshRequest : TeaModel {
        /// <summary>
        /// The ID of the ECS instance.
        /// </summary>
        [NameInMap("EcsId")]
        [Validation(Required=false)]
        public string EcsId { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
