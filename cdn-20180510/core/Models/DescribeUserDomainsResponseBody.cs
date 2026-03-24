// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeUserDomainsResponseBodyDomainsPageData : TeaModel {
                [NameInMap("CdnType")]
                [Validation(Required=false)]
                public string CdnType { get; set; }

                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Coverage")]
                [Validation(Required=false)]
                public string Coverage { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDA62CE4-3477-439A-B52E-D2D7C829D7C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
