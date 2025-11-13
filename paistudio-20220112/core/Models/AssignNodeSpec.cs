// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AssignNodeSpec : TeaModel {
        [NameInMap("AntiAffinityNodeNames")]
        [Validation(Required=false)]
        public string AntiAffinityNodeNames { get; set; }

        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public bool? EnableAssignNode { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

    }

}
