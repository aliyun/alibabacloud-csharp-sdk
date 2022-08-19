// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsResponseBody : TeaModel {
        [NameInMap("AclRelations")]
        [Validation(Required=false)]
        public List<ListAclRelationsResponseBodyAclRelations> AclRelations { get; set; }
        public class ListAclRelationsResponseBodyAclRelations : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListAclRelationsResponseBodyAclRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListAclRelationsResponseBodyAclRelationsRelatedListeners : TeaModel {
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
