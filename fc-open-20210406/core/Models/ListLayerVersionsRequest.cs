// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayerVersionsRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("startVersion")]
        [Validation(Required=false)]
        public int? StartVersion { get; set; }

    }

}
