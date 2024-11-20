// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceGuardRiskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
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

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeFaceGuardRiskResponseBodyResultObject ResultObject { get; set; }
        public class DescribeFaceGuardRiskResponseBodyResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
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

            [NameInMap("RiskTags")]
            [Validation(Required=false)]
            public string RiskTags { get; set; }

        }

    }

}
