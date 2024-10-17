// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodeSelector : TeaModel {
        /// <summary>
        /// <para>污点列表。</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AckNodeSelectorLabels> Labels { get; set; }
        public class AckNodeSelectorLabels : TeaModel {
            /// <summary>
            /// <para>标签键。</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>标签值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>污点列表。</para>
        /// </summary>
        [NameInMap("Taints")]
        [Validation(Required=false)]
        public List<AckNodeSelectorTaints> Taints { get; set; }
        public class AckNodeSelectorTaints : TeaModel {
            /// <summary>
            /// <para>污点效果。</para>
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// <para>污点键。</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>污点值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
