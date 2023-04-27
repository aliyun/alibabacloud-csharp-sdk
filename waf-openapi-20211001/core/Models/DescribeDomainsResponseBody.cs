// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Backeds")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsBackeds Backeds { get; set; }
            public class DescribeDomainsResponseBodyDomainsBackeds : TeaModel {
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttp> Http { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttp : TeaModel {
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttps> Https { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttps : TeaModel {
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

            }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ListenPorts")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsListenPorts ListenPorts { get; set; }
            public class DescribeDomainsResponseBodyDomainsListenPorts : TeaModel {
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<long?> Http { get; set; }

                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<long?> Https { get; set; }

            }

            /// <summary>
            /// 阿里云资源组ID。
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
