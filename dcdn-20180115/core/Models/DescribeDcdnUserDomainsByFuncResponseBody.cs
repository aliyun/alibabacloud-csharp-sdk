// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsByFuncResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnUserDomainsByFuncResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnUserDomainsByFuncResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageData : TeaModel {
                public string GmtCreated { get; set; }
                public string SslProtocol { get; set; }
                public string Description { get; set; }
                public string ResourceGroupId { get; set; }
                public string Sandbox { get; set; }
                public string DomainStatus { get; set; }
                public string Cname { get; set; }
                public DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource : TeaModel {
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
                public string GmtModified { get; set; }
                public string CdnType { get; set; }
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
