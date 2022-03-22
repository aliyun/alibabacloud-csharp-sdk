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
                public string Cname { get; set; }
                public string Description { get; set; }
                public string DomainName { get; set; }
                public string DomainStatus { get; set; }
                public string GmtCreated { get; set; }
                public string GmtModified { get; set; }
                public string ResourceGroupId { get; set; }
                public string SSLProtocol { get; set; }
                public string Sandbox { get; set; }
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
