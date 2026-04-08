// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsTimerRequest : TeaModel {
        [NameInMap("columnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ColumnMapping { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableDataMigration")]
        [Validation(Required=false)]
        public bool? EnableDataMigration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSchemaMigration")]
        [Validation(Required=false)]
        public bool? EnableSchemaMigration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableVerification")]
        [Validation(Required=false)]
        public bool? EnableVerification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>planA</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000014</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>src_db</para>
        /// </summary>
        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

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
        /// <b>Example:</b>
        /// <para>12:00</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
