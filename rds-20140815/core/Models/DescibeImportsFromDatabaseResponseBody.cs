// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescibeImportsFromDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The migration tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescibeImportsFromDatabaseResponseBodyItems Items { get; set; }
        public class DescibeImportsFromDatabaseResponseBodyItems : TeaModel {
            [NameInMap("ImportResultFromDB")]
            [Validation(Required=false)]
            public List<DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB> ImportResultFromDB { get; set; }
            public class DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB : TeaModel {
                /// <summary>
                /// <para>The status of the migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStart</b>: The migration task has not started.</description></item>
                /// <item><description><b>FullExporting</b>: The migration task is exporting full data.</description></item>
                /// <item><description><b>FullImporting</b>: The migration task is importing full data.</description></item>
                /// <item><description><b>Success</b>: The migration task is successful.</description></item>
                /// <item><description><b>Failed</b>: The migration task failed.</description></item>
                /// <item><description><b>Canceled</b>: The migration task is canceled.</description></item>
                /// <item><description><b>Canceling</b>: The migration task is being canceled.</description></item>
                /// <item><description><b>IncrementalWaiting</b>: The migration task is waiting to synchronize incremental data.</description></item>
                /// <item><description><b>IncrementalImporting</b>: The migration task is synchronizing incremental data.</description></item>
                /// <item><description><b>StopSyncing</b>: The migration task stops synchronizing data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NotStart</para>
                /// </summary>
                [NameInMap("ImportDataStatus")]
                [Validation(Required=false)]
                public string ImportDataStatus { get; set; }

                /// <summary>
                /// <para>The description of the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("ImportDataStatusDescription")]
                [Validation(Required=false)]
                public string ImportDataStatusDescription { get; set; }

                /// <summary>
                /// <para>The type of the migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Full</b>: full migration</description></item>
                /// <item><description><b>Incremental:</b>: incremental migration</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Full</para>
                /// </summary>
                [NameInMap("ImportDataType")]
                [Validation(Required=false)]
                public string ImportDataType { get; set; }

                /// <summary>
                /// <para>The ID of the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ImportId")]
                [Validation(Required=false)]
                public int? ImportId { get; set; }

                /// <summary>
                /// <para>The time when the migration task synchronized incremental data. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011-06-11T15:00Z</para>
                /// </summary>
                [NameInMap("IncrementalImportingTime")]
                [Validation(Required=false)]
                public string IncrementalImportingTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B000AA91-393D-46F9-8D9B-098E28931A3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
