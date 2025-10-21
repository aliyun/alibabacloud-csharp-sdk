// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SubmitPreview : TeaModel {
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("tableSchemas")]
        [Validation(Required=false)]
        public List<TableSchema> TableSchemas { get; set; }

    }

}
