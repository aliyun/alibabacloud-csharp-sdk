// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectPedestrianResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPedestrianResponseBodyData Data { get; set; }
        public class DetectPedestrianResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectPedestrianResponseBodyDataElements> Elements { get; set; }
            public class DetectPedestrianResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<int?> Boxes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.999</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>person</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>599</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>899</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>45DBA494-6250-42C4-80D1-7CF19BDD2CB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
