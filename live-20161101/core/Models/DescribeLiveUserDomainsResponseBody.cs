// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeLiveUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeLiveUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeLiveUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeLiveUserDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// <para>The CNAME generated for the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>learn.developer.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The time when the domain name was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-29T12:15:36Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the domain name was last modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-29T12:15:36Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The status of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>online</b></description></item>
                /// <item><description><b>offline</b></description></item>
                /// <item><description><b>configuring</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("LiveDomainStatus")]
                [Validation(Required=false)]
                public string LiveDomainStatus { get; set; }

                /// <summary>
                /// <para>The type of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>liveVideo</b>: streaming domain</description></item>
                /// <item><description><b>liveEdge</b>: ingest domain</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>liveVideo</para>
                /// </summary>
                [NameInMap("LiveDomainType")]
                [Validation(Required=false)]
                public string LiveDomainType { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the domain name resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzvyjetyjjmla</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B15267</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
