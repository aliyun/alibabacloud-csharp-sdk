// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateAKSNodeDaemonSetRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<UpdateAKSNodeDaemonSetRequestNodes> Nodes { get; set; }
        public class UpdateAKSNodeDaemonSetRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        [NameInMap("UpdateVersion")]
        [Validation(Required=false)]
        public string UpdateVersion { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
