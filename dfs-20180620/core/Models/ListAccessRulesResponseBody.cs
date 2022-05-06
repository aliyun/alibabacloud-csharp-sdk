// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListAccessRulesResponseBody : TeaModel {
        [NameInMap("AccessRules")]
        [Validation(Required=false)]
        public List<ListAccessRulesResponseBodyAccessRules> AccessRules { get; set; }
        public class ListAccessRulesResponseBodyAccessRules : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
