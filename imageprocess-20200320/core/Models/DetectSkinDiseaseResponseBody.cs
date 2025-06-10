// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectSkinDiseaseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectSkinDiseaseResponseBodyData Data { get; set; }
        public class DetectSkinDiseaseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>leg</para>
            /// </summary>
            [NameInMap("BodyPart")]
            [Validation(Required=false)]
            public string BodyPart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90.9812</para>
            /// </summary>
            [NameInMap("ImageQuality")]
            [Validation(Required=false)]
            public float? ImageQuality { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>skin_lesion</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public Dictionary<string, object> Results { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;psoriasis&quot;: 0.998,                     &quot;eczema_dermatitis&quot;: 0.0011,                     &quot;lupus_erythematosus&quot;: 0.0004</para>
            /// </summary>
            [NameInMap("ResultsEnglish")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResultsEnglish { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DE9ABC80-4DD4-4F1B-B95C-D0E438B8FE56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
