// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyResult Result { get; set; }
        public class DescribePipelineResponseBodyResult : TeaModel {
            [NameInMap("batchDelay")]
            [Validation(Required=false)]
            public int? BatchDelay { get; set; }
            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }
            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }
            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }
            [NameInMap("workers")]
            [Validation(Required=false)]
            public int? Workers { get; set; }
        };

    }

}
