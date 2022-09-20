// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleWorkforce : TeaModel {
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

        [NameInMap("WorkNodeId")]
        [Validation(Required=false)]
        public int? WorkNodeId { get; set; }

    }

}
