// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ToolsetSpec : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public Authorization AuthConfig { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public ToolsetSchema Schema { get; set; }

    }

}
