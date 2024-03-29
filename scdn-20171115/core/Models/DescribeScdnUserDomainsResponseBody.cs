// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnUserDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeScdnUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeScdnUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeScdnUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeScdnUserDomainsResponseBodyDomainsPageData : TeaModel {
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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

                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeScdnUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeScdnUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeScdnUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeScdnUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
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

                    }

                }

            }

        }

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
