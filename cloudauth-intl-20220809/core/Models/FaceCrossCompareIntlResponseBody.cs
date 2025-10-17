// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCrossCompareIntlResponseBody : TeaModel {
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
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceCrossCompareIntlResponseBodyResult Result { get; set; }
        public class FaceCrossCompareIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>A to B comparison score, range 0～100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FaceComparisonScoreA2B")]
            [Validation(Required=false)]
            public double? FaceComparisonScoreA2B { get; set; }

            /// <summary>
            /// <para>B to C comparison score, range 0～100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FaceComparisonScoreB2C")]
            [Validation(Required=false)]
            public double? FaceComparisonScoreB2C { get; set; }

            /// <summary>
            /// <para>C to A comparison score, range 0～100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("FaceComparisonScoreC2A")]
            [Validation(Required=false)]
            public double? FaceComparisonScoreC2A { get; set; }

            /// <summary>
            /// <para>Final verification result, values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Pass</description></item>
            /// <item><description>N: Fail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("FacePassed")]
            [Validation(Required=false)]
            public string FacePassed { get; set; }

            /// <summary>
            /// <para>Unique identifier for the authentication request.</para>
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
