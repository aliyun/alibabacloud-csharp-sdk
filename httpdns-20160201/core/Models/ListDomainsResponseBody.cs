// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class ListDomainsResponseBody : TeaModel {
        [NameInMap("DomainInfos")]
        [Validation(Required=false)]
        public ListDomainsResponseBodyDomainInfos DomainInfos { get; set; }
        public class ListDomainsResponseBodyDomainInfos : TeaModel {
            [NameInMap("DomainInfo")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainInfosDomainInfo> DomainInfo { get; set; }
            public class ListDomainsResponseBodyDomainInfosDomainInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("ResolveHttpAes")]
                [Validation(Required=false)]
                public long? ResolveHttpAes { get; set; }

                [NameInMap("ResolveHttpsAes")]
                [Validation(Required=false)]
                public long? ResolveHttpsAes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Resolved")]
                [Validation(Required=false)]
                public long? Resolved { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Resolved6")]
                [Validation(Required=false)]
                public long? Resolved6 { get; set; }

                [NameInMap("ResolvedDoh")]
                [Validation(Required=false)]
                public long? ResolvedDoh { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResolvedHttps")]
                [Validation(Required=false)]
                public long? ResolvedHttps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ResolvedHttps6")]
                [Validation(Required=false)]
                public long? ResolvedHttps6 { get; set; }

                [NameInMap("TimeModified")]
                [Validation(Required=false)]
                public long? TimeModified { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-7427E531****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
