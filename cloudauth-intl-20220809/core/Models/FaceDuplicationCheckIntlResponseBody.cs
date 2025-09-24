// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceDuplicationCheckIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E63B760-0ECB-5C07-8503-A65C27876968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceDuplicationCheckIntlResponseBodyResult Result { get; set; }
        public class FaceDuplicationCheckIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Returns the face library face ID and UserID when a duplicate face is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            /// {\&quot;faceGroupCode\&quot;:\&quot;sg7<b><b>uzt\&quot;,\&quot;faceId\&quot;:\&quot;f5a921</b></b>***9e792ec84c8f0ca592a\&quot;}
            /// ]</para>
            /// </summary>
            [NameInMap("DuplicateFace")]
            [Validation(Required=false)]
            public string DuplicateFace { get; set; }

            /// <summary>
            /// <para>The estimated age of the face, which may not be returned if the prediction fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FaceAge")]
            [Validation(Required=false)]
            public string FaceAge { get; set; }

            /// <summary>
            /// <para>Indicates whether the captured face involves a liveness attack, Y for an attack, N for no attack.
            /// Returned when silent liveness detection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("FaceAttack")]
            [Validation(Required=false)]
            public string FaceAttack { get; set; }

            /// <summary>
            /// <para>The probability of a liveness attack detected by silent liveness detection. The value range is 0 to 100.
            /// Returned when silent liveness detection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FaceAttackScore")]
            [Validation(Required=false)]
            public string FaceAttackScore { get; set; }

            /// <summary>
            /// <para>When the verification mode is 1 or 2, returns the 1:1 verification comparison score
            /// Comparison score range 0～100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("FaceComparisonScore")]
            [Validation(Required=false)]
            public string FaceComparisonScore { get; set; }

            /// <summary>
            /// <para>The predicted gender of the face in the image, which may not be returned if the prediction fails.</para>
            /// <list type="bullet">
            /// <item><description>M: Male</description></item>
            /// <item><description>F: Female</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>M</para>
            /// </summary>
            [NameInMap("FaceGender")]
            [Validation(Required=false)]
            public string FaceGender { get; set; }

            /// <summary>
            /// <para>Final authentication result, values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Passed</description></item>
            /// <item><description>N: Not passed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("FacePassed")]
            [Validation(Required=false)]
            public string FacePassed { get; set; }

            /// <summary>
            /// <para>Returns the corresponding FACEID only when the customer sets auto-registration and the face registration is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e792ec84c8f0ca592a</para>
            /// </summary>
            [NameInMap("FaceRegistrationId")]
            [Validation(Required=false)]
            public string FaceRegistrationId { get; set; }

            /// <summary>
            /// <para>Face registration result </para>
            /// <list type="bullet">
            /// <item><description>0- Failed </description></item>
            /// <item><description>1- Succeeded</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FaceRegistrationResult")]
            [Validation(Required=false)]
            public int? FaceRegistrationResult { get; set; }

            /// <summary>
            /// <para>Description of the authentication result. For more information, see ResultObject.SubCode error code description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Unique identifier of the authentication request.</para>
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
