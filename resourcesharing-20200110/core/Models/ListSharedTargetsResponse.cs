// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedTargetsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("SharedTargets")]
        [Validation(Required=true)]
        public List<ListSharedTargetsResponseSharedTargets> SharedTargets { get; set; }
        public class ListSharedTargetsResponseSharedTargets : TeaModel {
            [NameInMap("ResourceShareId")]
            [Validation(Required=true)]
            public string ResourceShareId { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=true)]
            public string TargetId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

        }

    }

}
