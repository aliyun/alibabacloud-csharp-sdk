// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessResponseBody : TeaModel {
        /// <summary>
        /// <para><a href="https://www.alibabacloud.com/help/en/ekyc/latest/cadqvlft48igbpdc?spm=a2c63.p38356.0.i54#3d0ed52f967g6">The response code.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A detailed description of the response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42EA58CA-5DF4-55D5-82C4-5E7A40DA62BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceLivenessResponseBodyResult Result { get; set; }
        public class FaceLivenessResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The results of the passive liveness detection. The value is in the JSON format. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/cadqvlft48igbpdc?spm=a2c63.p38356.0.i54#5ff42f7274agz">ExtFaceInfo</a>.</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceLivenessResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceLivenessResponseBodyResultExtFaceInfo : TeaModel {
                /// <summary>
                /// <para>The predicted age of the person in the image. The prediction may fail, resulting in an empty value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FaceAge")]
                [Validation(Required=false)]
                public int? FaceAge { get; set; }

                /// <summary>
                /// <para>Indicates whether a presentation attack was detected on the captured face. Y means an attack was detected. N means no attack was detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                /// <summary>
                /// <para>The predicted gender of the person in the image. The prediction may fail, resulting in an empty value.</para>
                /// <list type="bullet">
                /// <item><description><para><b>M</b>: Male</para>
                /// </description></item>
                /// <item><description><para><b>F</b>: Female</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>M</para>
                /// </summary>
                [NameInMap("FaceGender")]
                [Validation(Required=false)]
                public string FaceGender { get; set; }

                /// <summary>
                /// <para>Optional. The quality score of the live face. The value ranges from 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87.19</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>Optional. Indicates whether the face is occluded. Y means the face is occluded. N means the face is not occluded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("OcclusionResult")]
                [Validation(Required=false)]
                public string OcclusionResult { get; set; }

            }

            /// <summary>
            /// <para>The authentication result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Y: The authentication is passed.</para>
            /// </description></item>
            /// <item><description><para>N: The authentication is not passed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The code that corresponds to the verification result. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/cadqvlft48igbpdc?spm=a2c63.p38356.0.i54#5ff3e16174tl2">ResultObject.SubCode error codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The transaction ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
