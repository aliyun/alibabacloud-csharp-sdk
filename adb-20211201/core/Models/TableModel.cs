// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TableModel : TeaModel {
        /// <summary>
        /// <para>The archive type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ArchiveType</para>
        /// </summary>
        [NameInMap("ArchiveType")]
        [Validation(Required=false)]
        public string ArchiveType { get; set; }

        /// <summary>
        /// <para>The block size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("BlockSize")]
        [Validation(Required=false)]
        public long? BlockSize { get; set; }

        /// <summary>
        /// <para>The bucket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public long? Bucket { get; set; }

        /// <summary>
        /// <para>The number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("BucketCount")]
        [Validation(Required=false)]
        public long? BucketCount { get; set; }

        /// <summary>
        /// <para>The column information.</para>
        /// </summary>
        [NameInMap("Cols")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> Cols { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The compression method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Compression</para>
        /// </summary>
        [NameInMap("Compression")]
        [Validation(Required=false)]
        public string Compression { get; set; }

        /// <summary>
        /// <para>The time when the table was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBySource")]
        [Validation(Required=false)]
        public string CreatedBySource { get; set; }

        [NameInMap("CreatedByUser")]
        [Validation(Required=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// <para>The current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public long? CurrentVersion { get; set; }

        /// <summary>
        /// <para>The name of the logical database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Indicates whether the dictionary is encrypted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DictEncode")]
        [Validation(Required=false)]
        public bool? DictEncode { get; set; }

        /// <summary>
        /// <para>The distribution columns.</para>
        /// </summary>
        [NameInMap("DistributeColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> DistributeColumns { get; set; }

        /// <summary>
        /// <para>The distribution type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DistributeType</para>
        /// </summary>
        [NameInMap("DistributeType")]
        [Validation(Required=false)]
        public string DistributeType { get; set; }

        /// <summary>
        /// <para>Indicates whether DFS is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDfs")]
        [Validation(Required=false)]
        public bool? EnableDfs { get; set; }

        /// <summary>
        /// <para>The number of hot partitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("HotPartitionCount")]
        [Validation(Required=false)]
        public long? HotPartitionCount { get; set; }

        /// <summary>
        /// <para>The indexes.</para>
        /// </summary>
        [NameInMap("Indexes")]
        [Validation(Required=false)]
        public List<CstoreIndexModel> Indexes { get; set; }

        /// <summary>
        /// <para>Indicates whether the index is a full index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAllIndex")]
        [Validation(Required=false)]
        public bool? IsAllIndex { get; set; }

        /// <summary>
        /// <para>Indicates whether the table is a full-text index dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFulltextDict")]
        [Validation(Required=false)]
        public bool? IsFulltextDict { get; set; }

        /// <summary>
        /// <para>The maximum column ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxColumnId</para>
        /// </summary>
        [NameInMap("MaxColumnId")]
        [Validation(Required=false)]
        public long? MaxColumnId { get; set; }

        /// <summary>
        /// <para>The parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// <para>The information about the partition key column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>colName</para>
        /// </summary>
        [NameInMap("PartitionColumn")]
        [Validation(Required=false)]
        public string PartitionColumn { get; set; }

        /// <summary>
        /// <para>The number of partitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("PartitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        /// <summary>
        /// <para>The partition keys.</para>
        /// </summary>
        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> PartitionKeys { get; set; }

        /// <summary>
        /// <para>The partition type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PartitionType</para>
        /// </summary>
        [NameInMap("PartitionType")]
        [Validation(Required=false)]
        public string PartitionType { get; set; }

        /// <summary>
        /// <para>The name of the physical database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>physicalDatabaseName</para>
        /// </summary>
        [NameInMap("PhysicalDatabaseName")]
        [Validation(Required=false)]
        public string PhysicalDatabaseName { get; set; }

        /// <summary>
        /// <para>The name of the physical table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>physicalTableName</para>
        /// </summary>
        [NameInMap("PhysicalTableName")]
        [Validation(Required=false)]
        public string PhysicalTableName { get; set; }

        /// <summary>
        /// <para>The previous version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PreviousVersion")]
        [Validation(Required=false)]
        public long? PreviousVersion { get; set; }

        /// <summary>
        /// <para>The raw table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RawTableName</para>
        /// </summary>
        [NameInMap("RawTableName")]
        [Validation(Required=false)]
        public string RawTableName { get; set; }

        /// <summary>
        /// <para>The routing columns.</para>
        /// </summary>
        [NameInMap("RouteColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> RouteColumns { get; set; }

        /// <summary>
        /// <para>The effective routing column.</para>
        /// </summary>
        [NameInMap("RouteEffectiveColumn")]
        [Validation(Required=false)]
        public FieldSchemaModel RouteEffectiveColumn { get; set; }

        /// <summary>
        /// <para>The routing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routeType</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// <para>The routing engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RtEngineType</para>
        /// </summary>
        [NameInMap("RtEngineType")]
        [Validation(Required=false)]
        public string RtEngineType { get; set; }

        /// <summary>
        /// <para>Indicates whether to route all indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RtIndexAll")]
        [Validation(Required=false)]
        public bool? RtIndexAll { get; set; }

        /// <summary>
        /// <para>The routing mode type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RtModeType</para>
        /// </summary>
        [NameInMap("RtModeType")]
        [Validation(Required=false)]
        public string RtModeType { get; set; }

        /// <summary>
        /// <para>The description of the storage.</para>
        /// </summary>
        [NameInMap("Sd")]
        [Validation(Required=false)]
        public StorageDescriptorModel Sd { get; set; }

        /// <summary>
        /// <para>The storage policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StoragePolicy</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicy { get; set; }

        /// <summary>
        /// <para>The information about the subpartition column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SubpartitionColumn</para>
        /// </summary>
        [NameInMap("SubpartitionColumn")]
        [Validation(Required=false)]
        public string SubpartitionColumn { get; set; }

        /// <summary>
        /// <para>The number of subpartitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("SubpartitionCount")]
        [Validation(Required=false)]
        public long? SubpartitionCount { get; set; }

        /// <summary>
        /// <para>The subpartition type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SubpartitionColumn</para>
        /// </summary>
        [NameInMap("SubpartitionType")]
        [Validation(Required=false)]
        public string SubpartitionType { get; set; }

        /// <summary>
        /// <para>The name of the table engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("TableEngineName")]
        [Validation(Required=false)]
        public string TableEngineName { get; set; }

        /// <summary>
        /// <para>The name of the logical table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The table type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>external_table</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <para>The table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TblId")]
        [Validation(Required=false)]
        public long? TblId { get; set; }

        /// <summary>
        /// <para>Indicates whether the table is a temporary table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public bool? Temporary { get; set; }

        /// <summary>
        /// <para>The time when the table was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The normalized SQL statement that is used to create the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ViewExpandedText</para>
        /// </summary>
        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        /// <summary>
        /// <para>The SQL statement used to create the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ViewOriginalText</para>
        /// </summary>
        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

        /// <summary>
        /// <para>The security mode of the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ViewSecurityMode</para>
        /// </summary>
        [NameInMap("ViewSecurityMode")]
        [Validation(Required=false)]
        public string ViewSecurityMode { get; set; }

    }

}
