// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsPartitionsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsPartitionsResponseBodyData Data { get; set; }
        public class ListMmsPartitionsResponseBodyData : TeaModel {
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsPartitionsResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsPartitionsResponseBodyDataObjectList : TeaModel {
                [NameInMap("dbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d1</para>
                /// </summary>
                [NameInMap("dbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mms_test</para>
                /// </summary>
                [NameInMap("dstProjectName")]
                [Validation(Required=false)]
                public string DstProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("dstSchemaName")]
                [Validation(Required=false)]
                public string DstSchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("dstTableName")]
                [Validation(Required=false)]
                public string DstTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>p1=1/p2=abc</para>
                /// </summary>
                [NameInMap("dstValue")]
                [Validation(Required=false)]
                public string DstValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2323</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>lastDdlTime</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 15:44:42</para>
                /// </summary>
                [NameInMap("lastDdlTime")]
                [Validation(Required=false)]
                public string LastDdlTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2323</para>
                /// </summary>
                [NameInMap("numRows")]
                [Validation(Required=false)]
                public long? NumRows { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23223</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200018</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("sourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DONE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("tableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t1</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("updated")]
                [Validation(Required=false)]
                public bool? Updated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>p1=1/p2=abc</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9F872FD-5DDE-30A6-8C8A-1B8C6A81059F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
