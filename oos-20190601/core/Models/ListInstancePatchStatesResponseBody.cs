// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchStatesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("InstancePatchStates")]
        [Validation(Required=false)]
        public List<ListInstancePatchStatesResponseBodyInstancePatchStates> InstancePatchStates { get; set; }
        public class ListInstancePatchStatesResponseBodyInstancePatchStates : TeaModel {
            [NameInMap("MissingCount")]
            [Validation(Required=false)]
            public string MissingCount { get; set; }

            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            [NameInMap("OwnerInformation")]
            [Validation(Required=false)]
            public string OwnerInformation { get; set; }

            [NameInMap("InstalledOtherCount")]
            [Validation(Required=false)]
            public string InstalledOtherCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            [NameInMap("InstalledPendingRebootCount")]
            [Validation(Required=false)]
            public string InstalledPendingRebootCount { get; set; }

            [NameInMap("InstalledRejectedCount")]
            [Validation(Required=false)]
            public string InstalledRejectedCount { get; set; }

            [NameInMap("PatchGroup")]
            [Validation(Required=false)]
            public string PatchGroup { get; set; }

            [NameInMap("InstalledCount")]
            [Validation(Required=false)]
            public string InstalledCount { get; set; }

        }

    }

}
