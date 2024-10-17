// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The parsing result of the data tracking task.</para>
        /// </summary>
        [NameInMap("TrackResult")]
        [Validation(Required=false)]
        public SearchDataTrackResultResponseBodyTrackResult TrackResult { get; set; }
        public class SearchDataTrackResultResponseBodyTrackResult : TeaModel {
            /// <summary>
            /// <para>The details of the event logs.</para>
            /// </summary>
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultEventList> EventList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultEventList : TeaModel {
                /// <summary>
                /// <para>The data records after you perform data operations in the database.</para>
                /// </summary>
                [NameInMap("DataAfter")]
                [Validation(Required=false)]
                public List<string> DataAfter { get; set; }

                /// <summary>
                /// <para>The data records before you perform data operations in the database.</para>
                /// </summary>
                [NameInMap("DataBefore")]
                [Validation(Required=false)]
                public List<string> DataBefore { get; set; }

                /// <summary>
                /// <para>The ID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public long? EventId { get; set; }

                /// <summary>
                /// <para>The length of the event content. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4324</para>
                /// </summary>
                [NameInMap("EventLength")]
                [Validation(Required=false)]
                public long? EventLength { get; set; }

                /// <summary>
                /// <para>The event time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-23 10:25:47</para>
                /// </summary>
                [NameInMap("EventTimestamp")]
                [Validation(Required=false)]
                public string EventTimestamp { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>WRITE_ROWS</b>: indicates an INSERT operation.</description></item>
                /// <item><description><b>UPDATE_ROWS</b>: indicates an UPDATE operation.</description></item>
                /// <item><description><b>DELETE_ROWS</b>: indicates a DELETE operation.</description></item>
                /// <item><description><b>EXT_WRITE_ROWS</b>: indicates an INSERT operation, which is equivalent to WRITE_ROWS.</description></item>
                /// <item><description><b>EXT_UPDATE_ROWS</b>: indicates an UPDATE operation, which is equivalent to UPDATE_ROWS.</description></item>
                /// <item><description><b>EXT_DELETE_ROWS</b>: indicates a DELETE operation, which is equivalent to DELETE_ROWS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE_ROWS</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The SQL statements used to roll back the data change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-- Timestamp:2023-04-23 10:25:47 #1\r\nUPDATE <c>dc_test</c>.<c>tb_chunk_dml</c> SET <c>id</c>=1 , <c>gmt_create</c>=\&quot;2021-09-30T00:00:00\&quot; , <c>content</c>=\&quot;2023-03-30 14:51:50\&quot; , <c>c1</c>=\&quot;2023-04-17 13:42:03\&quot; , <c>c_id</c>=1 , <c>c13425</c>=\&quot;b\\\&quot;\&quot; , <c>c432532535</c>= null , <c>c1432</c>= null , <c>c143243253</c>= null , <c>c1432535</c>= null , <c>c43125325</c>= null , <c>c3425325</c>= null WHERE  (<c>id</c>=1)&quot;</para>
                /// </summary>
                [NameInMap("RollSQL")]
                [Validation(Required=false)]
                public string RollSQL { get; set; }

            }

            /// <summary>
            /// <para>The metadata of tables for which you track data operations.</para>
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultTableInfoList> TableInfoList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultTableInfoList : TeaModel {
                /// <summary>
                /// <para>The information about columns.</para>
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns> Columns { get; set; }
                public class SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>basic_platform</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <para>The position of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ColumnPosition")]
                    [Validation(Required=false)]
                    public int? ColumnPosition { get; set; }

                    /// <summary>
                    /// <para>The data type of the column. Examples: BIGINT, INT, and VARCHAR.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIGINT</para>
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the column is a virtual column. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Fictive")]
                    [Validation(Required=false)]
                    public bool? Fictive { get; set; }

                }

                /// <summary>
                /// <para>The description of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto-description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod_eb_vas</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>import_table_test1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>109</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
