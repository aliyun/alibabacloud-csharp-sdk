// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataArchiveOrderRequest : TeaModel {
        /// <summary>
        /// The description of the task.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters for archiving data.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataArchiveOrderRequestParam Param { get; set; }
        public class CreateDataArchiveOrderRequestParam : TeaModel {
            /// <summary>
            /// The database for archiving data. Valid values:
            /// 
            /// *   inner_oss: Built-in Object Storage Service (OSS) of Database Backup (DBS).
            /// *   oss_userself: OSS of user.
            /// *   mysql: ApsaraDB RDS for MySQL.
            /// *   polardb: PolarDB for MySQL.
            /// *   lindorm: Lindorm.
            /// </summary>
            [NameInMap("ArchiveMethod")]
            [Validation(Required=false)]
            public string ArchiveMethod { get; set; }

            /// <summary>
            /// 填写Crontab表达式，以便定期执行任务，更多信息，请参见[Crontab表达式](~~206581~~)。
            /// 当运行方式为周期归档时需要填写该参数。
            /// </summary>
            [NameInMap("CronStr")]
            [Validation(Required=false)]
            public string CronStr { get; set; }

            /// <summary>
            /// Specifies whether the database is a logical database.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The post behaviors.
            /// </summary>
            [NameInMap("OrderAfter")]
            [Validation(Required=false)]
            public List<string> OrderAfter { get; set; }

            /// <summary>
            /// The running mode. Only now is supported, which indicates that data archiving is immediately executed.
            /// </summary>
            [NameInMap("RunMethod")]
            [Validation(Required=false)]
            public string RunMethod { get; set; }

            /// <summary>
            /// 源库目录（catalog）。
            /// - **def**：对于两层逻辑结构的数据库，如MySQL，PolarDB MySQL，AnalyticDB MySQL，固定为def。
            /// - **空字符串**： 对于lindorm与MongoDB，填入空字符串。
            /// - **catalog名**：对于三层逻辑结构的数据库，如PostgreSQL，填入catalog名。
            /// </summary>
            [NameInMap("SourceCatalogName")]
            [Validation(Required=false)]
            public string SourceCatalogName { get; set; }

            /// <summary>
            /// 源实例名称。
            /// </summary>
            [NameInMap("SourceInstanceName")]
            [Validation(Required=false)]
            public string SourceInstanceName { get; set; }

            /// <summary>
            /// 源库Schema，源库与目标库同名。
            /// 如MySQL为库名，PostgreSQL为Schema名。
            /// </summary>
            [NameInMap("SourceSchemaName")]
            [Validation(Required=false)]
            public string SourceSchemaName { get; set; }

            /// <summary>
            /// The collection of tables to be archived.
            /// </summary>
            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<CreateDataArchiveOrderRequestParamTableIncludes> TableIncludes { get; set; }
            public class CreateDataArchiveOrderRequestParamTableIncludes : TeaModel {
                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The filter condition specified by the WHERE clause of the archiving configuration.
                /// </summary>
                [NameInMap("TableWhere")]
                [Validation(Required=false)]
                public string TableWhere { get; set; }

            }

            /// <summary>
            /// The table names mapped in the destination database.
            /// </summary>
            [NameInMap("TableMapping")]
            [Validation(Required=false)]
            public List<string> TableMapping { get; set; }

            /// <summary>
            /// 目标库Host，若目标实例同时开放了内网与公网，优先写入内网Host。
            /// 
            /// - 若归档目标为OSS，则为Bucket名。
            /// - 若归档目标为专属存储，则为inner_oss。
            /// </summary>
            [NameInMap("TargetInstanceHost")]
            [Validation(Required=false)]
            public string TargetInstanceHost { get; set; }

            /// <summary>
            /// The configuration of archiving variables.
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<CreateDataArchiveOrderRequestParamVariables> Variables { get; set; }
            public class CreateDataArchiveOrderRequestParamVariables : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

        }

        /// <summary>
        /// The ID of the parent ticket. A parent ticket is generated only when a sub ticket is created.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The plugin type. Default value: DATA_ARCHIVE.
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// The list of the related users.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        /// <summary>
        /// The tenant ID. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
