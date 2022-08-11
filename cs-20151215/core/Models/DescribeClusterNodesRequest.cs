// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesRequest : TeaModel {
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
