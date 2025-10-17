// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeepfakeDetectIntlStreamResponseBodyResultObject ResultObject { get; set; }
        public class DeepfakeDetectIntlStreamResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Risk result:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Low risk</description></item>
            /// <item><description><b>1</b>: High risk</description></item>
            /// <item><description><b>2</b>: Suspicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>Risk score map.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>Risk tags. Multiple tags are separated by commas (,), including:</para>
            /// <list type="bullet">
            /// <item><description>SuspectDeepForgery: Suspected deep forgery</description></item>
            /// <item><description>SuspectPSFace: Suspected synthetic attack</description></item>
            /// <item><description>SuspectTemple: Suspected template attack</description></item>
            /// <item><description>SuspectRemake: Suspected presentation attack</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SuspectDeepForgery</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

        }

    }

}
