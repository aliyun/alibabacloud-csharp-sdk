// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetAccessRuleResponseBody : TeaModel {
        [NameInMap("AccessRule")]
        [Validation(Required=false)]
        public GetAccessRuleResponseBodyAccessRule AccessRule { get; set; }
        public class GetAccessRuleResponseBodyAccessRule : TeaModel {
            [NameInMap("AccessGroupId")]
            [Validation(Required=false)]
            public string AccessGroupId { get; set; }

            [NameInMap("AccessRuleId")]
            [Validation(Required=false)]
            public string AccessRuleId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("NetworkSegment")]
            [Validation(Required=false)]
            public string NetworkSegment { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RWAccessType")]
            [Validation(Required=false)]
            public string RWAccessType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
