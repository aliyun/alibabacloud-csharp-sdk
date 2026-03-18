// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsDbResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsDbResponseBodyData Data { get; set; }
        public class GetMmsDbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The database description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for mms_test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MaxCompute schema corresponding to the source database. If the destination MaxCompute project does not enable the schema layer, this value is null. By default, this value matches the source database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstName")]
            [Validation(Required=false)]
            public string DstName { get; set; }

            /// <summary>
            /// <para>The name of the destination MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mma_test</para>
            /// </summary>
            [NameInMap("dstProjectName")]
            [Validation(Required=false)]
            public string DstProjectName { get; set; }

            /// <summary>
            /// <para>Other information stored in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The last DDL time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:42</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>The storage location of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdfs://master-1-1.c-6fc187819ed6bae0.cn-shanghai.emr.aliyuncs.com:9000/user/hive/warehouse</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of rows in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public long? NumRows { get; set; }

            /// <summary>
            /// <para>The database owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System user</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("partitions")]
            [Validation(Required=false)]
            public int? Partitions { get; set; }

            /// <summary>
            /// <para>The partitions that are being migrated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("partitionsDoing")]
            [Validation(Required=false)]
            public int? PartitionsDoing { get; set; }

            /// <summary>
            /// <para>The number of partitions whose migration is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1400</para>
            /// </summary>
            [NameInMap("partitionsDone")]
            [Validation(Required=false)]
            public int? PartitionsDone { get; set; }

            /// <summary>
            /// <para>The partitions that failed during migration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("partitionsFailed")]
            [Validation(Required=false)]
            public int? PartitionsFailed { get; set; }

            /// <summary>
            /// <para>The size of the database in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323232332</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000017</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>The migration status. Valid values: INIT, DOING, FAILED, DONE, and PART_DONE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("tables")]
            [Validation(Required=false)]
            public int? Tables { get; set; }

            /// <summary>
            /// <para>The tables that are being migrated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesDoing")]
            [Validation(Required=false)]
            public int? TablesDoing { get; set; }

            /// <summary>
            /// <para>Tables for which migration has completed</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("tablesDone")]
            [Validation(Required=false)]
            public int? TablesDone { get; set; }

            /// <summary>
            /// <para>The tables that failed to migrate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesFailed")]
            [Validation(Required=false)]
            public int? TablesFailed { get; set; }

            /// <summary>
            /// <para>The tables whose migration is partially complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("tablesPartDone")]
            [Validation(Required=false)]
            public int? TablesPartDone { get; set; }

            /// <summary>
            /// <para>Indicates whether the metadata is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public bool? Updated { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90D64EB6-2962-5B1C-A039-BC41C8176C7F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
