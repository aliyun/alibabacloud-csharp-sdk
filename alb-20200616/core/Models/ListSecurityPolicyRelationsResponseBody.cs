// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPolicyRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecrityPolicyRelations")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations> SecrityPolicyRelations { get; set; }
        public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelations : TeaModel {
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyRelationsResponseBodySecrityPolicyRelationsRelatedListeners : TeaModel {
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

        }

    }

}
