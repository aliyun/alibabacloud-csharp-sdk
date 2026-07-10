// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceGuardRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>200</b> indicates that the request was successful.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeFaceGuardRiskResponseBodyResultObject ResultObject { get; set; }
        public class DescribeFaceGuardRiskResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The unique identifier for ID Verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha43d9cabd52d370d9f4cca9468f71e</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>The device risk probability predicted by the device assistant algorithm. A higher score indicates a higher device risk.</para>
            /// <para>Value range: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("GuardRiskScore")]
            [Validation(Required=false)]
            public double? GuardRiskScore { get; set; }

            /// <summary>
            /// <para>The extended information in JSON format. The returned content is customized based on tenant requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;code&quot;: 200
            ///   &quot;badNet&quot;:false,
            ///   &quot;umid&quot;:&quot;74e37355171ab62230063569350d368e&quot;,
            ///   &quot;fileTags&quot;:&quot;basic_root,basic_hook&quot;,
            ///   &quot;queryCount&quot;:1,
            ///   &quot;querySessionCount&quot;:1,
            ///   &quot;queryUmidCount&quot;:1
            ///   &quot;platform&quot;:&quot;Android&quot;
            /// }</para>
            /// </summary>
            [NameInMap("RiskExtends")]
            [Validation(Required=false)]
            public string RiskExtends { get; set; }

            /// <summary>
            /// <para>The device risk labels.</para>
            /// <list type="bullet">
            /// <item><description><para>Multiple device risk labels are separated by commas (,), such as &quot;ROOT,VPN,HOOK&quot;.</para>
            /// </description></item>
            /// <item><description><para>For more information about device risk labels and their descriptions, see the Face Guard label description in the official documentation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT,VPN,HOOK</para>
            /// </summary>
            [NameInMap("RiskTags")]
            [Validation(Required=false)]
            public string RiskTags { get; set; }

        }

    }

}
