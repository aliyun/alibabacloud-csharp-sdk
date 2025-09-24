// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceGuardRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of Success indicates that the API operation responded successfully. For more information about how to determine the authentication result, expand the <b>Return codes</b> section below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A detailed description of the return code.</para>
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
        /// <para>595E387B-3F0E-5C52-BD02-8EFE63D41FD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceGuardRiskResponseBodyResult Result { get; set; }
        public class FaceGuardRiskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The device risk probability predicted by the Device Guard algorithm. A higher score indicates a higher device risk.</para>
            /// <para>Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GuardRiskScore")]
            [Validation(Required=false)]
            public double? GuardRiskScore { get; set; }

            /// <summary>
            /// <para>Extended information. This is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;code&quot;: 200
            ///   &quot;message&quot;:&quot;success&quot;
            ///   &quot;umid&quot;:&quot;07d3295d3d597b425d102a7f********&quot;,
            ///   &quot;sip&quot;:&quot;198.51.100.1&quot;,
            ///   &quot;durationMs&quot; : 4968931
            ///   &quot;queryCount&quot;:1,
            ///   &quot;querySessionCount&quot;:1,
            ///   &quot;queryUmidCount&quot;:1
            ///   &quot;platform&quot;:&quot;Android
            /// }</para>
            /// </summary>
            [NameInMap("RiskExtends")]
            [Validation(Required=false)]
            public string RiskExtends { get; set; }

            /// <summary>
            /// <para>The device risk tags. Multiple risk tags are separated by commas (<b>,</b>). For more information about the risk tags and their meanings, expand the <b>Risk tags (RiskTags)</b> section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT,VPN,HOOK</para>
            /// </summary>
            [NameInMap("RiskTags")]
            [Validation(Required=false)]
            public string RiskTags { get; set; }

            /// <summary>
            /// <para>The transaction ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hk573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
