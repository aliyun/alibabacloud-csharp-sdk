// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlStreamResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeepfakeDetectIntlStreamResponseBodyResultObject ResultObject { get; set; }
        public class DeepfakeDetectIntlStreamResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The risk result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: low risk.</description></item>
            /// <item><description><b>1</b>: high risk.</description></item>
            /// <item><description><b>2</b>: suspicious.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The risk score map.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>The risk tags. Multiple tags are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SuspectDeepForgery: suspected deepfake.</description></item>
            /// <item><description>SuspectPSFace: suspected synthetic attack.</description></item>
            /// <item><description>SuspectTemple: suspected template attack.</description></item>
            /// <item><description>SuspectRemake: suspected presentation attack.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SuspectDeepForgery</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            /// <summary>
            /// <para>The unique identifier of the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hksb7ba1b28130d24e015d69********</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
