// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateAKSNodeTaintRequest : TeaModel {
        [NameInMap("Node")]
        [Validation(Required=false)]
        public string Node { get; set; }

        [NameInMap("Taints")]
        [Validation(Required=false)]
        public List<UpdateAKSNodeTaintRequestTaints> Taints { get; set; }
        public class UpdateAKSNodeTaintRequestTaints : TeaModel {
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
