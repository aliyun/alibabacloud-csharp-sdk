// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact the administrator.</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProjectResponseBodyData Data { get; set; }
        public class DescribeProjectResponseBodyData : TeaModel {
            [NameInMap("AlarmStats")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataAlarmStats AlarmStats { get; set; }
            public class DescribeProjectResponseBodyDataAlarmStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("AlarmContent")]
                [Validation(Required=false)]
                public string AlarmContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Alarming")]
                [Validation(Required=false)]
                public bool? Alarming { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OpenMonitor")]
                [Validation(Required=false)]
                public bool? OpenMonitor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecentlyTriggerCount")]
                [Validation(Required=false)]
                public int? RecentlyTriggerCount { get; set; }

                [NameInMap("RuleToRecentlyTriggerCount")]
                [Validation(Required=false)]
                public Dictionary<string, int?> RuleToRecentlyTriggerCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

            [NameInMap("CommonTransferConfig")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataCommonTransferConfig CommonTransferConfig { get; set; }
            public class DescribeProjectResponseBodyDataCommonTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ActiveActive")]
                [Validation(Required=false)]
                public bool? ActiveActive { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("DataWorksBusinessName")]
                [Validation(Required=false)]
                public string DataWorksBusinessName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TUPLE</para>
                /// </summary>
                [NameInMap("DatahubTopicType")]
                [Validation(Required=false)]
                public string DatahubTopicType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MqPartition")]
                [Validation(Required=false)]
                public int? MqPartition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONE</para>
                /// </summary>
                [NameInMap("MqPartitionMode")]
                [Validation(Required=false)]
                public string MqPartitionMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("MqSerializerType")]
                [Validation(Required=false)]
                public string MqSerializerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RocketMqEnableMsgTrace")]
                [Validation(Required=false)]
                public bool? RocketMqEnableMsgTrace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default_tag</para>
                /// </summary>
                [NameInMap("RocketMqMsgTags")]
                [Validation(Required=false)]
                public string RocketMqMsgTags { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OMS</para>
                /// </summary>
                [NameInMap("RocketMqProducerGroup")]
                [Validation(Required=false)]
                public string RocketMqProducerGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RocketMqSendMsgTimeout")]
                [Validation(Required=false)]
                public long? RocketMqSendMsgTimeout { get; set; }

                [NameInMap("SinkStoreFormat")]
                [Validation(Required=false)]
                public string SinkStoreFormat { get; set; }

                [NameInMap("SourceStoreFormat")]
                [Validation(Required=false)]
                public string SourceStoreFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("TableCategory")]
                [Validation(Required=false)]
                public string TableCategory { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c_deg***</para>
            /// </summary>
            [NameInMap("DestConnId")]
            [Validation(Required=false)]
            public string DestConnId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableFullTransfer")]
            [Validation(Required=false)]
            public bool? EnableFullTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableFullVerify")]
            [Validation(Required=false)]
            public bool? EnableFullVerify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIncrTransfer")]
            [Validation(Required=false)]
            public bool? EnableIncrTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIncrVerify")]
            [Validation(Required=false)]
            public bool? EnableIncrVerify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableReverseIncrTransfer")]
            [Validation(Required=false)]
            public bool? EnableReverseIncrTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStructTransfer")]
            [Validation(Required=false)]
            public bool? EnableStructTransfer { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeProjectResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AccessObSource")]
                [Validation(Required=false)]
                public bool? AccessObSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IgnoreUnsupportDdl")]
                [Validation(Required=false)]
                public bool? IgnoreUnsupportDdl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689244596</para>
                /// </summary>
                [NameInMap("IncrSyncTimestamp")]
                [Validation(Required=false)]
                public long? IncrSyncTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689214358</para>
                /// </summary>
                [NameInMap("LogServiceStartCheckpoint")]
                [Validation(Required=false)]
                public long? LogServiceStartCheckpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("MaxConnectorCount")]
                [Validation(Required=false)]
                public int? MaxConnectorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MonitoringIncr")]
                [Validation(Required=false)]
                public bool? MonitoringIncr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OverwriteConfig")]
                [Validation(Required=false)]
                public bool? OverwriteConfig { get; set; }

                [NameInMap("ReverseSubtopics")]
                [Validation(Required=false)]
                public List<string> ReverseSubtopics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("RunningProgress")]
                [Validation(Required=false)]
                public int? RunningProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PRE-CHECK</para>
                /// </summary>
                [NameInMap("RunningStep")]
                [Validation(Required=false)]
                public string RunningStep { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("SourceStoreKeptHour")]
                [Validation(Required=false)]
                public int? SourceStoreKeptHour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SyncDelay")]
                [Validation(Required=false)]
                public long? SyncDelay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689214358</para>
                /// </summary>
                [NameInMap("SyncDelaySampleTimestamp")]
                [Validation(Required=false)]
                public long? SyncDelaySampleTimestamp { get; set; }

            }

            [NameInMap("FullTransferConfig")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataFullTransferConfig FullTransferConfig { get; set; }
            public class DescribeProjectResponseBodyDataFullTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowDestTableNotEmpty")]
                [Validation(Required=false)]
                public bool? AllowDestTableNotEmpty { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FAST</para>
                /// </summary>
                [NameInMap("FullTransferSpeedMode")]
                [Validation(Required=false)]
                public string FullTransferSpeedMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FAST</para>
                /// </summary>
                [NameInMap("FullVerifySpeedMode")]
                [Validation(Required=false)]
                public string FullVerifySpeedMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NonePkUkTruncateDstTable")]
                [Validation(Required=false)]
                public bool? NonePkUkTruncateDstTable { get; set; }

                [NameInMap("ReadWorkerNum")]
                [Validation(Required=false)]
                public int? ReadWorkerNum { get; set; }

                [NameInMap("ThrottleIOPS")]
                [Validation(Required=false)]
                public int? ThrottleIOPS { get; set; }

                [NameInMap("ThrottleRps")]
                [Validation(Required=false)]
                public int? ThrottleRps { get; set; }

                [NameInMap("WriteWorkerNum")]
                [Validation(Required=false)]
                public int? WriteWorkerNum { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T06:26:15</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T07:02:27</para>
            /// </summary>
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T06:26:15</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T07:02:27</para>
            /// </summary>
            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>np_fe****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public string Importance { get; set; }

            [NameInMap("IncrTransferConfig")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataIncrTransferConfig IncrTransferConfig { get; set; }
            public class DescribeProjectResponseBodyDataIncrTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIncrSyncStatistics")]
                [Validation(Required=false)]
                public bool? EnableIncrSyncStatistics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSequencingWithinTxn")]
                [Validation(Required=false)]
                public bool? EnableSequencingWithinTxn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("IncrSyncConcurrency")]
                [Validation(Required=false)]
                public int? IncrSyncConcurrency { get; set; }

                [NameInMap("RecordTypeWhiteList")]
                [Validation(Required=false)]
                public List<string> RecordTypeWhiteList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1667286900</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("StoreLogKeptHour")]
                [Validation(Required=false)]
                public int? StoreLogKeptHour { get; set; }

                [NameInMap("SupportDDLTypes")]
                [Validation(Required=false)]
                public List<string> SupportDDLTypes { get; set; }

                [NameInMap("ThrottleIOPS")]
                [Validation(Required=false)]
                public int? ThrottleIOPS { get; set; }

                [NameInMap("ThrottleRps")]
                [Validation(Required=false)]
                public int? ThrottleRps { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsMerging")]
            [Validation(Required=false)]
            public bool? IsMerging { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsModifying")]
            [Validation(Required=false)]
            public bool? IsModifying { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsSubProject")]
            [Validation(Required=false)]
            public bool? IsSubProject { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeProjectResponseBodyDataLabels> Labels { get; set; }
            public class DescribeProjectResponseBodyDataLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>l_dr****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_tag</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>omsefry***</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ReverseIncrTransferConfig")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataReverseIncrTransferConfig ReverseIncrTransferConfig { get; set; }
            public class DescribeProjectResponseBodyDataReverseIncrTransferConfig : TeaModel {
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

                [NameInMap("SupportDDLTypes")]
                [Validation(Required=false)]
                public List<string> SupportDDLTypes { get; set; }

                [NameInMap("ThrottleIOPS")]
                [Validation(Required=false)]
                public int? ThrottleIOPS { get; set; }

                [NameInMap("ThrottleRps")]
                [Validation(Required=false)]
                public int? ThrottleRps { get; set; }

            }

            [NameInMap("SinkConnectInfo")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataSinkConnectInfo SinkConnectInfo { get; set; }
            public class DescribeProjectResponseBodyDataSinkConnectInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>utf8mb4</para>
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ConnExtraAttributes")]
                [Validation(Required=false)]
                public object ConnExtraAttributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ConnectionInfo")]
                [Validation(Required=false)]
                public string ConnectionInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MYSQL_PUBLIC</para>
                /// </summary>
                [NameInMap("DbEngine")]
                [Validation(Required=false)]
                public string DbEngine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e_4w1q****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RATION12948*****</para>
                /// </summary>
                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sink</para>
                /// </summary>
                [NameInMap("EndpointSide")]
                [Validation(Required=false)]
                public string EndpointSide { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e_4lgzuzi9znr4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("NlsLengthSemantics")]
                [Validation(Required=false)]
                public string NlsLengthSemantics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("OcpName")]
                [Validation(Required=false)]
                public string OcpName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                /// <summary>
                /// <para>Owner。</para>
                /// 
                /// <b>Example:</b>
                /// <para>oms_test</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2883</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1325847***</para>
                /// </summary>
                [NameInMap("ResourceOwner")]
                [Validation(Required=false)]
                public string ResourceOwner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>+08:00</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oms2027obmysql@oms_***</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.2.77</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("SinkEndpointType")]
            [Validation(Required=false)]
            public string SinkEndpointType { get; set; }

            [NameInMap("SourceConnectInfo")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataSourceConnectInfo SourceConnectInfo { get; set; }
            public class DescribeProjectResponseBodyDataSourceConnectInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>utf8mb4</para>
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ConnExtraAttributes")]
                [Validation(Required=false)]
                public object ConnExtraAttributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ConnectionInfo")]
                [Validation(Required=false)]
                public string ConnectionInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OB_MYSQL_PUBLIC</para>
                /// </summary>
                [NameInMap("DbEngine")]
                [Validation(Required=false)]
                public string DbEngine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e_3kx5i***1s</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>migon****</para>
                /// </summary>
                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>source</para>
                /// </summary>
                [NameInMap("EndpointSide")]
                [Validation(Required=false)]
                public string EndpointSide { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c_feg****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("NlsLengthSemantics")]
                [Validation(Required=false)]
                public string NlsLengthSemantics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("OcpName")]
                [Validation(Required=false)]
                public string OcpName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                /// <summary>
                /// <para>Owner。</para>
                /// 
                /// <b>Example:</b>
                /// <para>oms_test</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2883</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1325847***</para>
                /// </summary>
                [NameInMap("ResourceOwner")]
                [Validation(Required=false)]
                public string ResourceOwner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>+08:00</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oms2027obmysql@oms_***</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.2.77</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OB_MYSQL</para>
            /// </summary>
            [NameInMap("SourceEndpointType")]
            [Validation(Required=false)]
            public string SourceEndpointType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<DescribeProjectResponseBodyDataSteps> Steps { get; set; }
            public class DescribeProjectResponseBodyDataSteps : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeProjectResponseBodyDataStepsExtraInfo ExtraInfo { get; set; }
                public class DescribeProjectResponseBodyDataStepsExtraInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>INNER_ERROR</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorDetails")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataStepsExtraInfoErrorDetails> ErrorDetails { get; set; }
                    public class DescribeProjectResponseBodyDataStepsExtraInfoErrorDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CM-RESOAT1111</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("ExtraContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtraContext { get; set; }

                        /// <summary>
                        /// <para>FATAL, ERROR, WARNING, CRITICAL</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ERROR</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>A system error occurred.</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        [NameInMap("MessageMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> MessageMcmsContext { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("MessageMcmsKey")]
                        [Validation(Required=false)]
                        public string MessageMcmsKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Contact the administrator.</para>
                        /// </summary>
                        [NameInMap("Proposal")]
                        [Validation(Required=false)]
                        public string Proposal { get; set; }

                        [NameInMap("ProposalMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> ProposalMcmsContext { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ProposalMcmsKey")]
                        [Validation(Required=false)]
                        public string ProposalMcmsKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("ReasonMcmsContext")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> ReasonMcmsContext { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("ReasonMcmsKey")]
                        [Validation(Required=false)]
                        public string ReasonMcmsKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("UpstreamErrorDetail")]
                        [Validation(Required=false)]
                        public object UpstreamErrorDetail { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("ErrorParam")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ErrorParam { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("FailedTime")]
                    [Validation(Required=false)]
                    public string FailedTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-05-22T17:04:18</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PRE_CHECK</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-05-22T17:04:18</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StepInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> StepInfo { get; set; }

            }

            [NameInMap("StructTransferConfig")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataStructTransferConfig StructTransferConfig { get; set; }
            public class DescribeProjectResponseBodyDataStructTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DO_NOTHING_IF_BYTE_USED</para>
                /// </summary>
                [NameInMap("ByteCharConvertStrategy")]
                [Validation(Required=false)]
                public string ByteCharConvertStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeferIndexCreation")]
                [Validation(Required=false)]
                public bool? DeferIndexCreation { get; set; }

            }

            [NameInMap("TransferMapping")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataTransferMapping TransferMapping { get; set; }
            public class DescribeProjectResponseBodyDataTransferMapping : TeaModel {
                [NameInMap("Databases")]
                [Validation(Required=false)]
                public List<DescribeProjectResponseBodyDataTransferMappingDatabases> Databases { get; set; }
                public class DescribeProjectResponseBodyDataTransferMappingDatabases : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>db_id</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_db</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>db_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpecificTables")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificTables> SpecificTables { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificTables : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificTablesAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_table</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&gt;1</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    [NameInMap("SpecificViews")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificViews> SpecificViews { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificViews : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesSpecificViewsAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_name</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&lt;3</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesTables> Tables { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesTables : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesTablesAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesTablesAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_table</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id &gt; 1</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tenant_name</para>
                    /// </summary>
                    [NameInMap("TenantName")]
                    [Validation(Required=false)]
                    public string TenantName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MYSQL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Views")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesViews> Views { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesViews : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesViewsAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesViewsAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>fexdg***</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_view</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id &lt; 1</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                }

                [NameInMap("DatabasesBlack")]
                [Validation(Required=false)]
                public List<DescribeProjectResponseBodyDataTransferMappingDatabasesBlack> DatabasesBlack { get; set; }
                public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlack : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>db_id</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_db</para>
                    /// </summary>
                    [NameInMap("MappedName")]
                    [Validation(Required=false)]
                    public string MappedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>db_name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SpecificTables")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificTables> SpecificTables { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificTables : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificTablesAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificTablesAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_table</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&lt;3</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    [NameInMap("SpecificViews")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificViews> SpecificViews { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificViews : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificViewsAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackSpecificViewsAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_view</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&gt;2</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesBlackTables> Tables { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackTables : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesBlackTablesAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackTablesAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_table</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&gt;1</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mapped_tenant</para>
                    /// </summary>
                    [NameInMap("TenantName")]
                    [Validation(Required=false)]
                    public string TenantName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DATABASE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Views")]
                    [Validation(Required=false)]
                    public List<DescribeProjectResponseBodyDataTransferMappingDatabasesBlackViews> Views { get; set; }
                    public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackViews : TeaModel {
                        [NameInMap("AdbTableSchema")]
                        [Validation(Required=false)]
                        public DescribeProjectResponseBodyDataTransferMappingDatabasesBlackViewsAdbTableSchema AdbTableSchema { get; set; }
                        public class DescribeProjectResponseBodyDataTransferMappingDatabasesBlackViewsAdbTableSchema : TeaModel {
                            [NameInMap("DistributedKeys")]
                            [Validation(Required=false)]
                            public List<string> DistributedKeys { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30</para>
                            /// </summary>
                            [NameInMap("PartitionLifeCycle")]
                            [Validation(Required=false)]
                            public string PartitionLifeCycle { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PARTITION BY VALUE(\&quot;id\&quot;)</para>
                            /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_id</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapped_name</para>
                        /// </summary>
                        [NameInMap("MappedName")]
                        [Validation(Required=false)]
                        public string MappedName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>view_name</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ShardColumns")]
                        [Validation(Required=false)]
                        public List<string> ShardColumns { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>id&gt;2</para>
                        /// </summary>
                        [NameInMap("WhereClause")]
                        [Validation(Required=false)]
                        public string WhereClause { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SPECIFIC</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("TableAndViewBlackList")]
                [Validation(Required=false)]
                public List<string> TableAndViewBlackList { get; set; }

                [NameInMap("TableAndViewWhiteList")]
                [Validation(Required=false)]
                public List<string> TableAndViewWhiteList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYNC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g_i4wa7XXX</para>
            /// </summary>
            [NameInMap("WorkerGradeId")]
            [Validation(Required=false)]
            public string WorkerGradeId { get; set; }

            [NameInMap("WorkerGradeInfo")]
            [Validation(Required=false)]
            public DescribeProjectResponseBodyDataWorkerGradeInfo WorkerGradeInfo { get; set; }
            public class DescribeProjectResponseBodyDataWorkerGradeInfo : TeaModel {
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
        public DescribeProjectResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeProjectResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CM-RESOAT1111</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A system error occurred.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A system error occurred.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-XXXX-XXXX-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
