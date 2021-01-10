// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchDeleteAKSClusterNodeRequest : TeaModel {
        [NameInMap("DestroyComputer")]
        [Validation(Required=false)]
        public bool? DestroyComputer { get; set; }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<BatchDeleteAKSClusterNodeRequestNodes> Nodes { get; set; }
        public class BatchDeleteAKSClusterNodeRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
