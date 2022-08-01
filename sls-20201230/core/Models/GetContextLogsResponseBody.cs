// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsResponseBody : TeaModel {
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Logs { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        [NameInMap("total_lines")]
        [Validation(Required=false)]
        public long? TotalLines { get; set; }

    }

}
