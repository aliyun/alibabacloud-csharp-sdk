// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogGroup : TeaModel {
        [NameInMap("LogTags")]
        [Validation(Required=false)]
        public LogTag LogTags { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public LogItem Logs { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
