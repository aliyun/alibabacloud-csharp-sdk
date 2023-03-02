// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDeploymentResponseBody : TeaModel {
        /// <summary>
        /// The data about the deployment task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeploymentResponseBodyData Data { get; set; }
        public class GetDeploymentResponseBodyData : TeaModel {
            [NameInMap("DeployedItems")]
            [Validation(Required=false)]
            public List<GetDeploymentResponseBodyDataDeployedItems> DeployedItems { get; set; }
            public class GetDeploymentResponseBodyDataDeployedItems : TeaModel {
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public long? FileVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The details of the deployment task.
            /// </summary>
            [NameInMap("Deployment")]
            [Validation(Required=false)]
            public GetDeploymentResponseBodyDataDeployment Deployment { get; set; }
            public class GetDeploymentResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// The check status of one or more files in the deployment task. If the value of the ToEnvironment parameter is 1, the files can be deployed to the production environment only when the value of the Status parameter is 1 and the CheckingStatus parameter is empty. Valid values:
                /// 
                /// *   7: The file failed the check.
                /// *   8: The file is being checked.
                /// </summary>
                [NameInMap("CheckingStatus")]
                [Validation(Required=false)]
                public int? CheckingStatus { get; set; }

                /// <summary>
                /// The time when the deployment task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the user who created the deployment task.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The error message that was returned when the deployment task failed. In this case, the value of the Status parameter is 2.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The time when the deployment task was run. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// The environment in which the deployment task was run. Valid values: 0 and 1. A value of 0 indicates the on-premises environment. A value of 1 indicates the development environment.
                /// </summary>
                [NameInMap("FromEnvironment")]
                [Validation(Required=false)]
                public int? FromEnvironment { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the user who ran the deployment task.
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// The name of the deployment task. The value is the same as the name of the specific deployment task that is displayed on the Release Package page in the Deploy module.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the deployment task. Valid values: 0, 1, and 2. A value of 0 indicates that the task is ready. A value of 1 indicates that the task was successful. A value of 2 indicates that the task failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The environment to which the file was deployed. Valid values: 1 and 2. A value of 1 indicates the development environment. A value of 2 indicates the production environment.
                /// </summary>
                [NameInMap("ToEnvironment")]
                [Validation(Required=false)]
                public int? ToEnvironment { get; set; }

            }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
