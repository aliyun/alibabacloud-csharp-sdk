// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveOrderDetailResponseBody : TeaModel {
        [NameInMap("DataArchiveOrderDetail")]
        [Validation(Required=false)]
        public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail DataArchiveOrderDetail { get; set; }
        public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("PluginExtraData")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData PluginExtraData { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData : TeaModel {
                [NameInMap("DagInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo DagInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo : TeaModel {
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("CronBeginDate")]
                    [Validation(Required=false)]
                    public string CronBeginDate { get; set; }

                    [NameInMap("CronEndDate")]
                    [Validation(Required=false)]
                    public string CronEndDate { get; set; }

                    [NameInMap("CronTrigger")]
                    [Validation(Required=false)]
                    public bool? CronTrigger { get; set; }

                    [NameInMap("DWDevelop")]
                    [Validation(Required=false)]
                    public bool? DWDevelop { get; set; }

                    [NameInMap("DagName")]
                    [Validation(Required=false)]
                    public string DagName { get; set; }

                    [NameInMap("DagOwnerId")]
                    [Validation(Required=false)]
                    public string DagOwnerId { get; set; }

                    [NameInMap("DeployId")]
                    [Validation(Required=false)]
                    public long? DeployId { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EditDagId")]
                    [Validation(Required=false)]
                    public long? EditDagId { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("IsPublic")]
                    [Validation(Required=false)]
                    public long? IsPublic { get; set; }

                    [NameInMap("Legacy")]
                    [Validation(Required=false)]
                    public bool? Legacy { get; set; }

                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("TriggerOnce")]
                    [Validation(Required=false)]
                    public bool? TriggerOnce { get; set; }

                }

                [NameInMap("DbBaseInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo DbBaseInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("AlterTimeout")]
                    [Validation(Required=false)]
                    public long? AlterTimeout { get; set; }

                    [NameInMap("AssetControl")]
                    [Validation(Required=false)]
                    public bool? AssetControl { get; set; }

                    [NameInMap("CatalogName")]
                    [Validation(Required=false)]
                    public string CatalogName { get; set; }

                    [NameInMap("ClusterNode")]
                    [Validation(Required=false)]
                    public string ClusterNode { get; set; }

                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    [NameInMap("DbaName")]
                    [Validation(Required=false)]
                    public string DbaName { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("Follow")]
                    [Validation(Required=false)]
                    public bool? Follow { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Idc")]
                    [Validation(Required=false)]
                    public string Idc { get; set; }

                    [NameInMap("IdcTitle")]
                    [Validation(Required=false)]
                    public string IdcTitle { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    [NameInMap("InstanceSource")]
                    [Validation(Required=false)]
                    public string InstanceSource { get; set; }

                    [NameInMap("LastSyncTime")]
                    [Validation(Required=false)]
                    public string LastSyncTime { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    [NameInMap("StandardGroup")]
                    [Validation(Required=false)]
                    public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup StandardGroup { get; set; }
                    public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup : TeaModel {
                        [NameInMap("DbType")]
                        [Validation(Required=false)]
                        public string DbType { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("FreeOrStable")]
                        [Validation(Required=false)]
                        public bool? FreeOrStable { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("GroupMode")]
                        [Validation(Required=false)]
                        public string GroupMode { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("LastMenderId")]
                        [Validation(Required=false)]
                        public long? LastMenderId { get; set; }

                    }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("TableCount")]
                    [Validation(Required=false)]
                    public long? TableCount { get; set; }

                    [NameInMap("TnsName")]
                    [Validation(Required=false)]
                    public string TnsName { get; set; }

                    [NameInMap("UnitType")]
                    [Validation(Required=false)]
                    public string UnitType { get; set; }

                }

                [NameInMap("InstanceTotal")]
                [Validation(Required=false)]
                public long? InstanceTotal { get; set; }

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances> Instances { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances : TeaModel {
                    [NameInMap("BusinessTime")]
                    [Validation(Required=false)]
                    public string BusinessTime { get; set; }

                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("HistoryDagId")]
                    [Validation(Required=false)]
                    public long? HistoryDagId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("LastRunningContext")]
                    [Validation(Required=false)]
                    public string LastRunningContext { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public long? TriggerType { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("NextFireTimeResult")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult NextFireTimeResult { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult : TeaModel {
                    [NameInMap("CronFireType")]
                    [Validation(Required=false)]
                    public string CronFireType { get; set; }

                }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

            }

            [NameInMap("PluginParam")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam PluginParam { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam : TeaModel {
                [NameInMap("ArchiveMethod")]
                [Validation(Required=false)]
                public string ArchiveMethod { get; set; }

                [NameInMap("DbSchema")]
                [Validation(Required=false)]
                public string DbSchema { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OrderAfter")]
                [Validation(Required=false)]
                public List<string> OrderAfter { get; set; }

                [NameInMap("RunMethod")]
                [Validation(Required=false)]
                public string RunMethod { get; set; }

                [NameInMap("SourceDatabaseId")]
                [Validation(Required=false)]
                public long? SourceDatabaseId { get; set; }

                [NameInMap("TableIncludes")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes> TableIncludes { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes : TeaModel {
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    [NameInMap("TableWhere")]
                    [Validation(Required=false)]
                    public string TableWhere { get; set; }

                }

                [NameInMap("TableMapping")]
                [Validation(Required=false)]
                public List<string> TableMapping { get; set; }

                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<string> Variables { get; set; }

            }

            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }

            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public List<long?> RelatedUserList { get; set; }

            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public List<string> RelatedUserNickList { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
