// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class Workforce : TeaModel {
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<SimpleUser> Users { get; set; }

        [NameInMap("WorkNodeId")]
        [Validation(Required=false)]
        public int? WorkNodeId { get; set; }

    }

}
