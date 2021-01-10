// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateAKSNodeLabelRequest : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateAKSNodeLabelRequestLabels> Labels { get; set; }
        public class UpdateAKSNodeLabelRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Node")]
        [Validation(Required=false)]
        public string Node { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
