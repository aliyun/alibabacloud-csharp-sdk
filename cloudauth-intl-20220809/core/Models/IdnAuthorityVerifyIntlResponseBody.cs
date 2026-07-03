// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class IdnAuthorityVerifyIntlResponseBody : TeaModel {
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public IdnAuthorityVerifyIntlResponseBodyResult Result { get; set; }
        public class IdnAuthorityVerifyIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The detailed verification results from the data source are described as follows (using the Indonesian data source as an example):</para>
            /// <list type="bullet">
            /// <item><description><b>govId, fullName, dob</b>: A comparison score equal to 1.0 indicates a complete match with the official data source. A score lower than 1.0 indicates a mismatch. </description></item>
            /// <item><description><b>selfiePhoto</b>: A comparison score greater than 0.8 indicates a match with the official data source. A score equal to or lower than 0.8 indicates a mismatch. </description></item>
            /// <item><description><b>liveness</b>: A score higher than 0.95 indicates a liveness detection risk. </description></item>
            /// <item><description><b>imgManipulationScore</b>: A score higher than 0.95 indicates an image tampering risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;govId&quot;: 1.0,
            ///   &quot;fullName&quot;: 1.0,
            ///   &quot;dob&quot;: 0.9,
            ///   &quot;selfiePhoto&quot;: 0.8777,
            ///   &quot;liveness&quot;: 0.1152,
            ///   &quot;imgManipulationScore&quot;: 0.2253
            /// }</para>
            /// </summary>
            [NameInMap("ExtSourceInfo")]
            [Validation(Required=false)]
            public string ExtSourceInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the verification is passed. Valid values:</para>
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
            /// <para>The unique identifier of the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hk573be80f944d95ac812e0*******a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
