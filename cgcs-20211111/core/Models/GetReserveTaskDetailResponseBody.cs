// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetReserveTaskDetailResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("CurrCompletedSessionCapacity")]
        [Validation(Required=false)]
        public int? CurrCompletedSessionCapacity { get; set; }

        [NameInMap("DistrictId")]
        [Validation(Required=false)]
        public string DistrictId { get; set; }

        [NameInMap("ExpectResourceReadyTime")]
        [Validation(Required=false)]
        public string ExpectResourceReadyTime { get; set; }

        [NameInMap("ExpectSessionCapacity")]
        [Validation(Required=false)]
        public int? ExpectSessionCapacity { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResBatchList")]
        [Validation(Required=false)]
        public List<GetReserveTaskDetailResponseBodyResBatchList> ResBatchList { get; set; }
        public class GetReserveTaskDetailResponseBodyResBatchList : TeaModel {
            [NameInMap("ResBatchId")]
            [Validation(Required=false)]
            public string ResBatchId { get; set; }

            [NameInMap("ResBatchTagName")]
            [Validation(Required=false)]
            public string ResBatchTagName { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
