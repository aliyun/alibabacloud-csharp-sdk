// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCContainerServiceDeploymentRequest : TeaModel {
        [NameInMap("ContainerServicesJsonStr")]
        [Validation(Required=false)]
        public string ContainerServicesJsonStr { get; set; }

        [NameInMap("IsAutoExecute")]
        [Validation(Required=false)]
        public bool? IsAutoExecute { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("ReleasePlanUniqueId")]
        [Validation(Required=false)]
        public string ReleasePlanUniqueId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
