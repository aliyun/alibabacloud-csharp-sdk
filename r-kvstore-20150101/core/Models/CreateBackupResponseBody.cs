// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the backup task.\
        /// For cluster instances created before December 5, 2023, the return value is a comma-separated list composed of the job ID of each node within an instance. For example, if you have a cluster instance with two shards, the return value of BackupJobID is "10000,10001".\
        /// For cluster instance created after December 5, 2023, all jobs for nodes in an instance are represented by a single job ID.
        /// </summary>
        [NameInMap("BackupJobID")]
        [Validation(Required=false)]
        public string BackupJobID { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
