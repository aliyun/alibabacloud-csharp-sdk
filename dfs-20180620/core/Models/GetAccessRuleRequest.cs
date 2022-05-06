// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetAccessRuleRequest : TeaModel {
        [NameInMap("AccessGroupId")]
        [Validation(Required=false)]
        public string AccessGroupId { get; set; }

        [NameInMap("AccessRuleId")]
        [Validation(Required=false)]
        public string AccessRuleId { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

    }

}
