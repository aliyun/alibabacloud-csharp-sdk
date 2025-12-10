// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListNodeOutputsResponseBody : TeaModel {
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ListNodeOutputsResponseBodyOutputs> Outputs { get; set; }
        public class ListNodeOutputsResponseBodyOutputs : TeaModel {
            [NameInMap("AlgoName")]
            [Validation(Required=false)]
            public string AlgoName { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxComputeTable</para>
            /// </summary>
            [NameInMap("LocationType")]
            [Validation(Required=false)]
            public string LocationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>outputModel</para>
            /// </summary>
            [NameInMap("OutputId")]
            [Validation(Required=false)]
            public string OutputId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutputIndex")]
            [Validation(Required=false)]
            public string OutputIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Model</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///    &quot;table&quot;: &quot;table_name&quot;,
            ///    &quot;locationType&quot;: &quot;MaxComputeTable&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public Dictionary<string, object> Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
