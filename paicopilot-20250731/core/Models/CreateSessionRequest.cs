// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class CreateSessionRequest : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
