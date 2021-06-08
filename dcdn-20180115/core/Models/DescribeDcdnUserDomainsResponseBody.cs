// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnUserDomainsResponseBodyDomainsPageData : TeaModel {
                public string GmtCreated { get; set; }
                public string Description { get; set; }
                public string SSLProtocol { get; set; }
                public string ResourceGroupId { get; set; }
                public string Sandbox { get; set; }
                public string DomainStatus { get; set; }
                public string Cname { get; set; }
                public string GmtModified { get; set; }
                public string DomainName { get; set; }
                public DescribeDcdnUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

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
            }
        };

    }

}
