// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessResponseBody : TeaModel {
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
        /// <para>The message returned with the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42EA58CA-5DF4-55D5-82C4-5E7A40DA62BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceLivenessResponseBodyResult Result { get; set; }
        public class FaceLivenessResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The face result information.</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public FaceLivenessResponseBodyResultExtFaceInfo ExtFaceInfo { get; set; }
            public class FaceLivenessResponseBodyResultExtFaceInfo : TeaModel {
                /// <summary>
                /// <para>The predicted reference age based on the face. The prediction may fail and return no value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FaceAge")]
                [Validation(Required=false)]
                public int? FaceAge { get; set; }

                /// <summary>
                /// <para>The liveness detection result. Valid values: Y (attack detected) and N (normal).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                /// <summary>
                /// <para>The predicted gender based on the face photo. The prediction may fail and return no value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>M: male.</description></item>
                /// <item><description>F: female.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>M</para>
                /// </summary>
                [NameInMap("FaceGender")]
                [Validation(Required=false)]
                public string FaceGender { get; set; }

                /// <summary>
                /// <para>The face quality score (0 to 100). This value is returned only when the face quality score switch is enabled in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87.19</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>The illumination score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("IlluminationScore")]
                [Validation(Required=false)]
                public double? IlluminationScore { get; set; }

                /// <summary>
                /// <para>The key area occlusion score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("KaOcclusionScore")]
                [Validation(Required=false)]
                public double? KaOcclusionScore { get; set; }

                /// <summary>
                /// <para>The occlusion detection result. Valid values: Y (occluded) and N (not occluded). This value is returned only when the occlusion detection switch is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("OcclusionResult")]
                [Validation(Required=false)]
                public string OcclusionResult { get; set; }

                /// <summary>
                /// <para>The occlusion score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.26</para>
                /// </summary>
                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public double? OcclusionScore { get; set; }

                /// <summary>
                /// <para>The sharpness score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86.47</para>
                /// </summary>
                [NameInMap("SharpnessScore")]
                [Validation(Required=false)]
                public double? SharpnessScore { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the authentication passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: passed.</description></item>
            /// <item><description>N: not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The sub-result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The unique ID of the authentication request.</para>
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
