// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class UpdateHubClusterFeatureRequest : TeaModel {
        [NameInMap("ApiServerEipId")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("EnableArgoCD")]
        [Validation(Required=false)]
        public bool? EnableArgoCD { get; set; }

        [NameInMap("EnableMesh")]
        [Validation(Required=false)]
        public bool? EnableMesh { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PublicApiServerEnabled")]
        [Validation(Required=false)]
        public bool? PublicApiServerEnabled { get; set; }

    }

}
