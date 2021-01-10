// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportAKSClusterNodeRequest : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ImportAKSClusterNodeRequestNodes> Nodes { get; set; }
        public class ImportAKSClusterNodeRequestNodes : TeaModel {
            [NameInMap("Cell")]
            [Validation(Required=false)]
            public string Cell { get; set; }

            [NameInMap("Node")]
            [Validation(Required=false)]
            public string Node { get; set; }

        }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
