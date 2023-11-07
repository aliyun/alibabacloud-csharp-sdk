// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of data archiving tickets.
        /// </summary>
        [NameInMap("DataArchiveOrderDetail")]
        [Validation(Required=false)]
        public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail DataArchiveOrderDetail { get; set; }
        public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail : TeaModel {
            /// <summary>
            /// The description of the data archiving tickets.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The user who submitted the ticket.
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// The ID of the user who submitted the ticket. The ID is a user ID and not the ID of an Alibaba Cloud account.
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }

            /// <summary>
            /// The time when the ticket was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the ticket was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of data archiving tickets.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The additional information about the ticket.
            /// </summary>
            [NameInMap("PluginExtraData")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData PluginExtraData { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData : TeaModel {
                /// <summary>
                /// The information about the workflow.
                /// </summary>
                [NameInMap("DagInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo DagInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo : TeaModel {
                    /// <summary>
                    /// The ID of the user who created the task flow.
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// The start time for scheduling. The task flow is not scheduled before this point in time.
                    /// </summary>
                    [NameInMap("CronBeginDate")]
                    [Validation(Required=false)]
                    public string CronBeginDate { get; set; }

                    /// <summary>
                    /// The end time for scheduling. The task flow is not scheduled after this point in time.
                    /// </summary>
                    [NameInMap("CronEndDate")]
                    [Validation(Required=false)]
                    public string CronEndDate { get; set; }

                    /// <summary>
                    /// Indicates whether the archiving task is a scheduled task. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("CronTrigger")]
                    [Validation(Required=false)]
                    public bool? CronTrigger { get; set; }

                    /// <summary>
                    /// Indicates whether the task is used to develop warehouses.
                    /// 
                    /// >  This field is a retained field that is not in use.
                    /// </summary>
                    [NameInMap("DWDevelop")]
                    [Validation(Required=false)]
                    public bool? DWDevelop { get; set; }

                    /// <summary>
                    /// The name of the workflow.
                    /// </summary>
                    [NameInMap("DagName")]
                    [Validation(Required=false)]
                    public string DagName { get; set; }

                    /// <summary>
                    /// The ID of the owner of the workflow.
                    /// </summary>
                    [NameInMap("DagOwnerId")]
                    [Validation(Required=false)]
                    public string DagOwnerId { get; set; }

                    /// <summary>
                    /// The ID of the deployment record.
                    /// </summary>
                    [NameInMap("DeployId")]
                    [Validation(Required=false)]
                    public long? DeployId { get; set; }

                    /// <summary>
                    /// The description of the workflow.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The ID of the editable workflow version.
                    /// </summary>
                    [NameInMap("EditDagId")]
                    [Validation(Required=false)]
                    public long? EditDagId { get; set; }

                    /// <summary>
                    /// The time when the workflow was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The time when the workflow was last modified.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// The ID of the task flow.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// Indicates whether the workflow is public. Valid values:
                    /// 
                    /// *   **0**: not public.
                    /// *   **1**: public.
                    /// </summary>
                    [NameInMap("IsPublic")]
                    [Validation(Required=false)]
                    public long? IsPublic { get; set; }

                    /// <summary>
                    /// Indicates whether the task is a historical task. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Legacy")]
                    [Validation(Required=false)]
                    public bool? Legacy { get; set; }

                    /// <summary>
                    /// Indicates whether the task was created by the system. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                    /// <summary>
                    /// The tenant ID.
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// Indicates whether the workflow is triggered to run once. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("TriggerOnce")]
                    [Validation(Required=false)]
                    public bool? TriggerOnce { get; set; }

                }

                /// <summary>
                /// The database information related to data archiving tickets.
                /// </summary>
                [NameInMap("DbBaseInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo DbBaseInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo : TeaModel {
                    /// <summary>
                    /// The alias of the database instance.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The timeout period of queries on the database.
                    /// </summary>
                    [NameInMap("AlterTimeout")]
                    [Validation(Required=false)]
                    public long? AlterTimeout { get; set; }

                    /// <summary>
                    /// Indicates whether access control is enabled for data assets. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("AssetControl")]
                    [Validation(Required=false)]
                    public bool? AssetControl { get; set; }

                    /// <summary>
                    /// The name of the instance in the instance list.
                    /// </summary>
                    [NameInMap("CatalogName")]
                    [Validation(Required=false)]
                    public string CatalogName { get; set; }

                    /// <summary>
                    /// Indicates whether the instance is added to the DMS whitelist.
                    /// </summary>
                    [NameInMap("ClusterNode")]
                    [Validation(Required=false)]
                    public string ClusterNode { get; set; }

                    /// <summary>
                    /// The ID of the database. You can call the [SearchDatabase](~~141876~~) operation to query the ID of the database.
                    /// 
                    /// >  You can call the [ListDatabases](~~141873~~) operation to query the ID of a physical database or the [ListLogicDatabases](~~141874~~) operation to query the ID of a logical database.
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    /// <summary>
                    /// The type of the database. For information about the valid values of this parameter, see [DbType parameter](~~198106~~).
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The ID of the database administrator (DBA) of the instance.
                    /// </summary>
                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    /// <summary>
                    /// The nickname of the DBA of the instance.
                    /// </summary>
                    [NameInMap("DbaName")]
                    [Validation(Required=false)]
                    public string DbaName { get; set; }

                    /// <summary>
                    /// The complete endpoint of the database.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The encoding format of the database.
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// The type of the environment to which the database belongs. Valid values:
                    /// 
                    /// *   **product**: production environment
                    /// *   **dev**: development environment
                    /// *   **pre**: staging environment
                    /// *   **test**: test environment
                    /// *   **sit**: system integration testing (SIT) environment
                    /// *   **uat**: user acceptance testing (UAT) environment
                    /// *   **pet**: stress testing environment
                    /// *   **stag**: STAG environment
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// Indicates whether the instance needs special attention. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Follow")]
                    [Validation(Required=false)]
                    public bool? Follow { get; set; }

                    /// <summary>
                    /// The endpoint that is used to connect to the database.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The region in which the database instance resides.
                    /// </summary>
                    [NameInMap("Idc")]
                    [Validation(Required=false)]
                    public string Idc { get; set; }

                    /// <summary>
                    /// The name of the region in which the database instance resides.
                    /// </summary>
                    [NameInMap("IdcTitle")]
                    [Validation(Required=false)]
                    public string IdcTitle { get; set; }

                    /// <summary>
                    /// The ID of the instance to which the database belongs.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// The source of the database instance.Valid values:
                    /// 
                    /// *   **RDS**: an ApsaraDB RDS instance.
                    /// *   **ECS_OWN**: a self-managed database deployed on an Elastic Compute Service (ECS) instance.
                    /// *   **PUBLIC_OWN**: a self-managed database instance that is connected over the Internet.
                    /// *   **VPC_ID**: a self-managed database instance in a virtual private cloud (VPC) that is connected over Express Connect circuits.
                    /// *   **GATEWAY**: a database instance connected by using a database gateway.
                    /// </summary>
                    [NameInMap("InstanceSource")]
                    [Validation(Required=false)]
                    public string InstanceSource { get; set; }

                    /// <summary>
                    /// The time when the database information was last obtained.
                    /// </summary>
                    [NameInMap("LastSyncTime")]
                    [Validation(Required=false)]
                    public string LastSyncTime { get; set; }

                    /// <summary>
                    /// The instance level.
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// Indicates whether the database is logical. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// The IDs of the owners of the databases, which are stored as an array. You can call the [GetUser](~~147098~~) or [ListUsers](~~141938~~) operation to query the IDs of the owners.
                    /// 
                    /// >  The value of OwnerIds is the same as the value of UserId
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// The usernames of the database owners.
                    /// </summary>
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                    /// <summary>
                    /// The port that is used to connect to the database.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// The name that is used to search for the database.
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    /// <summary>
                    /// The details of the control mode of the instance.
                    /// </summary>
                    [NameInMap("StandardGroup")]
                    [Validation(Required=false)]
                    public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup StandardGroup { get; set; }
                    public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup : TeaModel {
                        /// <summary>
                        /// The type of the instance engine. For information about the valid values of this parameter, see [DbType parameter](~~198106~~).
                        /// </summary>
                        [NameInMap("DbType")]
                        [Validation(Required=false)]
                        public string DbType { get; set; }

                        /// <summary>
                        /// The description of the security rule set.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// Indicates whether the instance is managed in Flexible Management or Stable Change mode. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// </summary>
                        [NameInMap("FreeOrStable")]
                        [Validation(Required=false)]
                        public bool? FreeOrStable { get; set; }

                        /// <summary>
                        /// The time when the security rule was created.
                        /// </summary>
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        /// <summary>
                        /// The time when the security rule was last modified.
                        /// </summary>
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        /// <summary>
                        /// The type of the control mode of the instance. Valid values:
                        /// 
                        /// *   **COMMON**: The instance is managed in Security Collaboration mode.
                        /// *   **NONE_CONTROL**: The instance is managed in Flexible Management mode.
                        /// *   **STABLE**: The instance is managed in Stable Change mode.
                        /// </summary>
                        [NameInMap("GroupMode")]
                        [Validation(Required=false)]
                        public string GroupMode { get; set; }

                        /// <summary>
                        /// The name of the security rule that corresponds to the control mode.
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// The ID of the security rule.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// The user ID of the last modified security rule.
                        /// </summary>
                        [NameInMap("LastMenderId")]
                        [Validation(Required=false)]
                        public long? LastMenderId { get; set; }

                    }

                    /// <summary>
                    /// The status of the database. Valid values:
                    /// 
                    /// *   **NORMAL**: The database is running as expected.
                    /// *   **DISABLE**: The database is disabled.
                    /// *   **OFFLINE**: The database is unpublished.
                    /// *   **NOT_EXIST**: The database does not exist.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// The number of tables.
                    /// </summary>
                    [NameInMap("TableCount")]
                    [Validation(Required=false)]
                    public long? TableCount { get; set; }

                    /// <summary>
                    /// The name of TNS.
                    /// </summary>
                    [NameInMap("TnsName")]
                    [Validation(Required=false)]
                    public string TnsName { get; set; }

                    /// <summary>
                    /// The unit type.
                    /// </summary>
                    [NameInMap("UnitType")]
                    [Validation(Required=false)]
                    public string UnitType { get; set; }

                }

                /// <summary>
                /// The total number of archiving tasks.
                /// </summary>
                [NameInMap("InstanceTotal")]
                [Validation(Required=false)]
                public long? InstanceTotal { get; set; }

                /// <summary>
                /// The list of archiving tasks.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances> Instances { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances : TeaModel {
                    /// <summary>
                    /// The business time of the task flow. The time is in the yyyy-MM-DD HH:mm:ss format.
                    /// </summary>
                    [NameInMap("BusinessTime")]
                    [Validation(Required=false)]
                    public string BusinessTime { get; set; }

                    /// <summary>
                    /// The ID of the task. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    /// <summary>
                    /// The end time of the task flow. The time is in the yyyy-MM-DD HH:mm:ss format.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// The time when the task flow was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The time when the task flow was last modified.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// The ID of the historical task flow.
                    /// </summary>
                    [NameInMap("HistoryDagId")]
                    [Validation(Required=false)]
                    public long? HistoryDagId { get; set; }

                    /// <summary>
                    /// The instance ID of the running task flow.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The running scenario of the last task flow.
                    /// </summary>
                    [NameInMap("LastRunningContext")]
                    [Validation(Required=false)]
                    public string LastRunningContext { get; set; }

                    /// <summary>
                    /// The running details of the task.
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// The status of the task. Valid values:
                    /// 
                    /// *   **0**: waiting for execution.
                    /// *   **1**: running.
                    /// *   **2**: suspended.
                    /// *   **3**: failed.
                    /// *   **4**: successful.
                    /// *   **5**: complete.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// The tenant ID.
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// The mode in which the task flow was triggered. Valid values:
                    /// 
                    /// *   **0**: The task flow was triggered based on a schedule.
                    /// *   **1**: The task flow was manually triggered.
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public long? TriggerType { get; set; }

                    /// <summary>
                    /// The version number.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The time when the next task is triggered.
                /// </summary>
                [NameInMap("NextFireTimeResult")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult NextFireTimeResult { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult : TeaModel {
                    /// <summary>
                    /// The type of scheduled triggering.
                    /// </summary>
                    [NameInMap("CronFireType")]
                    [Validation(Required=false)]
                    public string CronFireType { get; set; }

                }

                /// <summary>
                /// The page number.
                /// </summary>
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// The name of the temporary table that is generated by the archiving task (indicated by the archiving task ID).
                /// </summary>
                [NameInMap("TempTableNameMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> TempTableNameMap { get; set; }

            }

            /// <summary>
            /// The ticket creation parameter. The value is a JSON string. For more information, see [PluginType parameter](~~429109~~).
            /// </summary>
            [NameInMap("PluginParam")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam PluginParam { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam : TeaModel {
                /// <summary>
                /// The type of the archiving destination.
                /// </summary>
                [NameInMap("ArchiveMethod")]
                [Validation(Required=false)]
                public string ArchiveMethod { get; set; }

                /// <summary>
                /// The schema of the database and table to be archived.
                /// </summary>
                [NameInMap("DbSchema")]
                [Validation(Required=false)]
                public string DbSchema { get; set; }

                /// <summary>
                /// Indicates whether the database is logical.
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The post behavior of archiving.
                /// </summary>
                [NameInMap("OrderAfter")]
                [Validation(Required=false)]
                public List<string> OrderAfter { get; set; }

                /// <summary>
                /// The running method, which indicates whether to run the task immediately or at a specific point in time.
                /// </summary>
                [NameInMap("RunMethod")]
                [Validation(Required=false)]
                public string RunMethod { get; set; }

                /// <summary>
                /// The ID of the source database.
                /// </summary>
                [NameInMap("SourceDatabaseId")]
                [Validation(Required=false)]
                public long? SourceDatabaseId { get; set; }

                /// <summary>
                /// The list of the archived tables and the filter conditions.
                /// </summary>
                [NameInMap("TableIncludes")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes> TableIncludes { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes : TeaModel {
                    /// <summary>
                    /// The name of the table.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// The filter conditions.
                    /// </summary>
                    [NameInMap("TableWhere")]
                    [Validation(Required=false)]
                    public string TableWhere { get; set; }

                }

                /// <summary>
                /// The mapping of schemas.
                /// </summary>
                [NameInMap("TableMapping")]
                [Validation(Required=false)]
                public List<string> TableMapping { get; set; }

                /// <summary>
                /// The ID of the destination instance.
                /// </summary>
                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                /// <summary>
                /// The time variable defined for scheduled archiving.
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<string> Variables { get; set; }

            }

            /// <summary>
            /// The plug-in type that corresponds to the type of the ticket. The plug-in type for data archiving is DATA_ARCHIVE. For more information, see [PluginType parameter](~~429109~~).
            /// </summary>
            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }

            /// <summary>
            /// The user IDs related to the ticket.
            /// </summary>
            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public List<long?> RelatedUserList { get; set; }

            /// <summary>
            /// The nicknames of the users that are related to the ticket.
            /// </summary>
            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public List<string> RelatedUserNickList { get; set; }

            /// <summary>
            /// The status code of the ticket. Valid values:
            /// 
            /// *   **new**: newly created.
            /// *   **toaudit**: being reviewed.
            /// *   **Approved**: approved.
            /// *   **reject**: rejected.
            /// *   **processing**: being executed.
            /// *   **Success**: successful.
            /// *   **closed**: disabled.
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// The status description of the ticket.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The ID of the approval process. You can call the [GetOrderBaseInfo](~~144642~~) operation to obtain the ID of the approval process.
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            /// <summary>
            /// The description of the approval process.
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message that is returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request, which is used to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Tracks service requests.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
