// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ListTLSCipherPoliciesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("TLSCipherPolicies")]
        [Validation(Required=false)]
        public List<ListTLSCipherPoliciesResponseBodyTLSCipherPolicies> TLSCipherPolicies { get; set; }
        public class ListTLSCipherPoliciesResponseBodyTLSCipherPolicies : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("RelateListeners")]
            [Validation(Required=false)]
            public List<ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners> RelateListeners { get; set; }
            public class ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners : TeaModel {
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

        }

    }

}
