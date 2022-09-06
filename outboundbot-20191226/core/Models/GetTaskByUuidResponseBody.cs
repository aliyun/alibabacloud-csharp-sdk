// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetTaskByUuidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskByUuidResponseBodyTask Task { get; set; }
        public class GetTaskByUuidResponseBodyTask : TeaModel {
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("PlannedTime")]
            [Validation(Required=false)]
            public long? PlannedTime { get; set; }

        }

    }

}
