// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMaterializedViewRequest : TeaModel {
        [NameInMap("aggIntervalMins")]
        [Validation(Required=false)]
        public int? AggIntervalMins { get; set; }

        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("originalSql")]
        [Validation(Required=false)]
        public string OriginalSql { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
