// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRecognitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The intelligent element recognition result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageRecognitionResponseBodyData Data { get; set; }
        public class ImageRecognitionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The border pixel information, returned as a comma-separated string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8,10,0,1,330,330</para>
            /// </summary>
            [NameInMap("BorderPixel")]
            [Validation(Required=false)]
            public string BorderPixel { get; set; }

            /// <summary>
            /// <para>Indicates whether the non-subject area contains text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NoobjCharacter")]
            [Validation(Required=false)]
            public bool? NoobjCharacter { get; set; }

            /// <summary>
            /// <para>Indicates whether the non-subject area contains a logo.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NoobjLogo")]
            [Validation(Required=false)]
            public bool? NoobjLogo { get; set; }

            /// <summary>
            /// <para>Indicates whether the non-subject area contains irrelevant pixels or noise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NoobjNpx")]
            [Validation(Required=false)]
            public bool? NoobjNpx { get; set; }

            /// <summary>
            /// <para>Indicates whether the non-subject area contains a watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NoobjWatermark")]
            [Validation(Required=false)]
            public bool? NoobjWatermark { get; set; }

            /// <summary>
            /// <para>Indicates whether the subject area contains text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ObjCharacter")]
            [Validation(Required=false)]
            public bool? ObjCharacter { get; set; }

            /// <summary>
            /// <para>Indicates whether the subject area contains a logo.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ObjLogo")]
            [Validation(Required=false)]
            public bool? ObjLogo { get; set; }

            /// <summary>
            /// <para>Indicates whether the subject area contains irrelevant pixels or noise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ObjNpx")]
            [Validation(Required=false)]
            public bool? ObjNpx { get; set; }

            /// <summary>
            /// <para>Indicates whether the subject area contains a watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ObjWatermark")]
            [Validation(Required=false)]
            public bool? ObjWatermark { get; set; }

            /// <summary>
            /// <para>The product count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PdNum")]
            [Validation(Required=false)]
            public int? PdNum { get; set; }

            /// <summary>
            /// <para>The product proportion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74.15%</para>
            /// </summary>
            [NameInMap("PdProp")]
            [Validation(Required=false)]
            public string PdProp { get; set; }

            /// <summary>
            /// <para>The list of recognized text.</para>
            /// </summary>
            [NameInMap("RecText")]
            [Validation(Required=false)]
            public List<string> RecText { get; set; }

            /// <summary>
            /// <para>The text proportion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.52%</para>
            /// </summary>
            [NameInMap("TextProp")]
            [Validation(Required=false)]
            public string TextProp { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessedImageCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
