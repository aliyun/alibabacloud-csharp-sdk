// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain name asset information.</para>
        /// </summary>
        [NameInMap("DomainListResponseList")]
        [Validation(Required=false)]
        public List<DescribeDomainListResponseBodyDomainListResponseList> DomainListResponseList { get; set; }
        public class DescribeDomainListResponseBodyDomainListResponseList : TeaModel {
            /// <summary>
            /// <para>The domain name or website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The IP address information associated with the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX,1.0.XX.XX</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeDomainListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeDomainListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of domain names displayed on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of domain names displayed on each page in a paged query. Default value: <b>10</b>, which indicates that 10 domain names are displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of domain names returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
