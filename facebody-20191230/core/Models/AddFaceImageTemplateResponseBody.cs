// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddFaceImageTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddFaceImageTemplateResponseBodyData Data { get; set; }
        public class AddFaceImageTemplateResponseBodyData : TeaModel {
            [NameInMap("FaceInfos")]
            [Validation(Required=false)]
            public List<AddFaceImageTemplateResponseBodyDataFaceInfos> FaceInfos { get; set; }
            public class AddFaceImageTemplateResponseBodyDataFaceInfos : TeaModel {
                [NameInMap("FaceRect")]
                [Validation(Required=false)]
                public AddFaceImageTemplateResponseBodyDataFaceInfosFaceRect FaceRect { get; set; }
                public class AddFaceImageTemplateResponseBodyDataFaceInfosFaceRect : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>94</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>89</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>254</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>318</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string 6cd509ea-54fa-4730-8e9d-c94cadcda048_0</para>
                /// </summary>
                [NameInMap("TemplateFaceID")]
                [Validation(Required=false)]
                public string TemplateFaceID { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>798A721D-7C7F-4D87-A125-1D04B3055C2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
