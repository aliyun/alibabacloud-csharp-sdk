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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters for archiving data.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataArchiveOrderRequestParam Param { get; set; }
        public class CreateDataArchiveOrderRequestParam : TeaModel {
            /// <summary>
            /// The archiving destination to which you want to archive data. Valid values:
            /// 
            /// >  If you set ArchiveMethod to a value other than inner_oss, you must register the corresponding destination database with Data Management (DMS) before you create the data archiving ticket. After the database is registered with DMS, the database is displayed in the Instances Connected section of the DMS console.
            /// 
            /// *   **inner_oss**: dedicated storage, which is a built-in Object Storage Service (OSS) bucket.
            /// *   **oss_userself**: OSS bucket of the user.
            /// *   **mysql**: ApsaraDB RDS for MySQL instance.
            /// *   **polardb**: PolarDB for MySQL cluster.
            /// *   **adb_mysql**: AnalyticDB for MySQL V3.0 cluster.
            /// *   **lindorm**: Lindorm instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ArchiveMethod")]
            [Validation(Required=false)]
            public string ArchiveMethod { get; set; }

            /// <summary>
            /// A crontab expression that specifies the scheduling cycle of the data archiving task. For more information, see the [Crontab expressions](https://help.aliyun.com/document_detail/206581.html) section of the "Create shadow tables for synchronization" topic. You must specify this parameter if you set RunMethod to schedule.
            /// </summary>
            [NameInMap("CronStr")]
            [Validation(Required=false)]
            public string CronStr { get; set; }

            /// <summary>
            /// The database ID. If the database is a self-managed database or a third-party cloud database, you can call the [GetDatabase](https://help.aliyun.com/document_detail/465856.html) operation to query the database ID. If the database is an Alibaba Cloud database, ignore this parameter.
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

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
            /// The method that is used to run the data archiving task. Valid values:
            /// 
            /// *   **schedule**: The data archiving task is periodically scheduled.
            /// *   **now**: The data archiving task is immediately run.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RunMethod")]
            [Validation(Required=false)]
            public string RunMethod { get; set; }

            /// <summary>
            /// The catalog of the source database. Valid values:
            /// 
            /// *   **def**: Set this parameter to def if the source database is of the two-layer logical schema, such as a MySQL database, a PolarDB for MySQL cluster, or an AnalyticDB for MySQL instance.
            /// *   **Empty string**: Set this parameter to an empty string if the source database is a Lindorm or ApsaraDB for MongoDB instance.
            /// *   **Catalog name**: Set this parameter to the catalog name of the source database if the source database is of the three-layer logical schema, such as a PostgreSQL database.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SourceCatalogName")]
            [Validation(Required=false)]
            public string SourceCatalogName { get; set; }

            /// <summary>
            /// The name of the source instance. If the database instance is a self-managed database or a third-party cloud database, you can call the [GetInstance](https://help.aliyun.com/document_detail/465826.html) operation to query the instance ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SourceInstanceName")]
            [Validation(Required=false)]
            public string SourceInstanceName { get; set; }

            /// <summary>
            /// The schema name of the source database. The schema name of the source database is the same as that of the destination database. If the source database is a MySQL database, this parameter specifies the name of the source database. If the source database is a PostgreSQL database, this parameter specifies the schema name of the source database.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SourceSchemaName")]
            [Validation(Required=false)]
            public string SourceSchemaName { get; set; }

            /// <summary>
            /// The collection of tables to be archived.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<CreateDataArchiveOrderRequestParamTableIncludes> TableIncludes { get; set; }
            public class CreateDataArchiveOrderRequestParamTableIncludes : TeaModel {
                /// <summary>
                /// The table name.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The filter condition that is specified by the WHERE clause of the archiving configuration. If a time variable is used in the filter condition, the filter condition is specified in the following format: field name <=\\"${variable name}\\". The variable name in the filter condition must be the same as the time variable name that is specified in the Variables parameter.
                /// </summary>
                [NameInMap("TableWhere")]
                [Validation(Required=false)]
                public string TableWhere { get; set; }

            }

            /// <summary>
            /// The table names mapped to the destination database. This parameter is not required and the default value is used.
            /// </summary>
            [NameInMap("TableMapping")]
            [Validation(Required=false)]
            public List<string> TableMapping { get; set; }

            /// <summary>
            /// The host of the destination instance. If the destination instance can be accessed over an internal network or the Internet, preferentially set the value to the internal endpoint of the destination instance.
            /// 
            /// *   If data is archived in an OSS bucket, set the value to the name of the bucket.
            /// *   If data is archived in dedicated storage space, set the value to inner_oss.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TargetInstanceHost")]
            [Validation(Required=false)]
            public string TargetInstanceHost { get; set; }

            /// <summary>
            /// The configuration of archiving variables. You can use a time variable as a filter condition for archiving data. Each variable has two attributes: name and pattern.
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
        /// The ID of the parent ticket. A parent ticket is generated only when a child ticket is created.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The type of the plug-in. Default value: DATA_ARCHIVE.
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
        /// The tenant ID. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
