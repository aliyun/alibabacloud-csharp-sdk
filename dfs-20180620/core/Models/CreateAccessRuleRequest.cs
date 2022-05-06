// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateAccessRuleRequest : TeaModel {
        [NameInMap("AccessGroupId")]
        [Validation(Required=false)]
        public string AccessGroupId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("NetworkSegment")]
        [Validation(Required=false)]
        public string NetworkSegment { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RWAccessType")]
        [Validation(Required=false)]
        public string RWAccessType { get; set; }

    }

}
