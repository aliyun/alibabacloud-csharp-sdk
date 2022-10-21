/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNode : TeaModel {
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public AckNodeNodeSelector NodeSelector { get; set; }
        public class AckNodeNodeSelector : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<AckNodeNodeSelectorLabels> Labels { get; set; }
            public class AckNodeNodeSelectorLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Taints")]
            [Validation(Required=false)]
            public List<AckNodeNodeSelectorTaints> Taints { get; set; }
            public class AckNodeNodeSelectorTaints : TeaModel {
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

}
