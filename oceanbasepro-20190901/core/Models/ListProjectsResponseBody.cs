// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectsResponseBody : TeaModel {
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
        public List<ListProjectsResponseBodyData> Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            [NameInMap("AlarmStats")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataAlarmStats AlarmStats { get; set; }
            public class ListProjectsResponseBodyDataAlarmStats : TeaModel {
                [NameInMap("AlarmContent")]
                [Validation(Required=false)]
                public string AlarmContent { get; set; }

                [NameInMap("Alarming")]
                [Validation(Required=false)]
                public bool? Alarming { get; set; }

                [NameInMap("OpenMonitor")]
                [Validation(Required=false)]
                public bool? OpenMonitor { get; set; }

                [NameInMap("RecentlyTriggerCount")]
                [Validation(Required=false)]
                public int? RecentlyTriggerCount { get; set; }

                [NameInMap("RuleToRecentlyTriggerCount")]
                [Validation(Required=false)]
                public Dictionary<string, int?> RuleToRecentlyTriggerCount { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

            [NameInMap("CommonTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataCommonTransferConfig CommonTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataCommonTransferConfig : TeaModel {
                [NameInMap("ActiveActive")]
                [Validation(Required=false)]
                public bool? ActiveActive { get; set; }

                [NameInMap("DataWorksBusinessName")]
                [Validation(Required=false)]
                public string DataWorksBusinessName { get; set; }

                [NameInMap("DatahubTopicType")]
                [Validation(Required=false)]
                public string DatahubTopicType { get; set; }

                [NameInMap("MqPartition")]
                [Validation(Required=false)]
                public int? MqPartition { get; set; }

                [NameInMap("MqPartitionMode")]
                [Validation(Required=false)]
                public string MqPartitionMode { get; set; }

                [NameInMap("MqSerializerType")]
                [Validation(Required=false)]
                public string MqSerializerType { get; set; }

                [NameInMap("RocketMqEnableMsgTrace")]
                [Validation(Required=false)]
                public bool? RocketMqEnableMsgTrace { get; set; }

                [NameInMap("RocketMqMsgTags")]
                [Validation(Required=false)]
                public string RocketMqMsgTags { get; set; }

                [NameInMap("RocketMqProducerGroup")]
                [Validation(Required=false)]
                public string RocketMqProducerGroup { get; set; }

                [NameInMap("RocketMqSendMsgTimeout")]
                [Validation(Required=false)]
                public long? RocketMqSendMsgTimeout { get; set; }

                [NameInMap("TableCategory")]
                [Validation(Required=false)]
                public string TableCategory { get; set; }

            }

            [NameInMap("DestConnId")]
            [Validation(Required=false)]
            public string DestConnId { get; set; }

            [NameInMap("EnableFullTransfer")]
            [Validation(Required=false)]
            public bool? EnableFullTransfer { get; set; }

            [NameInMap("EnableFullVerify")]
            [Validation(Required=false)]
            public bool? EnableFullVerify { get; set; }

            [NameInMap("EnableIncrTransfer")]
            [Validation(Required=false)]
            public bool? EnableIncrTransfer { get; set; }

            [NameInMap("EnableIncrVerify")]
            [Validation(Required=false)]
            public bool? EnableIncrVerify { get; set; }

            [NameInMap("EnableReverseIncrTransfer")]
            [Validation(Required=false)]
            public bool? EnableReverseIncrTransfer { get; set; }

            [NameInMap("EnableStructTransfer")]
            [Validation(Required=false)]
            public bool? EnableStructTransfer { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class ListProjectsResponseBodyDataExtraInfo : TeaModel {
                [NameInMap("AccessObSource")]
                [Validation(Required=false)]
                public bool? AccessObSource { get; set; }

                [NameInMap("IgnoreUnsupportDdl")]
                [Validation(Required=false)]
                public bool? IgnoreUnsupportDdl { get; set; }

                [NameInMap("IncrSyncTimestamp")]
                [Validation(Required=false)]
                public long? IncrSyncTimestamp { get; set; }

                [NameInMap("LogServiceStartCheckpoint")]
                [Validation(Required=false)]
                public long? LogServiceStartCheckpoint { get; set; }

                [NameInMap("MaxConnectorCount")]
                [Validation(Required=false)]
                public int? MaxConnectorCount { get; set; }

                [NameInMap("MonitoringIncr")]
                [Validation(Required=false)]
                public bool? MonitoringIncr { get; set; }

                [NameInMap("OverwriteConfig")]
                [Validation(Required=false)]
                public bool? OverwriteConfig { get; set; }

                [NameInMap("ReverseSubtopics")]
                [Validation(Required=false)]
                public List<string> ReverseSubtopics { get; set; }

                [NameInMap("RunningProgress")]
                [Validation(Required=false)]
                public int? RunningProgress { get; set; }

                [NameInMap("RunningStep")]
                [Validation(Required=false)]
                public string RunningStep { get; set; }

                [NameInMap("SourceStoreKeptHour")]
                [Validation(Required=false)]
                public int? SourceStoreKeptHour { get; set; }

                [NameInMap("StoreIncr")]
                [Validation(Required=false)]
                public bool? StoreIncr { get; set; }

                [NameInMap("SubConds")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataExtraInfoSubCondsValue>> SubConds { get; set; }

                [NameInMap("SubDbs")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataExtraInfoSubDbsValue>> SubDbs { get; set; }

                [NameInMap("SubIds")]
                [Validation(Required=false)]
                public Dictionary<string, string> SubIds { get; set; }

                [NameInMap("Subtopics")]
                [Validation(Required=false)]
                public List<string> Subtopics { get; set; }

                [NameInMap("SyncDelay")]
                [Validation(Required=false)]
                public long? SyncDelay { get; set; }

                [NameInMap("SyncDelaySampleTimestamp")]
                [Validation(Required=false)]
                public long? SyncDelaySampleTimestamp { get; set; }

            }

            [NameInMap("FullTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataFullTransferConfig FullTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataFullTransferConfig : TeaModel {
                [NameInMap("AllowDestTableNotEmpty")]
                [Validation(Required=false)]
                public bool? AllowDestTableNotEmpty { get; set; }

                [NameInMap("FullTransferSpeedMode")]
                [Validation(Required=false)]
                public string FullTransferSpeedMode { get; set; }

                [NameInMap("FullVerifySpeedMode")]
                [Validation(Required=false)]
                public string FullVerifySpeedMode { get; set; }

                [NameInMap("NonePkUkTruncateDstTable")]
                [Validation(Required=false)]
                public bool? NonePkUkTruncateDstTable { get; set; }

            }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Importance")]
            [Validation(Required=false)]
            public string Importance { get; set; }

            [NameInMap("IncrTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataIncrTransferConfig IncrTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataIncrTransferConfig : TeaModel {
                [NameInMap("EnableIncrSyncStatistics")]
                [Validation(Required=false)]
                public bool? EnableIncrSyncStatistics { get; set; }

                [NameInMap("EnableSequencingWithinTxn")]
                [Validation(Required=false)]
                public bool? EnableSequencingWithinTxn { get; set; }

                [NameInMap("IncrSyncConcurrency")]
                [Validation(Required=false)]
                public int? IncrSyncConcurrency { get; set; }

                [NameInMap("RecordTypeWhiteList")]
                [Validation(Required=false)]
                public List<string> RecordTypeWhiteList { get; set; }

                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                [NameInMap("StoreLogKeptHour")]
                [Validation(Required=false)]
                public int? StoreLogKeptHour { get; set; }

            }

            [NameInMap("IsMerging")]
            [Validation(Required=false)]
            public bool? IsMerging { get; set; }

            [NameInMap("IsModifying")]
            [Validation(Required=false)]
            public bool? IsModifying { get; set; }

            [NameInMap("IsSubProject")]
            [Validation(Required=false)]
            public bool? IsSubProject { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyDataLabels> Labels { get; set; }
            public class ListProjectsResponseBodyDataLabels : TeaModel {
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

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("SinkConnectInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataSinkConnectInfo SinkConnectInfo { get; set; }
            public class ListProjectsResponseBodyDataSinkConnectInfo : TeaModel {
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                [NameInMap("ConnExtraAttributes")]
                [Validation(Required=false)]
                public object ConnExtraAttributes { get; set; }

                [NameInMap("ConnectionInfo")]
                [Validation(Required=false)]
                public string ConnectionInfo { get; set; }

                [NameInMap("DbEngine")]
                [Validation(Required=false)]
                public string DbEngine { get; set; }

                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                [NameInMap("EndpointSide")]
                [Validation(Required=false)]
                public string EndpointSide { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("NlsLengthSemantics")]
                [Validation(Required=false)]
                public string NlsLengthSemantics { get; set; }

                [NameInMap("OcpName")]
                [Validation(Required=false)]
                public string OcpName { get; set; }

                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                /// <summary>
                /// Owner。
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceOwner")]
                [Validation(Required=false)]
                public string ResourceOwner { get; set; }

                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("SinkEndpointType")]
            [Validation(Required=false)]
            public string SinkEndpointType { get; set; }

            [NameInMap("SourceConnectInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataSourceConnectInfo SourceConnectInfo { get; set; }
            public class ListProjectsResponseBodyDataSourceConnectInfo : TeaModel {
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                [NameInMap("ConnExtraAttributes")]
                [Validation(Required=false)]
                public object ConnExtraAttributes { get; set; }

                [NameInMap("ConnectionInfo")]
                [Validation(Required=false)]
                public string ConnectionInfo { get; set; }

                [NameInMap("DbEngine")]
                [Validation(Required=false)]
                public string DbEngine { get; set; }

                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                [NameInMap("EndpointSide")]
                [Validation(Required=false)]
                public string EndpointSide { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("NlsLengthSemantics")]
                [Validation(Required=false)]
                public string NlsLengthSemantics { get; set; }

                [NameInMap("OcpName")]
                [Validation(Required=false)]
                public string OcpName { get; set; }

                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                /// <summary>
                /// Owner。
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceOwner")]
                [Validation(Required=false)]
                public string ResourceOwner { get; set; }

                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("SourceEndpointType")]
            [Validation(Required=false)]
            public string SourceEndpointType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyDataSteps> Steps { get; set; }
            public class ListProjectsResponseBodyDataSteps : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataStepsExtraInfo ExtraInfo { get; set; }
                public class ListProjectsResponseBodyDataStepsExtraInfo : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorDetails")]
                    [Validation(Required=false)]
                    public List<ListProjectsResponseBodyDataStepsExtraInfoErrorDetails> ErrorDetails { get; set; }
                    public class ListProjectsResponseBodyDataStepsExtraInfoErrorDetails : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("ExtraContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtraContext { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        [NameInMap("MessageMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> MessageMcmsContext { get; set; }

                        [NameInMap("MessageMcmsKey")]
                        [Validation(Required=false)]
                        public string MessageMcmsKey { get; set; }

                        [NameInMap("Proposal")]
                        [Validation(Required=false)]
                        public string Proposal { get; set; }

                        [NameInMap("ProposalMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> ProposalMcmsContext { get; set; }

                        [NameInMap("ProposalMcmsKey")]
                        [Validation(Required=false)]
                        public string ProposalMcmsKey { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("ReasonMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> ReasonMcmsContext { get; set; }

                        [NameInMap("ReasonMcmsKey")]
                        [Validation(Required=false)]
                        public string ReasonMcmsKey { get; set; }

                        [NameInMap("UpstreamErrorDetail")]
                        [Validation(Required=false)]
                        public object UpstreamErrorDetail { get; set; }

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

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StepInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> StepInfo { get; set; }

            }

            [NameInMap("StructTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataStructTransferConfig StructTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataStructTransferConfig : TeaModel {
                [NameInMap("ByteCharConvertStrategy")]
                [Validation(Required=false)]
                public string ByteCharConvertStrategy { get; set; }

                [NameInMap("DeferIndexCreation")]
                [Validation(Required=false)]
                public bool? DeferIndexCreation { get; set; }

            }

            [NameInMap("TransferMapping")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataTransferMapping TransferMapping { get; set; }
            public class ListProjectsResponseBodyDataTransferMapping : TeaModel {
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WorkerGradeId")]
            [Validation(Required=false)]
            public string WorkerGradeId { get; set; }

            [NameInMap("WorkerGradeInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataWorkerGradeInfo WorkerGradeInfo { get; set; }
            public class ListProjectsResponseBodyDataWorkerGradeInfo : TeaModel {
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("Grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SourceRegion")]
                [Validation(Required=false)]
                public string SourceRegion { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

            }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class ListProjectsResponseBodyErrorDetail : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

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
