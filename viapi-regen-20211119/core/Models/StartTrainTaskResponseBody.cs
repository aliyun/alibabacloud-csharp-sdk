// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class StartTrainTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StartTrainTaskResponseBodyData Data { get; set; }
        public class StartTrainTaskResponseBodyData : TeaModel {
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public Dictionary<string, string> CheckResult { get; set; }
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public long? DatasetId { get; set; }
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("LabelId")]
            [Validation(Required=false)]
            public long? LabelId { get; set; }
            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }
            [NameInMap("ModelEffect")]
            [Validation(Required=false)]
            public string ModelEffect { get; set; }
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public long? ModelId { get; set; }
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }
            [NameInMap("TrainStatus")]
            [Validation(Required=false)]
            public string TrainStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
