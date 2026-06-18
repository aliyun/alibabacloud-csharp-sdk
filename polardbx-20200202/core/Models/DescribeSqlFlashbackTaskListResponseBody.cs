// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSqlFlashbackTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned by the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlFlashbackTaskListResponseBodyData Data { get; set; }
        public class DescribeSqlFlashbackTaskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The flashback task objects.</para>
            /// </summary>
            [NameInMap("SqlFlashbackTasks")]
            [Validation(Required=false)]
            public List<DescribeSqlFlashbackTaskListResponseBodyDataSqlFlashbackTasks> SqlFlashbackTasks { get; set; }
            public class DescribeSqlFlashbackTaskListResponseBodyDataSqlFlashbackTasks : TeaModel {
                /// <summary>
                /// <para>The name of the database on which the flashback task was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The download URL of the result file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://...</para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The expiration time of the download URL. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1569216270000</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The creation time of the flashback task in the database. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568611408000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last modification time of the flashback task in the database. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568611469000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The instance ID of the PolarDB-X instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-********</para>
                /// </summary>
                [NameInMap("InstId")]
                [Validation(Required=false)]
                public string InstId { get; set; }

                /// <summary>
                /// <para>The execution progress of the flashback task. Value range: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecallProgress")]
                [Validation(Required=false)]
                public string RecallProgress { get; set; }

                /// <summary>
                /// <para>The SQL flashback restoration type. Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Image-based restoration.</description></item>
                /// <item><description><b>2</b>: Reverse restoration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecallRestoreType")]
                [Validation(Required=false)]
                public string RecallRestoreType { get; set; }

                /// <summary>
                /// <para>The status of the data recall task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: In progress.</description></item>
                /// <item><description><b>2</b>: Completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallStatus")]
                [Validation(Required=false)]
                public string RecallStatus { get; set; }

                /// <summary>
                /// <para>The recall type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: exact match.</description></item>
                /// <item><description><b>1</b>: fuzzy match.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public string RecallType { get; set; }

                /// <summary>
                /// <para>The end time specified when the SQL flashback task was submitted. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568609597000</para>
                /// </summary>
                [NameInMap("SearchEndTime")]
                [Validation(Required=false)]
                public string SearchEndTime { get; set; }

                /// <summary>
                /// <para>The start time specified when the SQL flashback task was submitted. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568609597000</para>
                /// </summary>
                [NameInMap("SearchStartTime")]
                [Validation(Required=false)]
                public string SearchStartTime { get; set; }

                /// <summary>
                /// <para>The number of recovered data rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SqlCounter")]
                [Validation(Required=false)]
                public string SqlCounter { get; set; }

                /// <summary>
                /// <para>The primary key value involved in the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("SqlPk")]
                [Validation(Required=false)]
                public string SqlPk { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement. Valid values: INSERT, UPDATE, and DELETE. Multiple types are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSERT,UPDATE</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The name of the table to which the data belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The trace_id of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13ed05705f801000</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
