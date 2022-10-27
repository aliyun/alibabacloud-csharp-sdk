// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOmsOpenAPIProjectResponseBody : TeaModel {
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOmsOpenAPIProjectResponseBodyData Data { get; set; }
        public class DescribeOmsOpenAPIProjectResponseBodyData : TeaModel {
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            [NameInMap("DestConfig")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectResponseBodyDataDestConfig DestConfig { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataDestConfig : TeaModel {
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

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeOmsOpenAPIProjectResponseBodyDataLabels> Labels { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataLabels : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("ProjectOwner")]
            [Validation(Required=false)]
            public string ProjectOwner { get; set; }

            [NameInMap("SourceConfig")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectResponseBodyDataSourceConfig SourceConfig { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataSourceConfig : TeaModel {
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

            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<DescribeOmsOpenAPIProjectResponseBodyDataSteps> Steps { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataSteps : TeaModel {
                [NameInMap("EstimatedRemainingSeconds")]
                [Validation(Required=false)]
                public long? EstimatedRemainingSeconds { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeOmsOpenAPIProjectResponseBodyDataStepsExtraInfo ExtraInfo { get; set; }
                public class DescribeOmsOpenAPIProjectResponseBodyDataStepsExtraInfo : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorDetails")]
                    [Validation(Required=false)]
                    public List<DescribeOmsOpenAPIProjectResponseBodyDataStepsExtraInfoErrorDetails> ErrorDetails { get; set; }
                    public class DescribeOmsOpenAPIProjectResponseBodyDataStepsExtraInfoErrorDetails : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        [NameInMap("Proposal")]
                        [Validation(Required=false)]
                        public string Proposal { get; set; }

                    }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("ErrorParam")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorParam { get; set; }

                    [NameInMap("FailedTime")]
                    [Validation(Required=false)]
                    public string FailedTime { get; set; }

                }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StepDescription")]
                [Validation(Required=false)]
                public string StepDescription { get; set; }

                [NameInMap("StepInfo")]
                [Validation(Required=false)]
                public DescribeOmsOpenAPIProjectResponseBodyDataStepsStepInfo StepInfo { get; set; }
                public class DescribeOmsOpenAPIProjectResponseBodyDataStepsStepInfo : TeaModel {
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public long? Capacity { get; set; }

                    [NameInMap("Checkpoint")]
                    [Validation(Required=false)]
                    public string Checkpoint { get; set; }

                    [NameInMap("ConnectorFullProgressOverview")]
                    [Validation(Required=false)]
                    public DescribeOmsOpenAPIProjectResponseBodyDataStepsStepInfoConnectorFullProgressOverview ConnectorFullProgressOverview { get; set; }
                    public class DescribeOmsOpenAPIProjectResponseBodyDataStepsStepInfoConnectorFullProgressOverview : TeaModel {
                        [NameInMap("EstimatedRemainingTimeOfSec")]
                        [Validation(Required=false)]
                        public long? EstimatedRemainingTimeOfSec { get; set; }

                        [NameInMap("EstimatedTotalCount")]
                        [Validation(Required=false)]
                        public long? EstimatedTotalCount { get; set; }

                        [NameInMap("FinishedCount")]
                        [Validation(Required=false)]
                        public long? FinishedCount { get; set; }

                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public int? Progress { get; set; }

                    }

                    [NameInMap("DeployId")]
                    [Validation(Required=false)]
                    public string DeployId { get; set; }

                    [NameInMap("DstIops")]
                    [Validation(Required=false)]
                    public long? DstIops { get; set; }

                    [NameInMap("DstRps")]
                    [Validation(Required=false)]
                    public long? DstRps { get; set; }

                    [NameInMap("DstRpsRef")]
                    [Validation(Required=false)]
                    public long? DstRpsRef { get; set; }

                    [NameInMap("DstRt")]
                    [Validation(Required=false)]
                    public long? DstRt { get; set; }

                    [NameInMap("DstRtRef")]
                    [Validation(Required=false)]
                    public long? DstRtRef { get; set; }

                    [NameInMap("Gmt")]
                    [Validation(Required=false)]
                    public long? Gmt { get; set; }

                    [NameInMap("Inconsistencies")]
                    [Validation(Required=false)]
                    public long? Inconsistencies { get; set; }

                    [NameInMap("IncrTimestampCheckpoint")]
                    [Validation(Required=false)]
                    public long? IncrTimestampCheckpoint { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("ProcessedRecords")]
                    [Validation(Required=false)]
                    public long? ProcessedRecords { get; set; }

                    [NameInMap("Skipped")]
                    [Validation(Required=false)]
                    public bool? Skipped { get; set; }

                    [NameInMap("SrcIops")]
                    [Validation(Required=false)]
                    public long? SrcIops { get; set; }

                    [NameInMap("SrcIopsRef")]
                    [Validation(Required=false)]
                    public long? SrcIopsRef { get; set; }

                    [NameInMap("SrcRps")]
                    [Validation(Required=false)]
                    public long? SrcRps { get; set; }

                    [NameInMap("SrcRpsRef")]
                    [Validation(Required=false)]
                    public long? SrcRpsRef { get; set; }

                    [NameInMap("SrcRt")]
                    [Validation(Required=false)]
                    public long? SrcRt { get; set; }

                    [NameInMap("SrcRtRef")]
                    [Validation(Required=false)]
                    public long? SrcRtRef { get; set; }

                    [NameInMap("Validated")]
                    [Validation(Required=false)]
                    public bool? Validated { get; set; }

                }

                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

                [NameInMap("StepOrder")]
                [Validation(Required=false)]
                public int? StepOrder { get; set; }

                [NameInMap("StepProgress")]
                [Validation(Required=false)]
                public int? StepProgress { get; set; }

                [NameInMap("StepStatus")]
                [Validation(Required=false)]
                public string StepStatus { get; set; }

            }

            [NameInMap("TransferMapping")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectResponseBodyDataTransferMapping TransferMapping { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataTransferMapping : TeaModel {
                [NameInMap("Databases")]
                [Validation(Required=false)]
                public List<DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabases> Databases { get; set; }
                public class DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabases : TeaModel {
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
                    public List<DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabasesTables> Tables { get; set; }
                    public class DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabasesTables : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeOmsOpenAPIProjectResponseBodyDataTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
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
            public DescribeOmsOpenAPIProjectResponseBodyDataTransferStepConfig TransferStepConfig { get; set; }
            public class DescribeOmsOpenAPIProjectResponseBodyDataTransferStepConfig : TeaModel {
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
                public DescribeOmsOpenAPIProjectResponseBodyDataTransferStepConfigIncrSyncStepTransferConfig IncrSyncStepTransferConfig { get; set; }
                public class DescribeOmsOpenAPIProjectResponseBodyDataTransferStepConfigIncrSyncStepTransferConfig : TeaModel {
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

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeOmsOpenAPIProjectResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeOmsOpenAPIProjectResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
