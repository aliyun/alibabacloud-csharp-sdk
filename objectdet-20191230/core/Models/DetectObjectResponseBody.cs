// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectObjectResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectObjectResponseBodyData Data { get; set; }
        public class DetectObjectResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectObjectResponseBodyDataElements> Elements { get; set; }
            public class DetectObjectResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<int?> Boxes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.266</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chair</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>533</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF97B44-2763-4EAD-8737-FB9F5EE25FE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
