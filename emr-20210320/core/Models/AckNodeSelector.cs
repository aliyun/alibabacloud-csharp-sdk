// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodeSelector : TeaModel {
        /// <summary>
        /// 污点列表。
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AckNodeSelectorLabels> Labels { get; set; }
        public class AckNodeSelectorLabels : TeaModel {
            /// <summary>
            /// 标签键。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 污点列表。
        /// </summary>
        [NameInMap("Taints")]
        [Validation(Required=false)]
        public List<AckNodeSelectorTaints> Taints { get; set; }
        public class AckNodeSelectorTaints : TeaModel {
            /// <summary>
            /// 污点效果。
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// 污点键。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 污点值。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
