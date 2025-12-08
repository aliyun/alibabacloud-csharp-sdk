// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeActionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeActionResponseBodyData Data { get; set; }
        public class RecognizeActionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeActionResponseBodyDataElements> Elements { get; set; }
            public class RecognizeActionResponseBodyDataElements : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<RecognizeActionResponseBodyDataElementsBoxes> Boxes { get; set; }
                public class RecognizeActionResponseBodyDataElementsBoxes : TeaModel {
                    [NameInMap("Box")]
                    [Validation(Required=false)]
                    public List<int?> Box { get; set; }

                }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                [NameInMap("Scores")]
                [Validation(Required=false)]
                public List<float?> Scores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public int? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E9C40AF5-A7F8-49D5-8A0C-B21F15A07F17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
