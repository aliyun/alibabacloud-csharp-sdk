// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCContainerservicePodRequest : TeaModel {
        [NameInMap("ContainerServiceName")]
        [Validation(Required=false)]
        public string ContainerServiceName { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("WorkspaceGroupName")]
        [Validation(Required=false)]
        public string WorkspaceGroupName { get; set; }

    }

}
