// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceHistoricDeploymentResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceHistoricDeploymentResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceHistoricDeploymentResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The list of deployment tasks.
            /// </summary>
            [NameInMap("DeploymentList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceHistoricDeploymentResponseBodyDataDeploymentList> DeploymentList { get; set; }
            public class QueryEdgeInstanceHistoricDeploymentResponseBodyDataDeploymentList : TeaModel {
                /// <summary>
                /// The ID of the deployment task.
                /// </summary>
                [NameInMap("DeploymentId")]
                [Validation(Required=false)]
                public string DeploymentId { get; set; }

                /// <summary>
                /// The description of the deployment task.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the deployment task was complete.
                /// </summary>
                [NameInMap("GmtCompleted")]
                [Validation(Required=false)]
                public string GmtCompleted { get; set; }

                /// <summary>
                /// The UNIX timestamp when the deployment task was complete.
                /// </summary>
                [NameInMap("GmtCompletedTimestamp")]
                [Validation(Required=false)]
                public long? GmtCompletedTimestamp { get; set; }

                /// <summary>
                /// The time when the deployment task was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The UNIX timestamp when the deployment task was created.
                /// </summary>
                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=false)]
                public long? GmtCreateTimestamp { get; set; }

                /// <summary>
                /// The last time when the deployment task was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The last UNIX timestamp when the deployment task was modified.
                /// </summary>
                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=false)]
                public long? GmtModifiedTimestamp { get; set; }

                /// <summary>
                /// The status of the deployment task.
                /// 
                /// *   0: The task was not started.
                /// *   1: The task was being processed.
                /// *   2: The task was successful.
                /// *   3: The task failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The type of the deployment task.
                /// 
                /// *   deploy: deploys the edge instance.
                /// *   reset: resets the edge instance.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of deployment tasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
