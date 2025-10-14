// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSqlFlashbackTaskListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlFlashbackTaskListResponseBodyData Data { get; set; }
        public class DescribeSqlFlashbackTaskListResponseBodyData : TeaModel {
            [NameInMap("SqlFlashbackTasks")]
            [Validation(Required=false)]
            public List<DescribeSqlFlashbackTaskListResponseBodyDataSqlFlashbackTasks> SqlFlashbackTasks { get; set; }
            public class DescribeSqlFlashbackTaskListResponseBodyDataSqlFlashbackTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http://...</para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1569216270000</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568611408000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568611469000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-********</para>
                /// </summary>
                [NameInMap("InstId")]
                [Validation(Required=false)]
                public string InstId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecallProgress")]
                [Validation(Required=false)]
                public string RecallProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecallRestoreType")]
                [Validation(Required=false)]
                public string RecallRestoreType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecallStatus")]
                [Validation(Required=false)]
                public string RecallStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public string RecallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568609597000</para>
                /// </summary>
                [NameInMap("SearchEndTime")]
                [Validation(Required=false)]
                public string SearchEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568609597000</para>
                /// </summary>
                [NameInMap("SearchStartTime")]
                [Validation(Required=false)]
                public string SearchStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SqlCounter")]
                [Validation(Required=false)]
                public string SqlCounter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("SqlPk")]
                [Validation(Required=false)]
                public string SqlPk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INSERT,UPDATE</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13ed05705f801000</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
