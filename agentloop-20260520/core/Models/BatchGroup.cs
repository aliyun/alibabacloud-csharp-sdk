// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class BatchGroup : TeaModel {
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ExperimentRecord> Records { get; set; }

    }

}
