// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddAKSNodeLabelRequest : TeaModel {
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AddAKSNodeLabelRequestLabels> Labels { get; set; }
        public class AddAKSNodeLabelRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<AddAKSNodeLabelRequestNodes> Nodes { get; set; }
        public class AddAKSNodeLabelRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
