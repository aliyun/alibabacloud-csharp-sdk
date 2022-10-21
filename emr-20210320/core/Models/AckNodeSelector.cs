// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodeSelector : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AckNodeSelectorLabels> Labels { get; set; }
        public class AckNodeSelectorLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Taints")]
        [Validation(Required=false)]
        public List<AckNodeSelectorTaints> Taints { get; set; }
        public class AckNodeSelectorTaints : TeaModel {
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

    }

}
