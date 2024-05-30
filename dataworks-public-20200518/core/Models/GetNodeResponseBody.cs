// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeResponseBody : TeaModel {
        /// <summary>
        /// The details of the node.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNodeResponseBodyData Data { get; set; }
        public class GetNodeResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the node.
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to **GetNode**.
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public long? BusinessId { get; set; }

            /// <summary>
            /// The environment of the workspace. Valid values: PROD and DEV.
            /// </summary>
            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The environment of the workspace. Valid values: PROD and DEV.
            /// </summary>
            [NameInMap("CronExpress")]
            [Validation(Required=false)]
            public string CronExpress { get; set; }

            [NameInMap("DeployDate")]
            [Validation(Required=false)]
            public long? DeployDate { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the node ID.
            /// </summary>
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            [NameInMap("FileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The HTTP status code returned.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// The scheduling type of the node. Valid values:
            /// 
            /// *   NORMAL: The node is an auto triggered node.
            /// *   MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered.
            /// *   PAUSE: The node is a paused node.
            /// *   SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The CRON expression returned.
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// The HTTP status code returned.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The ID of the owner of the node.
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

            /// <summary>
            /// Indicates whether the node can be rerun.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// Indicates whether the node is associated with Data Quality. Valid values: 0 and 1. A value of 0 indicates that the node is associated with Data Quality. A value of 1 indicates that the node is not associated with Data Quality.
            /// </summary>
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }

            /// <summary>
            /// The ID of the workflow to which the node belongs.
            /// </summary>
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }

            /// <summary>
            /// The type of the node.
            /// </summary>
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public string Repeatability { get; set; }

            [NameInMap("ResGroupIdentifier")]
            [Validation(Required=false)]
            public string ResGroupIdentifier { get; set; }

            /// <summary>
            /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
            /// </summary>
            [NameInMap("ResGroupName")]
            [Validation(Required=false)]
            public string ResGroupName { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

        }

        /// <summary>
        /// The ID of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the node ID.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The connection string.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetNode**.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Other parameters.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the workflow.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
