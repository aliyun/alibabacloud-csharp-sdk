// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetShipperStatusResponseBody : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public GetShipperStatusResponseBodyStatistics Statistics { get; set; }
        public class GetShipperStatusResponseBodyStatistics : TeaModel {
            [NameInMap("fail")]
            [Validation(Required=false)]
            public long? Fail { get; set; }
            [NameInMap("running")]
            [Validation(Required=false)]
            public long? Running { get; set; }
            [NameInMap("success")]
            [Validation(Required=false)]
            public long? Success { get; set; }
        };

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public GetShipperStatusResponseBodyTasks Tasks { get; set; }
        public class GetShipperStatusResponseBodyTasks : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("taskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }
            [NameInMap("taskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }
            [NameInMap("taskDataLines")]
            [Validation(Required=false)]
            public int? TaskDataLines { get; set; }
            [NameInMap("taskFinishTime")]
            [Validation(Required=false)]
            public long? TaskFinishTime { get; set; }
            [NameInMap("taskLastDataReceiveTime")]
            [Validation(Required=false)]
            public long? TaskLastDataReceiveTime { get; set; }
            [NameInMap("taskMessage")]
            [Validation(Required=false)]
            public string TaskMessage { get; set; }
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }
        };

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
