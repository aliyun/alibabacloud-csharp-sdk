// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateReplicationLinkRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run but does not create the instance. The system checks items such as the request parameters, request format, service limits, and available resources.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, the instance is created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The account of the database that is used for data synchronization.
        /// </summary>
        [NameInMap("ReplicatorAccount")]
        [Validation(Required=false)]
        public string ReplicatorAccount { get; set; }

        /// <summary>
        /// The password of the account.
        /// </summary>
        [NameInMap("ReplicatorPassword")]
        [Validation(Required=false)]
        public string ReplicatorPassword { get; set; }

        /// <summary>
        /// The endpoint of the source instance.
        /// </summary>
        [NameInMap("SourceAddress")]
        [Validation(Required=false)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// The type of the source instance. Valid values:
        /// 
        /// *   **other**: other instances
        /// *   **aliyunRDS**: an ApsaraDB RDS instance
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// The name of the source instance.
        /// 
        /// >  You must specify this parameter if **SourceCategory** is set to **aliyunRDS**.
        /// </summary>
        [NameInMap("SourceInstanceName")]
        [Validation(Required=false)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// The ID of the region where the source instance is located.
        /// 
        /// >  You must specify this parameter if **SourceCategory** is set to **aliyunRDS**.
        /// </summary>
        [NameInMap("SourceInstanceRegionId")]
        [Validation(Required=false)]
        public string SourceInstanceRegionId { get; set; }

        /// <summary>
        /// The port number of the source instance.
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// The task ID of the successful dry run.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The name of the task. You can specify a custom task name. If you do not specify this parameter, ApsaraDB RDS automatically generates a task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
