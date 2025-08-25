// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class IntelligentCompositionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public IntelligentCompositionResponseBodyData Data { get; set; }
        public class IntelligentCompositionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<IntelligentCompositionResponseBodyDataElements> Elements { get; set; }
            public class IntelligentCompositionResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>981</para>
                /// </summary>
                [NameInMap("MaxX")]
                [Validation(Required=false)]
                public int? MaxX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>672</para>
                /// </summary>
                [NameInMap("MaxY")]
                [Validation(Required=false)]
                public int? MaxY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("MinX")]
                [Validation(Required=false)]
                public int? MinX { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("MinY")]
                [Validation(Required=false)]
                public int? MinY { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.6567564</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C1D52018-D67A-46AD-9AAA-031750A6E770</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
