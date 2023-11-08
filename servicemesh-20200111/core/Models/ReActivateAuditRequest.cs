// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ReActivateAuditRequest : TeaModel {
        /// <summary>
        /// Specifies whether to recreate a project that is used to store audit logs. Valid values:
        /// 
        /// *   true: recreates a project.
        /// *   false: does not recreate a project.
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// The ID of the Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
