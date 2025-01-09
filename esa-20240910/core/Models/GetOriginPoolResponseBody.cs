// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginPoolResponseBody : TeaModel {
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
        public List<GetOriginPoolResponseBodyOrigins> Origins { get; set; }
        public class GetOriginPoolResponseBodyOrigins : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public GetOriginPoolResponseBodyOriginsAuthConf AuthConf { get; set; }
            public class GetOriginPoolResponseBodyOriginsAuthConf : TeaModel {
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
        public GetOriginPoolResponseBodyReferences References { get; set; }
        public class GetOriginPoolResponseBodyReferences : TeaModel {
            [NameInMap("DnsRecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesDnsRecords> DnsRecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesDnsRecords : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("IPARecords")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesIPARecords> IPARecords { get; set; }
            public class GetOriginPoolResponseBodyReferencesIPARecords : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("LoadBalancers")]
            [Validation(Required=false)]
            public List<GetOriginPoolResponseBodyReferencesLoadBalancers> LoadBalancers { get; set; }
            public class GetOriginPoolResponseBodyReferencesLoadBalancers : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
