// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CacheLoadTaskInfo : TeaModel {
        /// <summary>
        /// <para>The data catalog ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-xxxx</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The number of files with completed cache loading.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("completedFiles")]
        [Validation(Required=false)]
        public long? CompletedFiles { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database_name</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The number of enumerated files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("enumeratedFiles")]
        [Validation(Required=false)]
        public long? EnumeratedFiles { get; set; }

        /// <summary>
        /// <para>The file enumeration completion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enumerationDone")]
        [Validation(Required=false)]
        public bool? EnumerationDone { get; set; }

        /// <summary>
        /// <para>The additional parameters.</para>
        /// </summary>
        [NameInMap("extraOptions")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraOptions { get; set; }

        /// <summary>
        /// <para>The number of files with failed cache loading.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("failedFiles")]
        [Validation(Required=false)]
        public long? FailedFiles { get; set; }

        /// <summary>
        /// <para>The most recent error message, which is empty when the status is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("lastError")]
        [Validation(Required=false)]
        public string LastError { get; set; }

        /// <summary>
        /// <para>The number of bytes loaded into the cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("loadedBytes")]
        [Validation(Required=false)]
        public long? LoadedBytes { get; set; }

        /// <summary>
        /// <para>The storage location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://clg-xxxx/db-xxxx/tbl-xxxx</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The start time of the task execution, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790576716926</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public long? StartedAt { get; set; }

        /// <summary>
        /// <para>The task execution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lc-81afc0f7812ec737-1790576716926</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task update time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790576746926</para>
        /// </summary>
        [NameInMap("taskUpdatedAt")]
        [Validation(Required=false)]
        public long? TaskUpdatedAt { get; set; }

        /// <summary>
        /// <para>The total number of bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("totalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        /// <summary>
        /// <para>The total number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalFiles")]
        [Validation(Required=false)]
        public long? TotalFiles { get; set; }

    }

}
