// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetApplicationLogsOutput : TeaModel {
        [NameInMap("logEntrys")]
        [Validation(Required=false)]
        public List<LogEntry> LogEntrys { get; set; }

        [NameInMap("nextOffset")]
        [Validation(Required=false)]
        public long? NextOffset { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
