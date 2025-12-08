// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectCelebrityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCelebrityResponseBodyData Data { get; set; }
        public class DetectCelebrityResponseBodyData : TeaModel {
            [NameInMap("FaceRecognizeResults")]
            [Validation(Required=false)]
            public List<DetectCelebrityResponseBodyDataFaceRecognizeResults> FaceRecognizeResults { get; set; }
            public class DetectCelebrityResponseBodyDataFaceRecognizeResults : TeaModel {
                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FaceBoxes")]
                [Validation(Required=false)]
                public List<float?> FaceBoxes { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E92C0D4-BB0F-4F25-AD13-E87D02FAA205</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
