// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDeletedDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeCdnDeletedDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeCdnDeletedDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeCdnDeletedDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeCdnDeletedDomainsResponseBodyDomainsPageData : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page, which is the same as the <b>PageNumber</b> parameter in request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of domain names returned per page, which is the same as the <b>PageSize</b> parameter in request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA75AADB-5E25-4970-B480-EAA1F5658483</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
