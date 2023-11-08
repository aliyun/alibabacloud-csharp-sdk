// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeMeshVersionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform a precheck. Default value: false. If this parameter is set to true, this call only checks whether the current ASM instance meets the upgrade conditions and does not actually perform an upgrade.
        /// </summary>
        [NameInMap("PreCheck")]
        [Validation(Required=false)]
        public bool? PreCheck { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
