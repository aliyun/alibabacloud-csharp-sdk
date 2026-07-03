// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// <para>200: Success.
        /// Other: Error code. For error code details, see Error Codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response message.</para>
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
        /// <para>4EB356FE-BB6A-5DCC-B4C5-E8051787EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceCompareResponseBodyResult Result { get; set; }
        public class FaceCompareResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Related result information</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceCompareResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceCompareResponseBodyResultExtFaceInfo : TeaModel {
                /// <summary>
                /// <para>Overall quality score</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.04</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>Illumination score</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("IlluminationScore")]
                [Validation(Required=false)]
                public double? IlluminationScore { get; set; }

                /// <summary>
                /// <para>Key area occlusion score</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("KaOcclusionScore")]
                [Validation(Required=false)]
                public double? KaOcclusionScore { get; set; }

                /// <summary>
                /// <para>Occlusion score</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.26</para>
                /// </summary>
                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public double? OcclusionScore { get; set; }

                /// <summary>
                /// <para>Sharpness score</para>
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
            /// <para>The comparison score between the submitted face photo and the reference face image during the authentication process. Value range: <b>0</b> to <b>100</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("FaceComparisonScore")]
            [Validation(Required=false)]
            public double? FaceComparisonScore { get; set; }

            /// <summary>
            /// <para>Whether the authentication passed.</para>
            /// <list type="bullet">
            /// <item><description>Y: Passed.</description></item>
            /// <item><description>N: Not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The unique identifier of the authentication request.</para>
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
