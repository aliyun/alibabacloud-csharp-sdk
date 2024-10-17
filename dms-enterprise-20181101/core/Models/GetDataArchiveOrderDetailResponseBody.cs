// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of data archiving tickets.</para>
        /// </summary>
        [NameInMap("DataArchiveOrderDetail")]
        [Validation(Required=false)]
        public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail DataArchiveOrderDetail { get; set; }
        public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetail : TeaModel {
            /// <summary>
            /// <para>The description of the data archiving tickets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Archiving of test results</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The user who submitted the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dmstest</para>
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the ticket. The ID is a user ID and not the ID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26***</para>
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public long? CommitterId { get; set; }

            /// <summary>
            /// <para>The time when the ticket was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-15 16:00:48</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the ticket was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-23 16:00:48</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of data archiving tickets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>868****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The additional information about the ticket.</para>
            /// </summary>
            [NameInMap("PluginExtraData")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData PluginExtraData { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraData : TeaModel {
                /// <summary>
                /// <para>The information about the workflow.</para>
                /// </summary>
                [NameInMap("DagInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo DagInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDagInfo : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user who created the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>59****</para>
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The start time for scheduling. The task flow is not scheduled before this point in time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1970-01-01</para>
                    /// </summary>
                    [NameInMap("CronBeginDate")]
                    [Validation(Required=false)]
                    public string CronBeginDate { get; set; }

                    /// <summary>
                    /// <para>The end time for scheduling. The task flow is not scheduled after this point in time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9999-01-01</para>
                    /// </summary>
                    [NameInMap("CronEndDate")]
                    [Validation(Required=false)]
                    public string CronEndDate { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the archiving task is a scheduled task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CronTrigger")]
                    [Validation(Required=false)]
                    public bool? CronTrigger { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the task is used to develop warehouses.</para>
                    /// <remarks>
                    /// <para> This field is a retained field that is not in use.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DWDevelop")]
                    [Validation(Required=false)]
                    public bool? DWDevelop { get; set; }

                    /// <summary>
                    /// <para>The name of the workflow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data-archive-9099197</para>
                    /// </summary>
                    [NameInMap("DagName")]
                    [Validation(Required=false)]
                    public string DagName { get; set; }

                    /// <summary>
                    /// <para>The ID of the owner of the workflow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13****</para>
                    /// </summary>
                    [NameInMap("DagOwnerId")]
                    [Validation(Required=false)]
                    public string DagOwnerId { get; set; }

                    /// <summary>
                    /// <para>The ID of the deployment record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>93***</para>
                    /// </summary>
                    [NameInMap("DeployId")]
                    [Validation(Required=false)]
                    public long? DeployId { get; set; }

                    /// <summary>
                    /// <para>The description of the workflow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>order id:9099197</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the editable workflow version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24***</para>
                    /// </summary>
                    [NameInMap("EditDagId")]
                    [Validation(Required=false)]
                    public long? EditDagId { get; set; }

                    /// <summary>
                    /// <para>The time when the workflow was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-15 16:00:48</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The time when the workflow was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-06-15 16:00:48</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The ID of the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the workflow is public. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: not public.</description></item>
                    /// <item><description><b>1</b>: public.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IsPublic")]
                    [Validation(Required=false)]
                    public long? IsPublic { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the task is a historical task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Legacy")]
                    [Validation(Required=false)]
                    public bool? Legacy { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the task was created by the system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                    /// <summary>
                    /// <para>The tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5***</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the workflow is triggered to run once. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("TriggerOnce")]
                    [Validation(Required=false)]
                    public bool? TriggerOnce { get; set; }

                }

                /// <summary>
                /// <para>The database information related to data archiving tickets.</para>
                /// </summary>
                [NameInMap("DbBaseInfo")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo DbBaseInfo { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfo : TeaModel {
                    /// <summary>
                    /// <para>The alias of the database instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tf-testAccDMSEnterpriseLogicDatabase853****</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The timeout period of queries on the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("AlterTimeout")]
                    [Validation(Required=false)]
                    public long? AlterTimeout { get; set; }

                    /// <summary>
                    /// <para>Indicates whether access control is enabled for data assets. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AssetControl")]
                    [Validation(Required=false)]
                    public bool? AssetControl { get; set; }

                    /// <summary>
                    /// <para>The name of the instance in the instance list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("CatalogName")]
                    [Validation(Required=false)]
                    public string CatalogName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance is added to the DMS whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>whitelist_done</para>
                    /// </summary>
                    [NameInMap("ClusterNode")]
                    [Validation(Required=false)]
                    public string ClusterNode { get; set; }

                    /// <summary>
                    /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to query the ID of the database.</para>
                    /// <remarks>
                    /// <para> You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> operation to query the ID of a physical database or the <a href="https://help.aliyun.com/document_detail/141874.html">ListLogicDatabases</a> operation to query the ID of a logical database.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>348****</para>
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    /// <summary>
                    /// <para>The type of the database. For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The ID of the database administrator (DBA) of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16****</para>
                    /// </summary>
                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    /// <summary>
                    /// <para>The nickname of the DBA of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DBA</para>
                    /// </summary>
                    [NameInMap("DbaName")]
                    [Validation(Required=false)]
                    public string DbaName { get; set; }

                    /// <summary>
                    /// <para>The complete endpoint of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test@rm-2ze756u8837****.mysql.rds.aliyuncs.com:3306 [test]</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The encoding format of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>utf8</para>
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the database belongs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>product</b>: production environment</description></item>
                    /// <item><description><b>dev</b>: development environment</description></item>
                    /// <item><description><b>pre</b>: staging environment</description></item>
                    /// <item><description><b>test</b>: test environment</description></item>
                    /// <item><description><b>sit</b>: system integration testing (SIT) environment</description></item>
                    /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
                    /// <item><description><b>pet</b>: stress testing environment</description></item>
                    /// <item><description><b>stag</b>: STAG environment</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>product</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance needs special attention. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Follow")]
                    [Validation(Required=false)]
                    public bool? Follow { get; set; }

                    /// <summary>
                    /// <para>The endpoint that is used to connect to the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-2ze756u8837****.mysql.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The region in which the database instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("Idc")]
                    [Validation(Required=false)]
                    public string Idc { get; set; }

                    /// <summary>
                    /// <para>The name of the region in which the database instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("IdcTitle")]
                    [Validation(Required=false)]
                    public string IdcTitle { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance to which the database belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>175****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public long? InstanceId { get; set; }

                    /// <summary>
                    /// <para>The source of the database instance.Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>RDS</b>: an ApsaraDB RDS instance.</description></item>
                    /// <item><description><b>ECS_OWN</b>: a self-managed database deployed on an Elastic Compute Service (ECS) instance.</description></item>
                    /// <item><description><b>PUBLIC_OWN</b>: a self-managed database instance that is connected over the Internet.</description></item>
                    /// <item><description><b>VPC_ID</b>: a self-managed database instance in a virtual private cloud (VPC) that is connected over Express Connect circuits.</description></item>
                    /// <item><description><b>GATEWAY</b>: a database instance connected by using a database gateway.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RDS</para>
                    /// </summary>
                    [NameInMap("InstanceSource")]
                    [Validation(Required=false)]
                    public string InstanceSource { get; set; }

                    /// <summary>
                    /// <para>The time when the database information was last obtained.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-14 18:34:45</para>
                    /// </summary>
                    [NameInMap("LastSyncTime")]
                    [Validation(Required=false)]
                    public string LastSyncTime { get; set; }

                    /// <summary>
                    /// <para>The instance level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>medium</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the database is logical. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// <para>The IDs of the owners of the databases, which are stored as an array. You can call the <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> or <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> operation to query the IDs of the owners.</para>
                    /// <remarks>
                    /// <para> The value of OwnerIds is the same as the value of UserId</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// <para>The usernames of the database owners.</para>
                    /// </summary>
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                    /// <summary>
                    /// <para>The port that is used to connect to the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }

                    /// <summary>
                    /// <para>The name that is used to search for the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test@rm-2ze756u8837****.mysql.rds.aliyuncs.com:3306 [test]</para>
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    /// <summary>
                    /// <para>The details of the control mode of the instance.</para>
                    /// </summary>
                    [NameInMap("StandardGroup")]
                    [Validation(Required=false)]
                    public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup StandardGroup { get; set; }
                    public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataDbBaseInfoStandardGroup : TeaModel {
                        /// <summary>
                        /// <para>The type of the instance engine. For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MySQL</para>
                        /// </summary>
                        [NameInMap("DbType")]
                        [Validation(Required=false)]
                        public string DbType { get; set; }

                        /// <summary>
                        /// <para>The description of the security rule set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>adb_mysql default</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the instance is managed in Flexible Management or Stable Change mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("FreeOrStable")]
                        [Validation(Required=false)]
                        public bool? FreeOrStable { get; set; }

                        /// <summary>
                        /// <para>The time when the security rule was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-05-24 14:12:32</para>
                        /// </summary>
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        /// <summary>
                        /// <para>The time when the security rule was last modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-05-25 14:12:32</para>
                        /// </summary>
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        /// <summary>
                        /// <para>The type of the control mode of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>COMMON</b>: The instance is managed in Security Collaboration mode.</description></item>
                        /// <item><description><b>NONE_CONTROL</b>: The instance is managed in Flexible Management mode.</description></item>
                        /// <item><description><b>STABLE</b>: The instance is managed in Stable Change mode.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>COMMON</para>
                        /// </summary>
                        [NameInMap("GroupMode")]
                        [Validation(Required=false)]
                        public string GroupMode { get; set; }

                        /// <summary>
                        /// <para>The name of the security rule that corresponds to the control mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>adb_mysql default</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The ID of the security rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>24***</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The user ID of the last modified security rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12****</para>
                        /// </summary>
                        [NameInMap("LastMenderId")]
                        [Validation(Required=false)]
                        public long? LastMenderId { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the database. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NORMAL</b>: The database is running as expected.</description></item>
                    /// <item><description><b>DISABLE</b>: The database is disabled.</description></item>
                    /// <item><description><b>OFFLINE</b>: The database is unpublished.</description></item>
                    /// <item><description><b>NOT_EXIST</b>: The database does not exist.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NORMAL</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// <para>The number of tables.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>201</para>
                    /// </summary>
                    [NameInMap("TableCount")]
                    [Validation(Required=false)]
                    public long? TableCount { get; set; }

                    /// <summary>
                    /// <para>The name of TNS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TNS_4010</para>
                    /// </summary>
                    [NameInMap("TnsName")]
                    [Validation(Required=false)]
                    public string TnsName { get; set; }

                    /// <summary>
                    /// <para>The unit type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-1</para>
                    /// </summary>
                    [NameInMap("UnitType")]
                    [Validation(Required=false)]
                    public string UnitType { get; set; }

                }

                /// <summary>
                /// <para>The total number of archiving tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InstanceTotal")]
                [Validation(Required=false)]
                public long? InstanceTotal { get; set; }

                /// <summary>
                /// <para>The list of archiving tasks.</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances> Instances { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataInstances : TeaModel {
                    /// <summary>
                    /// <para>The business time of the task flow. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-14 16:00:57</para>
                    /// </summary>
                    [NameInMap("BusinessTime")]
                    [Validation(Required=false)]
                    public string BusinessTime { get; set; }

                    /// <summary>
                    /// <para>The task flow ID. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to obtain the value of this parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37***</para>
                    /// </summary>
                    [NameInMap("DagId")]
                    [Validation(Required=false)]
                    public long? DagId { get; set; }

                    /// <summary>
                    /// <para>The time when the task flow ended. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-06-04 15:14:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the task flow was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-14 16:00:57</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The time when the task flow was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-14 16:00:57</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The ID of the historical task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32***</para>
                    /// </summary>
                    [NameInMap("HistoryDagId")]
                    [Validation(Required=false)]
                    public long? HistoryDagId { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance in the task flow that is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24***</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The context of the previous execution of the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;nodes&quot;: [
                    ///             48**
                    ///       ],
                    ///       &quot;edges&quot;: {}
                    /// }</para>
                    /// </summary>
                    [NameInMap("LastRunningContext")]
                    [Validation(Required=false)]
                    public string LastRunningContext { get; set; }

                    /// <summary>
                    /// <para>The context of the current execution of the task flow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-15 16:37:48[GMT+08:00] INFO - Resource Control is active!\n2023-05-15 16:37:48[GMT+08:00] INFO - Starting job j_4834 at Mon May 15 16:37:48 CST 2023</para>
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// <para>The status of the task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The task is waiting for execution.</description></item>
                    /// <item><description><b>1</b>: The task is in progress.</description></item>
                    /// <item><description><b>2</b>: The task is suspended.</description></item>
                    /// <item><description><b>3</b>: The task failed.</description></item>
                    /// <item><description><b>4</b>: The task is successful.</description></item>
                    /// <item><description><b>5</b>: The task is complete.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>The tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5***</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The mode in which the task flow was triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The task flow was triggered based on a schedule.</description></item>
                    /// <item><description><b>1</b>: The task flow was manually triggered.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public long? TriggerType { get; set; }

                    /// <summary>
                    /// <para>The version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The time when the next task is triggered.</para>
                /// </summary>
                [NameInMap("NextFireTimeResult")]
                [Validation(Required=false)]
                public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult NextFireTimeResult { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginExtraDataNextFireTimeResult : TeaModel {
                    /// <summary>
                    /// <para>The type of scheduled triggering.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NOT_SET</para>
                    /// </summary>
                    [NameInMap("CronFireType")]
                    [Validation(Required=false)]
                    public string CronFireType { get; set; }

                }

                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// <para>The name of the temporary table that is generated by the archiving task (indicated by the archiving task ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///       &quot;803***&quot;: [
                ///             &quot;tmp_dms_21321_20230704144336_temp_test_check&quot;
                ///       ]
                /// }</para>
                /// </summary>
                [NameInMap("TempTableNameMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> TempTableNameMap { get; set; }

            }

            /// <summary>
            /// <para>The ticket creation parameter. The value is a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/429109.html">PluginType parameter</a>.</para>
            /// </summary>
            [NameInMap("PluginParam")]
            [Validation(Required=false)]
            public GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam PluginParam { get; set; }
            public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParam : TeaModel {
                /// <summary>
                /// <para>The type of the archiving destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inner_oss</para>
                /// </summary>
                [NameInMap("ArchiveMethod")]
                [Validation(Required=false)]
                public string ArchiveMethod { get; set; }

                /// <summary>
                /// <para>The schema of the database and table to be archived.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbSchema")]
                [Validation(Required=false)]
                public string DbSchema { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is logical.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The post behavior of archiving.</para>
                /// </summary>
                [NameInMap("OrderAfter")]
                [Validation(Required=false)]
                public List<string> OrderAfter { get; set; }

                /// <summary>
                /// <para>The running method, which indicates whether to run the task immediately or at a specific point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>now</para>
                /// </summary>
                [NameInMap("RunMethod")]
                [Validation(Required=false)]
                public string RunMethod { get; set; }

                /// <summary>
                /// <para>The ID of the source database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12***</para>
                /// </summary>
                [NameInMap("SourceDatabaseId")]
                [Validation(Required=false)]
                public long? SourceDatabaseId { get; set; }

                /// <summary>
                /// <para>The list of the archived tables and the filter conditions.</para>
                /// </summary>
                [NameInMap("TableIncludes")]
                [Validation(Required=false)]
                public List<GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes> TableIncludes { get; set; }
                public class GetDataArchiveOrderDetailResponseBodyDataArchiveOrderDetailPluginParamTableIncludes : TeaModel {
                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tm_insured_cb</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The filter condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id&lt;1000 or gmt_create&lt;\&quot;2023-05-14 16:00:57\&quot;</para>
                    /// </summary>
                    [NameInMap("TableWhere")]
                    [Validation(Required=false)]
                    public string TableWhere { get; set; }

                }

                /// <summary>
                /// <para>The mapping of schemas.</para>
                /// </summary>
                [NameInMap("TableMapping")]
                [Validation(Required=false)]
                public List<string> TableMapping { get; set; }

                /// <summary>
                /// <para>The ID of the destination instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12***</para>
                /// </summary>
                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                /// <summary>
                /// <para>The time variable defined for scheduled archiving.</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<string> Variables { get; set; }

            }

            /// <summary>
            /// <para>The plug-in type that corresponds to the type of the ticket. The plug-in type for data archiving is DATA_ARCHIVE. For more information, see <a href="https://help.aliyun.com/document_detail/429109.html">PluginType parameter</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_ARCHIVE</para>
            /// </summary>
            [NameInMap("PluginType")]
            [Validation(Required=false)]
            public string PluginType { get; set; }

            /// <summary>
            /// <para>The user IDs related to the ticket.</para>
            /// </summary>
            [NameInMap("RelatedUserList")]
            [Validation(Required=false)]
            public List<long?> RelatedUserList { get; set; }

            /// <summary>
            /// <para>The nicknames of the users that are related to the ticket.</para>
            /// </summary>
            [NameInMap("RelatedUserNickList")]
            [Validation(Required=false)]
            public List<string> RelatedUserNickList { get; set; }

            /// <summary>
            /// <para>The status code of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>new</b>: newly created.</description></item>
            /// <item><description><b>toaudit</b>: being reviewed.</description></item>
            /// <item><description><b>Approved</b>: approved.</description></item>
            /// <item><description><b>reject</b>: rejected.</description></item>
            /// <item><description><b>processing</b>: being executed.</description></item>
            /// <item><description><b>Success</b>: successful.</description></item>
            /// <item><description><b>closed</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>processing</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The status description of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a ticket task is being executed.</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The ID of the approval process. You can call the <a href="https://help.aliyun.com/document_detail/144642.html">GetOrderBaseInfo</a> operation to obtain the ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29****</para>
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approved</para>
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User [19929582****] not exist</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4161CE36-28DF-5191-8A6F-A17076A0B124</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Tracks service requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06e1e316757357507896067d3780</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
