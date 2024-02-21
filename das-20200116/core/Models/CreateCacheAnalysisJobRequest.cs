// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCacheAnalysisJobRequest : TeaModel {
        /// <summary>
        /// The ID of the backup file. You can call the [DescribeBackups](~~61081~~) operation to query the ID.
        /// 
        /// *   If you need to specify multiple backup file IDs, separate them with commas (,). For example, you can set this parameter to `12345,67890`.
        /// *   If you do not specify this parameter, the system automatically backs up the task and performs cache analysis on the backup file.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The ID of the ApsaraDB for Redis instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the data node on the instance. You can specify this parameter to query the monitoring information about the specified node.
        /// 
        /// >  If you specify the BackupSetId parameter, the system ignores the NodeId parameter. You can call the [DescribeLogicInstanceTopology](~~94665~~) operation to query the node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The delimiters used to identify the prefixes of keys. You do not need to specify this parameter if one or more of the following default delimiters are used: `: ; , _ - + @ = | #`
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public string Separators { get; set; }

    }

}
