// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceLivenessV2ResponseBodyResult Result { get; set; }
        public class FaceLivenessV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The face result information.</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceLivenessV2ResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceLivenessV2ResponseBodyResultExtFaceInfo : TeaModel {
                /// <summary>
                /// <para>The predicted reference age of the face. If the prediction fails, no value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FaceAge")]
                [Validation(Required=false)]
                public long? FaceAge { get; set; }

                /// <summary>
                /// <para>The liveness detection result. Valid values: Y (attack) and N (normal).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                /// <summary>
                /// <para>Detects the facial attributes of the primary face in the input image. The primary face is the one closest to the camera, with the largest facial area, and in focus. The detection result is returned as a string for downstream processing.</para>
                /// <para>The returned fields are defined as follows:</para>
                /// <para><b>gender</b>: the gender of the primary person. A value of 1 indicates male, and 0 indicates female.</para>
                /// <para><b>glasses</b>: whether the primary person is wearing glasses. A value of 1 indicates that glasses are detected, and 0 indicates that glasses are not detected.</para>
                /// <para><b>hat</b>: whether the primary person is wearing a hat (including headscarves and veils). A value of 1 indicates that a hat is detected, and 0 indicates that a hat is not detected.</para>
                /// <para><b>mask</b>: whether the primary person is wearing a mask. A value of 1 indicates that a mask is detected, and 0 indicates that a mask is not detected.</para>
                /// <para><b>tattoo</b>: whether the primary person has visible tattoos. A value of 1 indicates that a tattoo is detected, and 0 indicates that a tattoo is not detected.</para>
                /// <para><b>smoking</b>: whether the primary person is smoking. A value of 1 indicates that smoking is detected, and 0 indicates that smoking is not detected.</para>
                /// <para><b>others</b>: whether other people are present besides the primary person. A value of 1 indicates that other people are detected, and 0 indicates that other people are not detected.</para>
                /// <para><b>env</b>: the environment where the primary person is located, such as an office, factory, hospital, or vehicle. Valid values: office, hospital, factory, vehical, and other.</para>
                /// <para><b>expression</b>: whether the primary person has an exaggerated expression (facial expressions that significantly deviate from a natural or calm state). A value of 1 indicates that an exaggerated expression is detected, and 0 indicates that an exaggerated expression is not detected.</para>
                /// <para><b>age</b>: the actual age of the primary person in years.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///         gender: 1
                ///         glasses: 0
                ///         hat: 1
                ///         mask: 1
                ///         tattoo: 0
                ///         smoking: 0
                ///         others: 1
                ///         env：office
                ///         expression：1
                ///         age：16
                /// }</para>
                /// </summary>
                [NameInMap("FaceAttributeInfo")]
                [Validation(Required=false)]
                public string FaceAttributeInfo { get; set; }

                /// <summary>
                /// <para>The predicted gender of the face in the image. If the prediction fails, no value is returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>M: male</description></item>
                /// <item><description>F: female</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>M</para>
                /// </summary>
                [NameInMap("FaceGender")]
                [Validation(Required=false)]
                public string FaceGender { get; set; }

                /// <summary>
                /// <para>The liveness face quality score. Valid values: 0 to 100. A larger value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79.04</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for illumination in the quality judgment sub-dimension. Valid values: 0 to 100. A larger value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>97.43</para>
                /// </summary>
                [NameInMap("IlluminationScore")]
                [Validation(Required=false)]
                public double? IlluminationScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for key area occlusion in the quality judgment sub-dimension. Valid values: 0 to 100. A larger value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("KaOcclusionScore")]
                [Validation(Required=false)]
                public double? KaOcclusionScore { get; set; }

                /// <summary>
                /// <para>Indicates whether the face is occluded. A value of Y indicates that the face is occluded. A value of N indicates that the face is not occluded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("OcclusionResult")]
                [Validation(Required=false)]
                public string OcclusionResult { get; set; }

                /// <summary>
                /// <para>The algorithm score for occlusion in the quality judgment sub-dimension. Valid values: 0 to 100. A larger value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.26</para>
                /// </summary>
                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public double? OcclusionScore { get; set; }

                /// <summary>
                /// <para>The image sharpness score in the quality judgment sub-dimension. Valid values: 0 to 100. A larger value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60.78</para>
                /// </summary>
                [NameInMap("SharpnessScore")]
                [Validation(Required=false)]
                public double? SharpnessScore { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the authentication is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: passed</description></item>
            /// <item><description>N: failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

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
            /// <para>The unique identifier of the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hksb7ba1b28130d24e015d694361****</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
