// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceGuardRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code, <b>200</b> indicates successful response from the interface.</para>
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
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeFaceGuardRiskResponseBodyResultObject ResultObject { get; set; }
        public class DescribeFaceGuardRiskResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Unique real-person authentication identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha43d9cabd52d370d9f4cca9468f71e</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            [NameInMap("GuardRiskScore")]
            [Validation(Required=false)]
            public double? GuardRiskScore { get; set; }

            /// <summary>
            /// <para>Extended information, in JSON format. (Customized return based on tenant requirements)</para>
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
            /// <para>Device risk tags.</para>
            /// <list type="bullet">
            /// <item><description><para>Multiple device risk tags are separated by commas (,). For example, “ROOT,VPN,HOOK”,</para>
            /// </description></item>
            /// <item><description><para>For more information about device risk tags and their meanings, please refer to the official documentation on Face Guard Tag Descriptions.</para>
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
