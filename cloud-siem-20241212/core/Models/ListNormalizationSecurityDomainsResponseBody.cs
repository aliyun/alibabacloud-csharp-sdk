// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationSecurityDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of security domains.</para>
        /// </summary>
        [NameInMap("NormalizationSecurityDomains")]
        [Validation(Required=false)]
        public List<ListNormalizationSecurityDomainsResponseBodyNormalizationSecurityDomains> NormalizationSecurityDomains { get; set; }
        public class ListNormalizationSecurityDomainsResponseBodyNormalizationSecurityDomains : TeaModel {
            /// <summary>
            /// <para>The security domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OTHER</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainId")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainId { get; set; }

            /// <summary>
            /// <para>The security domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>net</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainName")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
