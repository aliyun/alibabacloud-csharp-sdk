// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginPoolsResponseBody : TeaModel {
        [NameInMap("OriginPools")]
        [Validation(Required=false)]
        public List<ListOriginPoolsResponseBodyOriginPools> OriginPools { get; set; }
        public class ListOriginPoolsResponseBodyOriginPools : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Origins")]
            [Validation(Required=false)]
            public List<ListOriginPoolsResponseBodyOriginPoolsOrigins> Origins { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsOrigins : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AuthConf")]
                [Validation(Required=false)]
                public ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf AuthConf { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsOriginsAuthConf : TeaModel {
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("Header")]
                [Validation(Required=false)]
                public object Header { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            [NameInMap("ReferenceLBCount")]
            [Validation(Required=false)]
            public int? ReferenceLBCount { get; set; }

            [NameInMap("References")]
            [Validation(Required=false)]
            public ListOriginPoolsResponseBodyOriginPoolsReferences References { get; set; }
            public class ListOriginPoolsResponseBodyOriginPoolsReferences : TeaModel {
                [NameInMap("DnsRecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords> DnsRecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesDnsRecords : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("IPARecords")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords> IPARecords { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesIPARecords : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("LoadBalancers")]
                [Validation(Required=false)]
                public List<ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers> LoadBalancers { get; set; }
                public class ListOriginPoolsResponseBodyOriginPoolsReferencesLoadBalancers : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
