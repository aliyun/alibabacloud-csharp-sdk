// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class ListOperationsRequest : TeaModel {
        [NameInMap("ClusterBizId")]
        [Validation(Required=false)]
        public string ClusterBizId { get; set; }

        [NameInMap("ParentOperationNodeId")]
        [Validation(Required=false)]
        public string ParentOperationNodeId { get; set; }

    }

}
