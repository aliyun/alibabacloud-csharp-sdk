// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E63B760-0ECB-5C07-8503-A65C27876968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceVerifyIntlResponseBodyResult Result { get; set; }
        public class FaceVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The face ID, user ID, and comparison score of the corresponding face in the face library when a duplicate face is found during retrieval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;faceGroupCode&quot;: &quot;sg7<b><b>uzt&quot;,
            ///         &quot;faceId&quot;: &quot;f5a921</b></b><em><b>9e792ec84c8f0ca592a&quot;,
            ///         &quot;merchantUserId&quot;: &quot;fa</b></em>*01&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("DuplicateFace")]
            [Validation(Required=false)]
            public string DuplicateFace { get; set; }

            /// <summary>
            /// <para>The additional face result information.</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceVerifyIntlResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceVerifyIntlResponseBodyResultExtFaceInfo : TeaModel {
                [NameInMap("FaceAttributeInfo")]
                [Validation(Required=false)]
                public string FaceAttributeInfo { get; set; }

                /// <summary>
                /// <para>The liveness face quality score. Value range: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.04</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for illumination, a sub-dimension of quality assessment. Value range: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>97.43</para>
                /// </summary>
                [NameInMap("IlluminationScore")]
                [Validation(Required=false)]
                public double? IlluminationScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for key area occlusion, a sub-dimension of quality assessment. Value range: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("KaOcclusionScore")]
                [Validation(Required=false)]
                public double? KaOcclusionScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for occlusion, a sub-dimension of quality assessment. Value range: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.26</para>
                /// </summary>
                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public double? OcclusionScore { get; set; }

                /// <summary>
                /// <para>The image sharpness score, a sub-dimension of quality assessment. Value range: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86.47</para>
                /// </summary>
                [NameInMap("SharpnessScore")]
                [Validation(Required=false)]
                public double? SharpnessScore { get; set; }

                [NameInMap("TargetFaceQualityScore")]
                [Validation(Required=false)]
                public double? TargetFaceQualityScore { get; set; }

                [NameInMap("TargetIlluminationScore")]
                [Validation(Required=false)]
                public double? TargetIlluminationScore { get; set; }

                [NameInMap("TargetKaOcclusionScore")]
                [Validation(Required=false)]
                public double? TargetKaOcclusionScore { get; set; }

                [NameInMap("TargetOcclusionScore")]
                [Validation(Required=false)]
                public double? TargetOcclusionScore { get; set; }

                [NameInMap("TargetSharpnessScore")]
                [Validation(Required=false)]
                public double? TargetSharpnessScore { get; set; }

            }

            /// <summary>
            /// <para>The estimated age of the face. This value may not be returned if the prediction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FaceAge")]
            [Validation(Required=false)]
            public long? FaceAge { get; set; }

            /// <summary>
            /// <para>Indicates whether the captured face involves a liveness attack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Attack detected.</description></item>
            /// <item><description>N: No attack detected.</description></item>
            /// </list>
            /// <para>This field is returned only when passive liveness detection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("FaceAttack")]
            [Validation(Required=false)]
            public string FaceAttack { get; set; }

            /// <summary>
            /// <para>The probability of a passive liveness detection attack on the face. Value range: 0 to 100. This field is returned only when passive liveness detection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FaceAttackScore")]
            [Validation(Required=false)]
            public double? FaceAttackScore { get; set; }

            /// <summary>
            /// <para>The comparison score between the face image submitted during verification and the reference face image. Value range: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95.0</para>
            /// </summary>
            [NameInMap("FaceComparisonScore")]
            [Validation(Required=false)]
            public double? FaceComparisonScore { get; set; }

            /// <summary>
            /// <para>The predicted gender of the face image. This value may not be returned if the prediction fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>M: Male.</description></item>
            /// <item><description>F: Female.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>M</para>
            /// </summary>
            [NameInMap("FaceGender")]
            [Validation(Required=false)]
            public string FaceGender { get; set; }

            /// <summary>
            /// <para>The final verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Passed.</description></item>
            /// <item><description>N: Not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("FacePassed")]
            [Validation(Required=false)]
            public string FacePassed { get; set; }

            /// <summary>
            /// <para>The face ID returned only when the customer has enabled automatic registration and the face is registered successfully.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e792ec84c8f0ca592a</para>
            /// </summary>
            [NameInMap("FaceRegistrationId")]
            [Validation(Required=false)]
            public string FaceRegistrationId { get; set; }

            /// <summary>
            /// <para>The face registration result. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>0: Failed. </description></item>
            /// <item><description>1: Succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FaceRegistrationResult")]
            [Validation(Required=false)]
            public long? FaceRegistrationResult { get; set; }

            /// <summary>
            /// <para>The sub-result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The unique identifier of the verification request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ab0b***cbde97</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
