// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsJobRequest : TeaModel {
        [NameInMap("columnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ColumnMapping { get; set; }

        [NameInMap("dstDbName")]
        [Validation(Required=false)]
        public string DstDbName { get; set; }

        [NameInMap("dstSchemaName")]
        [Validation(Required=false)]
        public string DstSchemaName { get; set; }

        [NameInMap("enableVerification")]
        [Validation(Required=false)]
        public bool? EnableVerification { get; set; }

        [NameInMap("eta")]
        [Validation(Required=false)]
        public string Eta { get; set; }

        [NameInMap("increment")]
        [Validation(Required=false)]
        public bool? Increment { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("others")]
        [Validation(Required=false)]
        public Dictionary<string, object> Others { get; set; }

        [NameInMap("partitionFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> PartitionFilters { get; set; }

        [NameInMap("partitions")]
        [Validation(Required=false)]
        public List<long?> Partitions { get; set; }

        [NameInMap("schemaOnly")]
        [Validation(Required=false)]
        public bool? SchemaOnly { get; set; }

        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        [NameInMap("sourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

        [NameInMap("srcSchemaName")]
        [Validation(Required=false)]
        public string SrcSchemaName { get; set; }

        [NameInMap("tableBlackList")]
        [Validation(Required=false)]
        public List<string> TableBlackList { get; set; }

        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> TableMapping { get; set; }

        [NameInMap("tableWhiteList")]
        [Validation(Required=false)]
        public List<string> TableWhiteList { get; set; }

        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<string> Tables { get; set; }

        /// <summary>
        /// <para>MOCK, HIVE: hive udtf task, HIVE_DATAX: hive datax task, COPY_TASK: odps Copy Task, ODPS_INSERT_OVERWRITE: odps simple insert overwrite task, MC2MC_VERIFY, OSS, HIVE_OSS</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
