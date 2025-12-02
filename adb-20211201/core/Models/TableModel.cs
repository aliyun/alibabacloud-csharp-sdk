// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TableModel : TeaModel {
        [NameInMap("ArchiveType")]
        [Validation(Required=false)]
        public string ArchiveType { get; set; }

        [NameInMap("BlockSize")]
        [Validation(Required=false)]
        public long? BlockSize { get; set; }

        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public long? Bucket { get; set; }

        [NameInMap("BucketCount")]
        [Validation(Required=false)]
        public long? BucketCount { get; set; }

        [NameInMap("Cols")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> Cols { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Compression")]
        [Validation(Required=false)]
        public string Compression { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreatedBySource")]
        [Validation(Required=false)]
        public string CreatedBySource { get; set; }

        [NameInMap("CreatedByUser")]
        [Validation(Required=false)]
        public string CreatedByUser { get; set; }

        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public long? CurrentVersion { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DictEncode")]
        [Validation(Required=false)]
        public bool? DictEncode { get; set; }

        [NameInMap("DistributeColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> DistributeColumns { get; set; }

        [NameInMap("DistributeType")]
        [Validation(Required=false)]
        public string DistributeType { get; set; }

        [NameInMap("EnableDfs")]
        [Validation(Required=false)]
        public bool? EnableDfs { get; set; }

        [NameInMap("HotPartitionCount")]
        [Validation(Required=false)]
        public long? HotPartitionCount { get; set; }

        [NameInMap("Indexes")]
        [Validation(Required=false)]
        public List<CstoreIndexModel> Indexes { get; set; }

        [NameInMap("IsAllIndex")]
        [Validation(Required=false)]
        public bool? IsAllIndex { get; set; }

        [NameInMap("IsFulltextDict")]
        [Validation(Required=false)]
        public bool? IsFulltextDict { get; set; }

        [NameInMap("MaxColumnId")]
        [Validation(Required=false)]
        public long? MaxColumnId { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("PartitionColumn")]
        [Validation(Required=false)]
        public string PartitionColumn { get; set; }

        [NameInMap("PartitionCount")]
        [Validation(Required=false)]
        public long? PartitionCount { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> PartitionKeys { get; set; }

        [NameInMap("PartitionType")]
        [Validation(Required=false)]
        public string PartitionType { get; set; }

        [NameInMap("PhysicalDatabaseName")]
        [Validation(Required=false)]
        public string PhysicalDatabaseName { get; set; }

        [NameInMap("PhysicalTableName")]
        [Validation(Required=false)]
        public string PhysicalTableName { get; set; }

        [NameInMap("PreviousVersion")]
        [Validation(Required=false)]
        public long? PreviousVersion { get; set; }

        [NameInMap("RawTableName")]
        [Validation(Required=false)]
        public string RawTableName { get; set; }

        [NameInMap("RouteColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> RouteColumns { get; set; }

        [NameInMap("RouteEffectiveColumn")]
        [Validation(Required=false)]
        public FieldSchemaModel RouteEffectiveColumn { get; set; }

        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        [NameInMap("RtEngineType")]
        [Validation(Required=false)]
        public string RtEngineType { get; set; }

        [NameInMap("RtIndexAll")]
        [Validation(Required=false)]
        public bool? RtIndexAll { get; set; }

        [NameInMap("RtModeType")]
        [Validation(Required=false)]
        public string RtModeType { get; set; }

        [NameInMap("Sd")]
        [Validation(Required=false)]
        public StorageDescriptorModel Sd { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicy { get; set; }

        [NameInMap("SubpartitionColumn")]
        [Validation(Required=false)]
        public string SubpartitionColumn { get; set; }

        [NameInMap("SubpartitionCount")]
        [Validation(Required=false)]
        public long? SubpartitionCount { get; set; }

        [NameInMap("SubpartitionType")]
        [Validation(Required=false)]
        public string SubpartitionType { get; set; }

        [NameInMap("TableEngineName")]
        [Validation(Required=false)]
        public string TableEngineName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("TblId")]
        [Validation(Required=false)]
        public long? TblId { get; set; }

        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public bool? Temporary { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

        [NameInMap("ViewSecurityMode")]
        [Validation(Required=false)]
        public string ViewSecurityMode { get; set; }

    }

}
