// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChangeSetsResponseBody : TeaModel {
        /// <summary>
        /// The change sets.
        /// </summary>
        [NameInMap("ChangeSets")]
        [Validation(Required=false)]
        public List<ListChangeSetsResponseBodyChangeSets> ChangeSets { get; set; }
        public class ListChangeSetsResponseBodyChangeSets : TeaModel {
            /// <summary>
            /// The ID of the change set.
            /// </summary>
            [NameInMap("ChangeSetId")]
            [Validation(Required=false)]
            public string ChangeSetId { get; set; }

            /// <summary>
            /// The name of the change set.
            /// </summary>
            [NameInMap("ChangeSetName")]
            [Validation(Required=false)]
            public string ChangeSetName { get; set; }

            /// <summary>
            /// The type of the change set.
            /// </summary>
            [NameInMap("ChangeSetType")]
            [Validation(Required=false)]
            public string ChangeSetType { get; set; }

            /// <summary>
            /// The time when the change set was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the change set.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The execution status of the change set.
            /// </summary>
            [NameInMap("ExecutionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            /// <summary>
            /// The region ID of the change set.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the stack with which the change set is associated.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The name of the stack with which the change set is associated.
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// The status of the change set.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the change set is in its current state.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of change sets returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
