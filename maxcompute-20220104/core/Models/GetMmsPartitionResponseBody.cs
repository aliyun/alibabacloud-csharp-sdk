// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsPartitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The partition object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsPartitionResponseBodyData Data { get; set; }
        public class GetMmsPartitionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the database that contains the partition. The name for this metadata layer depends on the data source. For example, it is a Dataset in BigQuery, a Database in Hive, or a Schema in Databricks and MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The name of the database. The name for this metadata layer depends on the data source. For example, it is a Dataset in BigQuery, a Database in Hive, or a Schema in Databricks and MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d1</para>
            /// </summary>
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The name of the destination MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("dstProjectName")]
            [Validation(Required=false)]
            public string DstProjectName { get; set; }

            /// <summary>
            /// <para>The name of the destination MaxCompute schema. This parameter is null if the destination MaxCompute project does not use a schema layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstSchemaName")]
            [Validation(Required=false)]
            public string DstSchemaName { get; set; }

            /// <summary>
            /// <para>The name of the destination MaxCompute table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("dstTableName")]
            [Validation(Required=false)]
            public string DstTableName { get; set; }

            /// <summary>
            /// <para>The value of the destination MaxCompute partition. By default, this value is the same as the source partition value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("dstValue")]
            [Validation(Required=false)]
            public string DstValue { get; set; }

            /// <summary>
            /// <para>The partition ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time of the last DDL operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:42</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>The number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public long? NumRows { get; set; }

            /// <summary>
            /// <para>The data size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12323</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200018</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>The migration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("tableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t1</para>
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>Indicates whether the metadata is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public bool? Updated { get; set; }

            /// <summary>
            /// <para>The partition value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9F872FD-5DDE-30A6-8C8A-1B8C6A81059F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
