// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesNoPagingResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesNoPagingResponseBodyNodes Nodes { get; set; }
        public class ListNodesNoPagingResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesNoPagingResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesNoPagingResponseBodyNodesNodeInfo : TeaModel {
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

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
