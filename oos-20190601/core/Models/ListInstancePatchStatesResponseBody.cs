// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchStatesResponseBody : TeaModel {
        /// <summary>
        /// The number of patches that are not installed.
        /// </summary>
        [NameInMap("InstancePatchStates")]
        [Validation(Required=false)]
        public List<ListInstancePatchStatesResponseBodyInstancePatchStates> InstancePatchStates { get; set; }
        public class ListInstancePatchStatesResponseBodyInstancePatchStates : TeaModel {
            /// <summary>
            /// The number of patches that have been installed but require a restart to take effect.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            /// <summary>
            /// The ID of the patch baseline.
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            /// <summary>
            /// Queries patches of an instance.
            /// </summary>
            [NameInMap("InstalledCount")]
            [Validation(Required=false)]
            public string InstalledCount { get; set; }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("InstalledOtherCount")]
            [Validation(Required=false)]
            public string InstalledOtherCount { get; set; }

            /// <summary>
            /// The number of patches that are rejected by the user.
            /// </summary>
            [NameInMap("InstalledPendingRebootCount")]
            [Validation(Required=false)]
            public string InstalledPendingRebootCount { get; set; }

            /// <summary>
            /// The patch group.
            /// </summary>
            [NameInMap("InstalledRejectedCount")]
            [Validation(Required=false)]
            public string InstalledRejectedCount { get; set; }

            /// <summary>
            /// The operation type.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the operation ended.
            /// </summary>
            [NameInMap("MissingCount")]
            [Validation(Required=false)]
            public string MissingCount { get; set; }

            /// <summary>
            /// The information about the user.
            /// </summary>
            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            /// <summary>
            /// The number of patches that failed to be installed.
            /// </summary>
            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            /// <summary>
            /// The time when the operation was initiated.
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// The number of patches that do not meet the baseline.
            /// </summary>
            [NameInMap("OwnerInformation")]
            [Validation(Required=false)]
            public string OwnerInformation { get; set; }

            /// <summary>
            /// The number of installed patches.
            /// </summary>
            [NameInMap("PatchGroup")]
            [Validation(Required=false)]
            public string PatchGroup { get; set; }

        }

        /// <summary>
        /// The details of patches of the instance.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
