// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ValidateShardTaskRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the PolarDB-X 1.0 instance is created.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the table or table shard on which you want to perform the task.
        /// </summary>
        [NameInMap("SourceTableName")]
        [Validation(Required=false)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// The name of the table or table shard on which you perform the task.
        /// </summary>
        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **SINGLE_TO_SHARD**: converts a single table to a table shard.
        /// *   **SHARD_TO_SINGLE**: converts a table shard to a single table.
        /// *   **SHARD_TO_SHARD**: converts a table shard to another table shard.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
