// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeepfakeDetectIntlResponseBodyResultObject ResultObject { get; set; }
        public class DeepfakeDetectIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The risk result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Low risk.</description></item>
            /// <item><description><b>1</b>: High risk.</description></item>
            /// <item><description><b>2</b>: Suspicious.</description></item>
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
            /// <para>The risk labels. Multiple labels are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SuspectDeepForgery</b>: suspected depth forgery  </description></item>
            /// <item><description><b>SuspectPSFace</b>: suspected synthetic attack  </description></item>
            /// <item><description><b>SuspectWarterMark</b>: suspected watermark  </description></item>
            /// <item><description><b>SuspectTemple</b>: suspected template attack  </description></item>
            /// <item><description><b>SuspectAIGCFace</b>: suspected AIGC-generated face  </description></item>
            /// <item><description><b>SuspectRemake</b>: suspected recaptured face.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SuspectDeepForgery,SuspectWarterMark</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
