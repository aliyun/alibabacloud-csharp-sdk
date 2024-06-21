// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeUniBackupPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeUniBackupPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the anti-ransomware policies.
        /// </summary>
        [NameInMap("UniBackupPolicies")]
        [Validation(Required=false)]
        public List<DescribeUniBackupPoliciesResponseBodyUniBackupPolicies> UniBackupPolicies { get; set; }
        public class DescribeUniBackupPoliciesResponseBodyUniBackupPolicies : TeaModel {
            /// <summary>
            /// The error message for the anti-ransomware agent.
            /// </summary>
            [NameInMap("AgentErrorMessage")]
            [Validation(Required=false)]
            public string AgentErrorMessage { get; set; }

            /// <summary>
            /// The status of the agent. Valid values:
            /// 
            /// *   **UNKNOWN**
            /// *   **INSTALLED**
            /// *   **INSTALL_FAILED**
            /// *   **UNINSTALL_FAILED**
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The type of the database. Valid values:
            /// 
            /// *   **MYSQL**
            /// *   **MSSQL**
            /// *   **Oracle**
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// The error code returned when the backup task fails.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message for the anti-ransomware policy.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The status of the Elastic Compute Service (ECS) instance. Valid values:
            /// 
            /// *   **Stopped**
            /// *   **Running**
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The UUID of the agent that is used to back up the data of the database.
            /// </summary>
            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            /// <summary>
            /// The execution result of the last backup task.
            /// </summary>
            [NameInMap("LatestBackResult")]
            [Validation(Required=false)]
            public string LatestBackResult { get; set; }

            /// <summary>
            /// The time when the last backup task was executed.
            /// </summary>
            [NameInMap("LatestBackupTime")]
            [Validation(Required=false)]
            public string LatestBackupTime { get; set; }

            /// <summary>
            /// The status of the backup task. Valid values:
            /// 
            /// *   **init**
            /// *   **running**
            /// *   **completed**
            /// *   **restoring**
            /// *   **creating**
            /// *   **created**
            /// </summary>
            [NameInMap("PlanStatus")]
            [Validation(Required=false)]
            public string PlanStatus { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **initiating**
            /// *   **opening**
            /// *   **closing**
            /// *   **deleting**
            /// *   **enabled**
            /// *   **disabled**
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// The region ID of the server that hosts the database.
            /// </summary>
            [NameInMap("UniRegionId")]
            [Validation(Required=false)]
            public string UniRegionId { get; set; }

        }

    }

}
