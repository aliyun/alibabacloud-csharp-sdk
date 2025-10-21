// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SubmitPreviewResult : TeaModel {
        [NameInMap("queryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("tableSchemas")]
        [Validation(Required=false)]
        public List<TableSchema> TableSchemas { get; set; }

    }

}
