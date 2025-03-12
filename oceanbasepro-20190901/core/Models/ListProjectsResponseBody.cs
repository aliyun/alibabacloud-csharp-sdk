// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListProjectsResponseBody : TeaModel {
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
        public List<ListProjectsResponseBodyData> Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            [NameInMap("AlarmStats")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataAlarmStats AlarmStats { get; set; }
            public class ListProjectsResponseBodyDataAlarmStats : TeaModel {
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
            public ListProjectsResponseBodyDataCommonTransferConfig CommonTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataCommonTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>false</para>
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
            /// <para>null</para>
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
            public ListProjectsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class ListProjectsResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AccessObSource")]
                [Validation(Required=false)]
                public bool? AccessObSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>TRANSFER_PRECHECK</para>
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
            public ListProjectsResponseBodyDataFullTransferConfig FullTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataFullTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowDestTableNotEmpty")]
                [Validation(Required=false)]
                public bool? AllowDestTableNotEmpty { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("FullTransferSpeedMode")]
                [Validation(Required=false)]
                public string FullTransferSpeedMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
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
            /// <para>2023-07-13T08:01:27</para>
            /// </summary>
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-13T07:01:27</para>
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
            /// <para>np_4w****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MEDIUM</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public string Importance { get; set; }

            [NameInMap("IncrTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataIncrTransferConfig IncrTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataIncrTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIncrSyncStatistics")]
                [Validation(Required=false)]
                public bool? EnableIncrSyncStatistics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>1681004708</para>
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
            public List<ListProjectsResponseBodyDataLabels> Labels { get; set; }
            public class ListProjectsResponseBodyDataLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>l_dfe****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>label_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("SinkConnectInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataSinkConnectInfo SinkConnectInfo { get; set; }
            public class ListProjectsResponseBodyDataSinkConnectInfo : TeaModel {
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
                /// <para>e_4w3aic***</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ation129<em><b>9apimysql5616</b></em>*</para>
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
                /// <para>c_4w3akx***</para>
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
                /// <para>admin</para>
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
                /// <para>oms<b>obmys</b></para>
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
            [NameInMap("SinkEndpointType")]
            [Validation(Required=false)]
            public string SinkEndpointType { get; set; }

            [NameInMap("SourceConnectInfo")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataSourceConnectInfo SourceConnectInfo { get; set; }
            public class ListProjectsResponseBodyDataSourceConnectInfo : TeaModel {
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
                /// <para>e_4w3al***</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ration12*<em><b>0obmysql4116892</b></em></para>
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
                /// <para>c_4w3aq****</para>
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
                /// <para>admin</para>
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
                /// <para>UTC</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oms931mys**</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.7.27</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MYSQL</para>
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
            public List<ListProjectsResponseBodyDataSteps> Steps { get; set; }
            public class ListProjectsResponseBodyDataSteps : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataStepsExtraInfo ExtraInfo { get; set; }
                public class ListProjectsResponseBodyDataStepsExtraInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>INNER_ERROR</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorDetails")]
                    [Validation(Required=false)]
                    public List<ListProjectsResponseBodyDataStepsExtraInfoErrorDetails> ErrorDetails { get; set; }
                    public class ListProjectsResponseBodyDataStepsExtraInfoErrorDetails : TeaModel {
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
                /// <para>2020-05-22T17:05:18</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TRANSFER_PRECHECK</para>
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
                /// <para>100</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("StepInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> StepInfo { get; set; }

            }

            [NameInMap("StructTransferConfig")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataStructTransferConfig StructTransferConfig { get; set; }
            public class ListProjectsResponseBodyDataStructTransferConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DO_NOTHING_IF_BYTE_USED</para>
                /// </summary>
                [NameInMap("ByteCharConvertStrategy")]
                [Validation(Required=false)]
                public string ByteCharConvertStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeferIndexCreation")]
                [Validation(Required=false)]
                public bool? DeferIndexCreation { get; set; }

            }

            [NameInMap("TransferMapping")]
            [Validation(Required=false)]
            public ListProjectsResponseBodyDataTransferMapping TransferMapping { get; set; }
            public class ListProjectsResponseBodyDataTransferMapping : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SPECIFIC</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MIGRATION</para>
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
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
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
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
