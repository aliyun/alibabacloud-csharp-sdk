// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobResponseBody : TeaModel {
        /// <summary>
        /// The information about the contact.
        /// </summary>
        [NameInMap("CasContacts")]
        [Validation(Required=false)]
        public List<DescribeDeploymentJobResponseBodyCasContacts> CasContacts { get; set; }
        public class DescribeDeploymentJobResponseBodyCasContacts : TeaModel {
            /// <summary>
            /// The email address of the contact.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The ID of the contact.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The phone number of the contact.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// The name of the contact.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

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
        /// *   **free**: free certificate available only on the China site (aliyun.com)
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// The configurations of the deployment task.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// Indicates whether the deployment job was deleted. Valid values:
        /// 
        /// *   **0**: not deleted
        /// *   **1**: deleted
        /// </summary>
        [NameInMap("Del")]
        [Validation(Required=false)]
        public int? Del { get; set; }

        /// <summary>
        /// The end time of the deployment job. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time when the deployment job was created. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// The time when the deployment job was last modified. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// The ID of the deployment job.
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
        /// The type of the deployment job. Valid values:
        /// 
        /// *   **cloud**: multi-cloud deployment job.
        /// *   **trustee**: hosted deployment job available only on the China site (aliyun.com).
        /// *   **user**: cloud service deployment job. The cloud server is not included.
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
        /// The cloud services included in the deployment task.
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the deployment job includes the rollback worker. For example, if a cloud service in a deployment job has been rolled back, **1** is returned. Valid values:
        /// 
        /// *   **0**: The rollback worker is not included.
        /// *   **1**: The rollback worker is included.
        /// </summary>
        [NameInMap("Rollback")]
        [Validation(Required=false)]
        public int? Rollback { get; set; }

        /// <summary>
        /// The time when the deployment job was scheduled. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// The start time of the deployment job. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the deployment job. Valid values:
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
        /// The ID of the Alibaba Cloud account in which the deployment job is created.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
