// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceResponseBody : TeaModel {
        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// Indicates whether you own the edge instance or you are authorized to use the edge instance.
            /// 
            /// *   0: You own the edge instance.
            /// *   1: You are authorized to use the edge instance.
            /// </summary>
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryEdgeInstanceResponseBodyDataInstanceList : TeaModel {
                /// <summary>
                /// The time when the edge instance was created.
                /// </summary>
                [NameInMap("BizEnable")]
                [Validation(Required=false)]
                public bool? BizEnable { get; set; }

                /// <summary>
                /// The name of the edge instance.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                /// <summary>
                /// The type of the latest deployment task.
                /// 
                /// *   deploy: deploys the edge instance.
                /// *   Reset: resets the edge instance.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                /// <summary>
                /// The name of the RAM role.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether the edge instance was enabled.
                /// 
                /// *   true: enabled
                /// *   false: disabled
                /// </summary>
                [NameInMap("LatestDeploymentStatus")]
                [Validation(Required=false)]
                public int? LatestDeploymentStatus { get; set; }

                /// <summary>
                /// The status of the latest deployment task.
                /// 
                /// *   0: The task has not started.
                /// *   1: The task is being processed.
                /// *   2: The task was successful.
                /// *   3: The task failed.
                /// </summary>
                [NameInMap("LatestDeploymentType")]
                [Validation(Required=false)]
                public string LatestDeploymentType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The time when the RAM role was attached to IoT Platform.
                /// </summary>
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// The specification of the edge instance.
                /// 
                /// *   10: Lite Edition.
                /// *   20: Standard Edition.
                /// *   30: Pro Edition.
                /// </summary>
                [NameInMap("RoleAttachTime")]
                [Validation(Required=false)]
                public string RoleAttachTime { get; set; }

                [NameInMap("RoleAttachTimestamp")]
                [Validation(Required=false)]
                public long? RoleAttachTimestamp { get; set; }

                /// <summary>
                /// The time when the edge instance was last updated.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// The tags of the edge instance.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public int? Spec { get; set; }

                /// <summary>
                /// The ID of the edge instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the RAM role.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// The number of edge instances.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// A list of edge instances.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. true: indicates that the call was successful. false: indicates that the call failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data returned if the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
