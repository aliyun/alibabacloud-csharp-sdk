// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteAKSContainerservicesRequest : TeaModel {
        [NameInMap("ContainerServiceName")]
        [Validation(Required=false)]
        public string ContainerServiceName { get; set; }

        [NameInMap("DraftedTime")]
        [Validation(Required=false)]
        public string DraftedTime { get; set; }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
