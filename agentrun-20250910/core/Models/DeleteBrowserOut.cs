// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class DeleteBrowserOut : TeaModel {
        [NameInMap("browserId")]
        [Validation(Required=false)]
        public string BrowserId { get; set; }

        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
