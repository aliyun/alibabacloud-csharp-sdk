// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveOutboundDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The traffic distribution of personal information records involved in cross-border data transfer.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveOutboundDistributionResponseBodyData> Data { get; set; }
        public class DescribeSensitiveOutboundDistributionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The country to which the data is transferred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The number of personal information records involved in cross-border data transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213</para>
            /// </summary>
            [NameInMap("InfoOutboundCount")]
            [Validation(Required=false)]
            public long? InfoOutboundCount { get; set; }

            /// <summary>
            /// <para>The number of sensitive information records involved in cross-border data transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>144</para>
            /// </summary>
            [NameInMap("SensitiveOutboundCount")]
            [Validation(Required=false)]
            public long? SensitiveOutboundCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
