// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeDcdnIpaDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetail : TeaModel {
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

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
        };

    }

}
