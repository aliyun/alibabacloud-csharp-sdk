// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingResultTablePageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of table profiling results. For the element structure, see the descriptions of the sub-fields.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMetaProfilingResultTablePageResponseBodyData> Data { get; set; }
        public class ListMetaProfilingResultTablePageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The average file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("averageFileSize")]
            [Validation(Required=false)]
            public string AverageFileSize { get; set; }

            /// <summary>
            /// <para>The average partition size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("averagePartitionSize")]
            [Validation(Required=false)]
            public string AveragePartitionSize { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The name of the database, which is used to filter results by database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods</para>
            /// </summary>
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The value of the data partition to which the table belongs, which identifies the partition to which this row of data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20240719</para>
            /// </summary>
            [NameInMap("ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>The type of storage engine used by the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PARQUET</para>
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("fileNum")]
            [Validation(Required=false)]
            public int? FileNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is an external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isExternal")]
            [Validation(Required=false)]
            public int? IsExternal { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isPtTable")]
            [Validation(Required=false)]
            public int? IsPtTable { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a transactional table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isTransactional")]
            [Validation(Required=false)]
            public int? IsTransactional { get; set; }

            /// <summary>
            /// <para>The last access time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("lastAccessed")]
            [Validation(Required=false)]
            public string LastAccessed { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("lastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The creation time of the largest partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("maxPtCrtTime")]
            [Validation(Required=false)]
            public string MaxPtCrtTime { get; set; }

            /// <summary>
            /// <para>The list of largest partitions.</para>
            /// </summary>
            [NameInMap("maximumPartitionList")]
            [Validation(Required=false)]
            public List<string> MaximumPartitionList { get; set; }

            /// <summary>
            /// <para>The migration progress percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("migrationProcess")]
            [Validation(Required=false)]
            public double? MigrationProcess { get; set; }

            /// <summary>
            /// <para>The migration status, which is used to filter by migration progress or indicate the migration status of an object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("migrationStatus")]
            [Validation(Required=false)]
            public string MigrationStatus { get; set; }

            /// <summary>
            /// <para>The creation time of the smallest partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 08:00:00</para>
            /// </summary>
            [NameInMap("minPtCrtTime")]
            [Validation(Required=false)]
            public string MinPtCrtTime { get; set; }

            /// <summary>
            /// <para>The list of smallest partitions.</para>
            /// </summary>
            [NameInMap("minimumPartitionList")]
            [Validation(Required=false)]
            public List<string> MinimumPartitionList { get; set; }

            /// <summary>
            /// <para>Indicates whether the object is newly added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("newAdded")]
            [Validation(Required=false)]
            public int? NewAdded { get; set; }

            /// <summary>
            /// <para>The list of partition field names.</para>
            /// </summary>
            [NameInMap("partitionFieldNameList")]
            [Validation(Required=false)]
            public List<string> PartitionFieldNameList { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("partitionNum")]
            [Validation(Required=false)]
            public int? PartitionNum { get; set; }

            /// <summary>
            /// <para>The number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("recordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            /// <summary>
            /// <para>The data storage size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public string StorageSize { get; set; }

            /// <summary>
            /// <para>The table comment or remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order details table</para>
            /// </summary>
            [NameInMap("tableComment")]
            [Validation(Required=false)]
            public string TableComment { get; set; }

            /// <summary>
            /// <para>The table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5001</para>
            /// </summary>
            [NameInMap("tableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }

            /// <summary>
            /// <para>The last modification time of the table schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("tableModTime")]
            [Validation(Required=false)]
            public string TableModTime { get; set; }

            /// <summary>
            /// <para>The name of the table, which is used to filter results by table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_order_detail</para>
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The identifier of the table type, such as managed table (MANAGED_TABLE) or external table (EXTERNAL_TABLE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED_TABLE</para>
            /// </summary>
            [NameInMap("tableType")]
            [Validation(Required=false)]
            public string TableType { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter is invalid or missing.</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues of this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F45B8C1-2A6E-4C9B-9E1F-7D2A1B0C5E66</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure. If the call fails, troubleshoot the issue based on errCode and errMessage.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
