// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCnameCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the number of domain names that are added to WAF in CNAME record mode and hybrid cloud reverse proxy mode.</para>
        /// </summary>
        [NameInMap("CnameCount")]
        [Validation(Required=false)]
        public DescribeCnameCountResponseBodyCnameCount CnameCount { get; set; }
        public class DescribeCnameCountResponseBodyCnameCount : TeaModel {
            /// <summary>
            /// <para>The number of domain names that are added to WAF in CNAME record mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public long? Cname { get; set; }

            /// <summary>
            /// <para>The number of domain names that are added to WAF in hybrid cloud reverse proxy mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HybridCloudCname")]
            [Validation(Required=false)]
            public long? HybridCloudCname { get; set; }

            /// <summary>
            /// <para>The total number of domain names that are added to WAF in CNAME record mode and hybrid cloud reverse proxy mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D****E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
