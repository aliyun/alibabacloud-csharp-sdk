// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceMissingIndexListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceMissingIndexListResponseBodyData Data { get; set; }
        public class GetInstanceMissingIndexListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetInstanceMissingIndexListResponseBodyDataList> List { get; set; }
            public class GetInstanceMissingIndexListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The average cost savings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.67</para>
                /// </summary>
                [NameInMap("AvgTotalUserCost")]
                [Validation(Required=false)]
                public double? AvgTotalUserCost { get; set; }

                /// <summary>
                /// <para>The performance improvement, in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>98.3</para>
                /// </summary>
                [NameInMap("AvgUserImpact")]
                [Validation(Required=false)]
                public double? AvgUserImpact { get; set; }

                /// <summary>
                /// <para>The statement used to create the missing indexes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE INDEX [IX_CLOUDDBA_school_dbo_stu@col1_@col2] ON [school].[dbo].<a href="%5Bcol1%5D,%5Bcol2%5D,%5Bcol3%5D">stu</a> INCLUDE ([col4],[col5]) WITH (FILLFACTOR = 90, ONLINE = OFF);</para>
                /// </summary>
                [NameInMap("CreateIndex")]
                [Validation(Required=false)]
                public string CreateIndex { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>school</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>The index columns included in the equal operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1,col2,col3</para>
                /// </summary>
                [NameInMap("EqualityColumns")]
                [Validation(Required=false)]
                public string EqualityColumns { get; set; }

                /// <summary>
                /// <para>The columns on which indexes are missing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col3,col4</para>
                /// </summary>
                [NameInMap("IncludedColumns")]
                [Validation(Required=false)]
                public string IncludedColumns { get; set; }

                /// <summary>
                /// <para>The number of indexes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IndexCount")]
                [Validation(Required=false)]
                public long? IndexCount { get; set; }

                /// <summary>
                /// <para>The index columns included in the not equal operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2392</para>
                /// </summary>
                [NameInMap("InequalityColumns")]
                [Validation(Required=false)]
                public string InequalityColumns { get; set; }

                /// <summary>
                /// <para>The last seek time of a user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702023327000</para>
                /// </summary>
                [NameInMap("LastUserSeek")]
                [Validation(Required=false)]
                public long? LastUserSeek { get; set; }

                /// <summary>
                /// <para>The object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stu</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The total number of returned pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5025</para>
                /// </summary>
                [NameInMap("ReservedPages")]
                [Validation(Required=false)]
                public long? ReservedPages { get; set; }

                /// <summary>
                /// <para>The table size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.26</para>
                /// </summary>
                [NameInMap("ReservedSize")]
                [Validation(Required=false)]
                public double? ReservedSize { get; set; }

                /// <summary>
                /// <para>The number of table rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>226945</para>
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// <para>The schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbo</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The number of scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SystemScans")]
                [Validation(Required=false)]
                public long? SystemScans { get; set; }

                /// <summary>
                /// <para>The number of seeks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SystemSeeks")]
                [Validation(Required=false)]
                public long? SystemSeeks { get; set; }

                /// <summary>
                /// <para>The number of compilations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2392</para>
                /// </summary>
                [NameInMap("UniqueCompiles")]
                [Validation(Required=false)]
                public long? UniqueCompiles { get; set; }

                /// <summary>
                /// <para>The number of scans performed by users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UserScans")]
                [Validation(Required=false)]
                public long? UserScans { get; set; }

                /// <summary>
                /// <para>The number of seeks performed by users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1081</para>
                /// </summary>
                [NameInMap("UserSeeks")]
                [Validation(Required=false)]
                public long? UserSeeks { get; set; }

            }

            /// <summary>
            /// <para>The page number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
