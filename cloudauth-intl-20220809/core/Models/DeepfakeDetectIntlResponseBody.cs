// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates a successful request, any other value indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeepfakeDetectIntlResponseBodyResultObject ResultObject { get; set; }
        public class DeepfakeDetectIntlResponseBodyResultObject : TeaModel {
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
            /// <para>Risk tags. Multiple tags are separated by commas (,). Includes:</para>
            /// <list type="bullet">
            /// <item><description><b>SuspectDeepForgery</b> Suspected deep forgery  </description></item>
            /// <item><description><b>SuspectPSFace</b> Suspected synthetic attack  </description></item>
            /// <item><description><b>SuspectWarterMark</b> Suspected watermark presence  </description></item>
            /// <item><description><b>SuspectTemple</b> Suspected template attack  </description></item>
            /// <item><description><b>SuspectAIGCFace</b>  Suspected generated face  </description></item>
            /// <item><description><b>SuspectRemake</b>  Suspected rephotographed face</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SuspectDeepForgery,SuspectWarterMark</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

        }

    }

}
