// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesNoPagingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesNoPagingResponseBodyNodes Nodes { get; set; }
        public class ListNodesNoPagingResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesNoPagingResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesNoPagingResponseBodyNodesNodeInfo : TeaModel {
                public string Status { get; set; }
                public string HostName { get; set; }
                public string InstanceType { get; set; }
                public string ImageId { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
