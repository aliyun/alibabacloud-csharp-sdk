// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataArchiveOrderRequest : TeaModel {
        /// <summary>
        /// <para>The description of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The parameters for archiving data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataArchiveOrderRequestParam Param { get; set; }
        public class CreateDataArchiveOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The archiving destination to which you want to archive data. Valid values:</para>
            /// <remarks>
            /// <para> If you set ArchiveMethod to a value other than inner_oss, you must register the corresponding destination database with Data Management (DMS) before you create the data archiving ticket. After the database is registered with DMS, the database is displayed in the Instances Connected section of the DMS console.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><b>inner_oss</b>: dedicated storage, which is a built-in Object Storage Service (OSS) bucket.</description></item>
            /// <item><description><b>oss_userself</b>: OSS bucket of the user.</description></item>
            /// <item><description><b>mysql</b>: ApsaraDB RDS for MySQL instance.</description></item>
            /// <item><description><b>polardb</b>: PolarDB for MySQL cluster.</description></item>
            /// <item><description><b>adb_mysql</b>: AnalyticDB for MySQL V3.0 cluster.</description></item>
            /// <item><description><b>lindorm</b>: Lindorm instance.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("ArchiveMethod")]
            [Validation(Required=false)]
            public string ArchiveMethod { get; set; }

            /// <summary>
            /// <para>A crontab expression that specifies the scheduling cycle of the data archiving task. For more information, see the <a href="https://help.aliyun.com/document_detail/206581.html">Crontab expressions</a> section of the &quot;Create shadow tables for synchronization&quot; topic. You must specify this parameter if you set RunMethod to schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 05 11 * * ?</para>
            /// </summary>
            [NameInMap("CronStr")]
            [Validation(Required=false)]
            public string CronStr { get; set; }

            /// <summary>
            /// <para>The database ID. If the database is a self-managed database or a third-party cloud database, you can call the <a href="https://help.aliyun.com/document_detail/465856.html">GetDatabase</a> operation to query the database ID. If the database is an Alibaba Cloud database, ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1***</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>Specifies whether the database is a logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The post behaviors.</para>
            /// </summary>
            [NameInMap("OrderAfter")]
            [Validation(Required=false)]
            public List<string> OrderAfter { get; set; }

            /// <summary>
            /// <para>The method that is used to run the data archiving task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>schedule</b>: The data archiving task is periodically scheduled.</description></item>
            /// <item><description><b>now</b>: The data archiving task is immediately run.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>now</para>
            /// </summary>
            [NameInMap("RunMethod")]
            [Validation(Required=false)]
            public string RunMethod { get; set; }

            /// <summary>
            /// <para>The catalog of the source database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>def</b>: Set this parameter to def if the source database is of the two-layer logical schema, such as a MySQL database, a PolarDB for MySQL cluster, or an AnalyticDB for MySQL instance.</description></item>
            /// <item><description><b>Empty string</b>: Set this parameter to an empty string if the source database is a Lindorm or ApsaraDB for MongoDB instance.</description></item>
            /// <item><description><b>Catalog name</b>: Set this parameter to the catalog name of the source database if the source database is of the three-layer logical schema, such as a PostgreSQL database.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("SourceCatalogName")]
            [Validation(Required=false)]
            public string SourceCatalogName { get; set; }

            /// <summary>
            /// <para>The name of the source instance. If the database instance is a self-managed database or a third-party cloud database, you can call the <a href="https://help.aliyun.com/document_detail/465826.html">GetInstance</a> operation to query the instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1*******</para>
            /// </summary>
            [NameInMap("SourceInstanceName")]
            [Validation(Required=false)]
            public string SourceInstanceName { get; set; }

            /// <summary>
            /// <para>The schema name of the source database. The schema name of the source database is the same as that of the destination database. If the source database is a MySQL database, this parameter specifies the name of the source database. If the source database is a PostgreSQL database, this parameter specifies the schema name of the source database.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>schema_test</para>
            /// </summary>
            [NameInMap("SourceSchemaName")]
            [Validation(Required=false)]
            public string SourceSchemaName { get; set; }

            /// <summary>
            /// <para>The collection of tables to be archived.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<CreateDataArchiveOrderRequestParamTableIncludes> TableIncludes { get; set; }
            public class CreateDataArchiveOrderRequestParamTableIncludes : TeaModel {
                /// <summary>
                /// <para>The table name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The filter condition that is specified by the WHERE clause of the archiving configuration. If a time variable is used in the filter condition, the filter condition is specified in the following format: field name &lt;=\&quot;${variable name}\&quot;. The variable name in the filter condition must be the same as the time variable name that is specified in the Variables parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gmt_modified&lt;\&quot;${time}\&quot;</para>
                /// </summary>
                [NameInMap("TableWhere")]
                [Validation(Required=false)]
                public string TableWhere { get; set; }

            }

            /// <summary>
            /// <para>The table names mapped to the destination database. This parameter is not required and the default value is used.</para>
            /// </summary>
            [NameInMap("TableMapping")]
            [Validation(Required=false)]
            public List<string> TableMapping { get; set; }

            /// <summary>
            /// <para>The host of the destination instance. If the destination instance can be accessed over an internal network or the Internet, preferentially set the value to the internal endpoint of the destination instance.</para>
            /// <list type="bullet">
            /// <item><description>If data is archived in an OSS bucket, set the value to the name of the bucket.</description></item>
            /// <item><description>If data is archived in dedicated storage space, set the value to inner_oss.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-bp1*********.ads.aliyuncs.com</para>
            /// </summary>
            [NameInMap("TargetInstanceHost")]
            [Validation(Required=false)]
            public string TargetInstanceHost { get; set; }

            /// <summary>
            /// <para>The configuration of archiving variables. You can use a time variable as a filter condition for archiving data. Each variable has two attributes: name and pattern.</para>
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
        /// <para>The ID of the parent ticket. A parent ticket is generated only when a child ticket is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The type of the plug-in. Default value: DATA_ARCHIVE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_ARCHIVE</para>
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// <para>The list of the related users.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
