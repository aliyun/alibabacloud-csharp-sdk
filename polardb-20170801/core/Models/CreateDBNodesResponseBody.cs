// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBNodesResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public CreateDBNodesResponseBodyDBNodeIds DBNodeIds { get; set; }
        public class CreateDBNodesResponseBodyDBNodeIds : TeaModel {
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public List<string> DBNodeId { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
