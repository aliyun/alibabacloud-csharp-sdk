// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessV2ResponseBody : TeaModel {
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
                /// <para>The predicted reference age of the face. The prediction may fail and return no value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("FaceAge")]
                [Validation(Required=false)]
                public long? FaceAge { get; set; }

                /// <summary>
                /// <para>The liveness detection result. Valid values: Y (attack detected) and N (Normal).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                [NameInMap("FaceAttributeInfo")]
                [Validation(Required=false)]
                public string FaceAttributeInfo { get; set; }

                /// <summary>
                /// <para>The predicted gender of the face image. The prediction may fail and return no value. Valid values:</para>
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
                /// <para>The quality score of the liveness face. Valid values: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79.04</para>
                /// </summary>
                [NameInMap("FaceQualityScore")]
                [Validation(Required=false)]
                public double? FaceQualityScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for illumination as a quality sub-dimension. Valid values: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>97.43</para>
                /// </summary>
                [NameInMap("IlluminationScore")]
                [Validation(Required=false)]
                public double? IlluminationScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for key area occlusion as a quality sub-dimension. Valid values: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("KaOcclusionScore")]
                [Validation(Required=false)]
                public double? KaOcclusionScore { get; set; }

                /// <summary>
                /// <para>Indicates whether facial occlusion is detected. A value of Y indicates occlusion is detected. A value of N indicates no occlusion is detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("OcclusionResult")]
                [Validation(Required=false)]
                public string OcclusionResult { get; set; }

                /// <summary>
                /// <para>The algorithm score for occlusion as a quality sub-dimension. Valid values: 0 to 100. A higher value indicates better quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50.26</para>
                /// </summary>
                [NameInMap("OcclusionScore")]
                [Validation(Required=false)]
                public double? OcclusionScore { get; set; }

                /// <summary>
                /// <para>The algorithm score for image sharpness as a quality sub-dimension. Valid values: 0 to 100. A higher value indicates better quality.</para>
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
            /// <item><description>Y: passed.</description></item>
            /// <item><description>N: not passed.</description></item>
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
            /// <para>The unique ID of the authentication request.</para>
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
