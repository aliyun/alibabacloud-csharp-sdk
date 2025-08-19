// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeepfakeDetectResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, others indicate failure.</para>
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
        public DeepfakeDetectResponseBodyResultObject ResultObject { get; set; }
        public class DeepfakeDetectResponseBodyResultObject : TeaModel {
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
            /// <item><description>Suspected deep forgery  SuspectDeepForgery</description></item>
            /// <item><description>Suspected synthetic attack  SuspectPSFace</description></item>
            /// <item><description>Suspected watermark  SuspectWarterMark</description></item>
            /// <item><description>Suspected black industry attack  SuspectTemple</description></item>
            /// <item><description>Suspected generated face  SuspectAIGC Face</description></item>
            /// <item><description>Suspected rephotographed face  SuspectRemake</description></item>
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
