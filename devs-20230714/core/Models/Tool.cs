// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class Tool : TeaModel {
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("toolId")]
        [Validation(Required=false)]
        public string ToolId { get; set; }

        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

    }

}
