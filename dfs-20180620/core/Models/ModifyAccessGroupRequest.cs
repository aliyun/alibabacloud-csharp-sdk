// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ModifyAccessGroupRequest : TeaModel {
        [NameInMap("AccessGroupId")]
        [Validation(Required=false)]
        public string AccessGroupId { get; set; }

        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

    }

}
