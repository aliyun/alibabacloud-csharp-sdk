// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserOssLocation : TeaModel {
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
