// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DataFilter : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("maxRecords")]
        [Validation(Required=false)]
        public int? MaxRecords { get; set; }

        [NameInMap("provided")]
        [Validation(Required=false)]
        public Dictionary<string, object> Provided { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("samplingRate")]
        [Validation(Required=false)]
        public int? SamplingRate { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
