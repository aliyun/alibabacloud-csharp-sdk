// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodePool : TeaModel {
        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public AckNodePoolNodeSelector NodeSelector { get; set; }
        public class AckNodePoolNodeSelector : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<AckNodePoolNodeSelectorLabels> Labels { get; set; }
            public class AckNodePoolNodeSelectorLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Taints")]
            [Validation(Required=false)]
            public List<AckNodePoolNodeSelectorTaints> Taints { get; set; }
            public class AckNodePoolNodeSelectorTaints : TeaModel {
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
