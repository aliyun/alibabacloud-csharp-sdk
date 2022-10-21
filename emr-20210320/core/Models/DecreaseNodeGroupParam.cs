// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DecreaseNodeGroupParam : TeaModel {
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("ReleaseInstanceIds")]
        [Validation(Required=false)]
        public List<string> ReleaseInstanceIds { get; set; }

    }

}
