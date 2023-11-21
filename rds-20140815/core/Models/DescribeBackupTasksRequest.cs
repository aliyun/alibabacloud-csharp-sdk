// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupTasksRequest : TeaModel {
        /// <summary>
        /// The ID of the backup task.
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public int? BackupJobId { get; set; }

        /// <summary>
        /// The status of the backup task. Valid values:
        /// 
        /// *   **NoStart**
        /// *   **Progressing**
        /// 
        /// By default, this operation returns backup tasks in both states.
        /// </summary>
        [NameInMap("BackupJobStatus")]
        [Validation(Required=false)]
        public string BackupJobStatus { get; set; }

        /// <summary>
        /// The backup mode. Valid values:
        /// 
        /// *   **Automated**
        /// *   **Manual**
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// Specifies the client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("Flag")]
        [Validation(Required=false)]
        public string Flag { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
