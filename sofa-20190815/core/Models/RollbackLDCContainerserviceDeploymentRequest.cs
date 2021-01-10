// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RollbackLDCContainerserviceDeploymentRequest : TeaModel {
        [NameInMap("ContainerServiceName")]
        [Validation(Required=false)]
        public string ContainerServiceName { get; set; }

        [NameInMap("GroupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        [NameInMap("GroupStrategy")]
        [Validation(Required=false)]
        public string GroupStrategy { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Revision")]
        [Validation(Required=false)]
        public string Revision { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
