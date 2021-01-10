// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddAKSNodeTaintRequest : TeaModel {
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<AddAKSNodeTaintRequestNodes> Nodes { get; set; }
        public class AddAKSNodeTaintRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

        [NameInMap("Taints")]
        [Validation(Required=false)]
        public List<AddAKSNodeTaintRequestTaints> Taints { get; set; }
        public class AddAKSNodeTaintRequestTaints : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

        }

    }

}
