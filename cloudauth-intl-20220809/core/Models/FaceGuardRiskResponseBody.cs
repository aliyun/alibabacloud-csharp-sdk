// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceGuardRiskResponseBody : TeaModel {
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
        /// <para>595E387B-3F0E-5C52-BD02-8EFE63D41FD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FaceGuardRiskResponseBodyResult Result { get; set; }
        public class FaceGuardRiskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The device risk probability predicted by the Face Guard algorithm. A higher score indicates a higher device risk.</para>
            /// <para>Value range: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GuardRiskScore")]
            [Validation(Required=false)]
            public double? GuardRiskScore { get; set; }

            /// <summary>
            /// <para>The extended information in JSON format. The response is customized based on tenant requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认为空</para>
            /// </summary>
            [NameInMap("RiskExtends")]
            [Validation(Required=false)]
            public string RiskExtends { get; set; }

            /// <summary>
            /// <para>The device risk tags.</para>
            /// <list type="bullet">
            /// <item><description><para>Multiple device risk tags are separated by commas (,), such as &quot;ROOT,VPN,HOOK&quot;.</para>
            /// </description></item>
            /// <item><description><para>For more information about device risk tags and their meanings, refer to the Face Guard tag description in the official documentation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT,VPN,HOOK</para>
            /// </summary>
            [NameInMap("RiskTags")]
            [Validation(Required=false)]
            public string RiskTags { get; set; }

            /// <summary>
            /// <para>The unique identifier of the authentication request.</para>
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
