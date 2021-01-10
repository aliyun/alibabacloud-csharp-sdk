// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateAKSNodePackageRequest : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<UpdateAKSNodePackageRequestNodes> Nodes { get; set; }
        public class UpdateAKSNodePackageRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("UpdateVersion")]
        [Validation(Required=false)]
        public string UpdateVersion { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
