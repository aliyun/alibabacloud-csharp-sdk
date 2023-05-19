// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsOpenAPIProjectRequest : TeaModel {
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        [NameInMap("DestConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestDestConfig DestConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestDestConfig : TeaModel {
            [NameInMap("EnableMsgTrace")]
            [Validation(Required=false)]
            public bool? EnableMsgTrace { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("MsgTags")]
            [Validation(Required=false)]
            public string MsgTags { get; set; }

            [NameInMap("Partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            [NameInMap("PartitionMode")]
            [Validation(Required=false)]
            public string PartitionMode { get; set; }

            [NameInMap("ProducerGroup")]
            [Validation(Required=false)]
            public string ProducerGroup { get; set; }

            [NameInMap("SendMsgTimeout")]
            [Validation(Required=false)]
            public long? SendMsgTimeout { get; set; }

            [NameInMap("SequenceEnable")]
            [Validation(Required=false)]
            public bool? SequenceEnable { get; set; }

            [NameInMap("SequenceStartTimestamp")]
            [Validation(Required=false)]
            public long? SequenceStartTimestamp { get; set; }

            [NameInMap("SerializerType")]
            [Validation(Required=false)]
            public string SerializerType { get; set; }

            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public List<string> LabelIds { get; set; }

        /// <summary>
        /// 页序号，分页查询时生效
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 页大小，分页查询时生效
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestSourceConfig SourceConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestSourceConfig : TeaModel {
            [NameInMap("EnableMsgTrace")]
            [Validation(Required=false)]
            public bool? EnableMsgTrace { get; set; }

            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("MsgTags")]
            [Validation(Required=false)]
            public string MsgTags { get; set; }

            [NameInMap("Partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

            [NameInMap("PartitionMode")]
            [Validation(Required=false)]
            public string PartitionMode { get; set; }

            [NameInMap("ProducerGroup")]
            [Validation(Required=false)]
            public string ProducerGroup { get; set; }

            [NameInMap("SendMsgTimeout")]
            [Validation(Required=false)]
            public long? SendMsgTimeout { get; set; }

            [NameInMap("SequenceEnable")]
            [Validation(Required=false)]
            public bool? SequenceEnable { get; set; }

            [NameInMap("SequenceStartTimestamp")]
            [Validation(Required=false)]
            public long? SequenceStartTimestamp { get; set; }

            [NameInMap("SerializerType")]
            [Validation(Required=false)]
            public string SerializerType { get; set; }

            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

        }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestTransferMapping TransferMapping { get; set; }
        public class CreateOmsOpenAPIProjectRequestTransferMapping : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<CreateOmsOpenAPIProjectRequestTransferMappingDatabases> Databases { get; set; }
            public class CreateOmsOpenAPIProjectRequestTransferMappingDatabases : TeaModel {
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("MappedName")]
                [Validation(Required=false)]
                public string MappedName { get; set; }

                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTables> Tables { get; set; }
                public class CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTables : TeaModel {
                    [NameInMap("AdbTableSchema")]
                    [Validation(Required=false)]
                    public CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                    public class CreateOmsOpenAPIProjectRequestTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
                        [NameInMap("DistributedKeys")]
                        [Validation(Required=false)]
                        public List<string> DistributedKeys { get; set; }

                        [NameInMap("PartitionLifeCycle")]
                        [Validation(Required=false)]
                        public int? PartitionLifeCycle { get; set; }

                        [NameInMap("PartitionStatement")]
                        [Validation(Required=false)]
                        public string PartitionStatement { get; set; }

                        [NameInMap("PrimaryKeys")]
                        [Validation(Required=false)]
                        public List<string> PrimaryKeys { get; set; }

                    }

                    [NameInMap("FilterColumns")]
                    [Validation(Required=false)]
                    public List<string> FilterColumns { get; set; }

                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    [NameInMap("ShardColumns")]
                    [Validation(Required=false)]
                    public List<string> ShardColumns { get; set; }

                    [NameInMap("TableId")]
                    [Validation(Required=false)]
                    public string TableId { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WhereClause")]
                    [Validation(Required=false)]
                    public string WhereClause { get; set; }

                }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        [NameInMap("TransferStepConfig")]
        [Validation(Required=false)]
        public CreateOmsOpenAPIProjectRequestTransferStepConfig TransferStepConfig { get; set; }
        public class CreateOmsOpenAPIProjectRequestTransferStepConfig : TeaModel {
            [NameInMap("EnableFullSync")]
            [Validation(Required=false)]
            public bool? EnableFullSync { get; set; }

            [NameInMap("EnableIncrSync")]
            [Validation(Required=false)]
            public bool? EnableIncrSync { get; set; }

            [NameInMap("EnableStructSync")]
            [Validation(Required=false)]
            public bool? EnableStructSync { get; set; }

            [NameInMap("IncrSyncStepTransferConfig")]
            [Validation(Required=false)]
            public CreateOmsOpenAPIProjectRequestTransferStepConfigIncrSyncStepTransferConfig IncrSyncStepTransferConfig { get; set; }
            public class CreateOmsOpenAPIProjectRequestTransferStepConfigIncrSyncStepTransferConfig : TeaModel {
                [NameInMap("RecordTypeList")]
                [Validation(Required=false)]
                public List<string> RecordTypeList { get; set; }

                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                [NameInMap("StoreLogKeptHour")]
                [Validation(Required=false)]
                public long? StoreLogKeptHour { get; set; }

                [NameInMap("StoreTransactionEnabled")]
                [Validation(Required=false)]
                public bool? StoreTransactionEnabled { get; set; }

                [NameInMap("TransferStepType")]
                [Validation(Required=false)]
                public string TransferStepType { get; set; }

            }

        }

        /// <summary>
        /// 实例规格 ID，创建项目时生效
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
