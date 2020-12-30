// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetClusterDnatRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("NatId")]
        [Validation(Required=false)]
        public string NatId { get; set; }

        [NameInMap("NatEip")]
        [Validation(Required=false)]
        public string NatEip { get; set; }

    }

}
