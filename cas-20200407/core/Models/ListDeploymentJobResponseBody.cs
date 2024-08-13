// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The data returned for the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResponseBodyData : TeaModel {
            /// <summary>
            /// The domain names bound to the certificate of the deployment task.
            /// </summary>
            [NameInMap("CertDomain")]
            [Validation(Required=false)]
            public string CertDomain { get; set; }

            /// <summary>
            /// The type of the certificate. Valid values:
            /// 
            /// *   **upload**: uploaded certificate
            /// *   **buy**: purchased certificate
            /// *   **free**: free certificate, available only on the China site (aliyun.com)
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// Indicates whether the deployment task is deleted. Valid values:
            /// 
            /// *   **0**: not deleted
            /// *   **1**: deleted
            /// </summary>
            [NameInMap("Del")]
            [Validation(Required=false)]
            public int? Del { get; set; }

            /// <summary>
            /// The end time of the deployment task.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The time when the deployment task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the deployment task was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the deployment task. You can use the ID to query the details and status of the deployment task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The instance ID of the deployment task.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the deployment task.
            /// 
            /// *   **cloud**: multi-cloud deployment task.
            /// *   **user**: cloud service deployment task. This type of task does not support ECS instances.
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// The name of the deployment task.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The cloud service included in the resources of the deployment task.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// Indicates whether the rollback worker is included. For example, if a cloud service involved in a deployment task has been rolled back, **1** is returned. Valid values:
            /// 
            /// *   **0**: The rollback worker is not included.
            /// *   **1**: The rollback worker is included.
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public int? Rollback { get; set; }

            /// <summary>
            /// The time when the deployment task was scheduled.
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// The start time of the deployment task.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the deployment task. Valid values:
            /// 
            /// *   **pending**
            /// *   **editing**
            /// *   **scheduling**
            /// *   **processing**
            /// *   **error**
            /// *   **success**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of deployment tasks per page. Default value: **50**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The total number of deployment tasks returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
