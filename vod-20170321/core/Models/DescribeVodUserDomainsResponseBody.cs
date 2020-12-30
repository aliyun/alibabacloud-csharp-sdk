// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeVodUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeVodUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeVodUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeVodUserDomainsResponseBodyDomainsPageData : TeaModel {
                public string GmtCreated { get; set; }
                public string SslProtocol { get; set; }
                public string Description { get; set; }
                public string Sandbox { get; set; }
                public string Cname { get; set; }
                public string DomainStatus { get; set; }
                public DescribeVodUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeVodUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                    }

                }
                public string GmtModified { get; set; }
                public string DomainName { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
