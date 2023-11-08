// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateControlPlaneLogConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to collect control plane logs to Simple Log Service.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The time to live (TTL) period of the collected logs. Unit: day.
        /// </summary>
        [NameInMap("LogTTLInDay")]
        [Validation(Required=false)]
        public int? LogTTLInDay { get; set; }

        /// <summary>
        /// The name of the Simple Log Service project to which control plane logs are collected.
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// The ID of the Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
