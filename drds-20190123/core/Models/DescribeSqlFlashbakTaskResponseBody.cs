// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeSqlFlashbakTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D64DE59-44A1-E541-E0CB-B7E5C4305162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates the information about flashback tasks.</para>
        /// </summary>
        [NameInMap("SqlFlashbackTasks")]
        [Validation(Required=false)]
        public DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks SqlFlashbackTasks { get; set; }
        public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks : TeaModel {
            [NameInMap("SqlFlashbackTask")]
            [Validation(Required=false)]
            public List<DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask> SqlFlashbackTask { get; set; }
            public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask : TeaModel {
                /// <summary>
                /// <para>Indicates the name of the database on which a flashback task is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds_flashback</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>Indicates the download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://...</para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>Indicates the time when the download URL expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1569216270000</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates the point in time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568611408000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Indicates the point in time when the flashback task is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568611469000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the primary key that corresponds to a table used in the flashback task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>238</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdshbga76p6****</para>
                /// </summary>
                [NameInMap("InstId")]
                [Validation(Required=false)]
                public string InstId { get; set; }

                /// <summary>
                /// <para>Indicates the progress of the reverse call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecallProgress")]
                [Validation(Required=false)]
                public int? RecallProgress { get; set; }

                /// <summary>
                /// <para>Indicates the type of the flashback task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: image restoration</description></item>
                /// <item><description><b>2</b>: reverse restoration</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallRestoreType")]
                [Validation(Required=false)]
                public int? RecallRestoreType { get; set; }

                /// <summary>
                /// <para>Indicates the status of the data recall task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallStatus")]
                [Validation(Required=false)]
                public int? RecallStatus { get; set; }

                /// <summary>
                /// <para>Indicates the type of the reverse call. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: exact search</description></item>
                /// <item><description><b>1</b>: fuzzy search</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public int? RecallType { get; set; }

                /// <summary>
                /// <para>Indicates the start time of the reverse call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568509597000</para>
                /// </summary>
                [NameInMap("SearchEndTime")]
                [Validation(Required=false)]
                public long? SearchEndTime { get; set; }

                /// <summary>
                /// <para>Indicates the end time of the reverse call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568609597000</para>
                /// </summary>
                [NameInMap("SearchStartTime")]
                [Validation(Required=false)]
                public long? SearchStartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of data rows that are flashed back.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SqlCounter")]
                [Validation(Required=false)]
                public long? SqlCounter { get; set; }

                /// <summary>
                /// <para>Indicates the primary key specified in the SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("SqlPk")]
                [Validation(Required=false)]
                public string SqlPk { get; set; }

                /// <summary>
                /// <para>Indicates the types of the SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Insert,Update,Delete</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>Indicates the name of the table that contains the data that are flashed back.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds_params</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the trace of the SQL query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trace</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
