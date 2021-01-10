// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CreateUpstreamAppKeyRelationsRequest : TeaModel {
        [NameInMap("AppKeys")]
        [Validation(Required=false)]
        public string AppKeys { get; set; }

        [NameInMap("AppServerId")]
        [Validation(Required=false)]
        public string AppServerId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
