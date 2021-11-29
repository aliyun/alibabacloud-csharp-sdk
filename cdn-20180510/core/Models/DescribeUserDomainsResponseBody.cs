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
                public string CdnType { get; set; }
                public string Cname { get; set; }
                public string Coverage { get; set; }
                public string Description { get; set; }
                public string DomainName { get; set; }
                public string DomainStatus { get; set; }
                public string GmtCreated { get; set; }
                public string GmtModified { get; set; }
                public string ResourceGroupId { get; set; }
                public string Sandbox { get; set; }
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
                public string SslProtocol { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
