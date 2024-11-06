// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The protected domain name.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDcdnWafDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The header of IP address of the client that is connected to the point of presence (POP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>X-Forwarded-For</para>
            /// </summary>
            [NameInMap("ClientIpTag")]
            [Validation(Required=false)]
            public string ClientIpTag { get; set; }

            /// <summary>
            /// <para>The protected domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The number of protection policies that were configured for the protected domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PolicyCount")]
            [Validation(Required=false)]
            public int? PolicyCount { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page, which is the same as the PageNumber parameter in request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of domain names returned per page, which is the same as the PageSize parameter in request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>153ca2cd-3c01-44be-b408-64dbc6c88630</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of protected domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
