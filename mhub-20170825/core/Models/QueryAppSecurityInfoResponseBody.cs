// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class QueryAppSecurityInfoResponseBody : TeaModel {
        [NameInMap("AppSecurityInfo")]
        [Validation(Required=false)]
        public QueryAppSecurityInfoResponseBodyAppSecurityInfo AppSecurityInfo { get; set; }
        public class QueryAppSecurityInfoResponseBodyAppSecurityInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc123abc123</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            [NameInMap("ExtConfig")]
            [Validation(Required=false)]
            public QueryAppSecurityInfoResponseBodyAppSecurityInfoExtConfig ExtConfig { get; set; }
            public class QueryAppSecurityInfoResponseBodyAppSecurityInfoExtConfig : TeaModel {
                [NameInMap("TlogRsaSecret")]
                [Validation(Required=false)]
                public string TlogRsaSecret { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
