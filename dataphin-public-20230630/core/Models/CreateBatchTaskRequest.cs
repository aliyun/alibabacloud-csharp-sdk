// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBatchTaskRequestCreateCommand CreateCommand { get; set; }
        public class CreateBatchTaskRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The ID of the offline code template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>st_123456</para>
            /// </summary>
            [NameInMap("CodeTemplateId")]
            [Validation(Required=false)]
            public string CodeTemplateId { get; set; }

            /// <summary>
            /// <para>The version of the offline code template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CodeTemplateVersion")]
            [Validation(Required=false)]
            public int? CodeTemplateVersion { get; set; }

            /// <summary>
            /// <para>The catalog for database SQL tasks. This parameter takes effect only for data source types that require a catalog, such as Presto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <para>The ID of the data source for database SQL tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The schema for database SQL tasks. This parameter takes effect only for data source types that require a schema, such as Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <para>The Python connection configuration.</para>
            /// </summary>
            [NameInMap("DatabricksPythonConnectInfo")]
            [Validation(Required=false)]
            public CreateBatchTaskRequestCreateCommandDatabricksPythonConnectInfo DatabricksPythonConnectInfo { get; set; }
            public class CreateBatchTaskRequestCreateCommandDatabricksPythonConnectInfo : TeaModel {
                /// <summary>
                /// <para>The HTTP path for the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/sql/1.0/warehouses/dev</para>
                /// </summary>
                [NameInMap("DevHttpPath")]
                [Validation(Required=false)]
                public string DevHttpPath { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Databricks Python connect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableDatabricksPythonConnect")]
                [Validation(Required=false)]
                public bool? EnableDatabricksPythonConnect { get; set; }

                /// <summary>
                /// <para>The HTTP path for the production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/sql/1.0/warehouses/prod</para>
                /// </summary>
                [NameInMap("ProdHttpPath")]
                [Validation(Required=false)]
                public string ProdHttpPath { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IDs of the development owners.</para>
            /// </summary>
            [NameInMap("DevelopOwnerIdList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerIdList { get; set; }

            /// <summary>
            /// <para>The directory in the menu tree to which the task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/b</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The task execution engine, such as Python tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PYTHON2_7</description></item>
            /// <item><description>PYTHON3_7</description></item>
            /// <item><description>PYTHON3_11</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The name of the offline task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test111</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the O&amp;M owners.</para>
            /// </summary>
            [NameInMap("OpsOwnerIdList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerIdList { get; set; }

            /// <summary>
            /// <para>The PAI configuration.</para>
            /// </summary>
            [NameInMap("PaiConfig")]
            [Validation(Required=false)]
            public CreateBatchTaskRequestCreateCommandPaiConfig PaiConfig { get; set; }
            public class CreateBatchTaskRequestCreateCommandPaiConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the PAI experiment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>789012</para>
                /// </summary>
                [NameInMap("ExperimentId")]
                [Validation(Required=false)]
                public string ExperimentId { get; set; }

                /// <summary>
                /// <para>The PAI region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the PAI workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("WorkSpaceId")]
                [Validation(Required=false)]
                public string WorkSpaceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the project to which the task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10121101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The third-party Python packages that the task depends on.</para>
            /// </summary>
            [NameInMap("PythonModuleList")]
            [Validation(Required=false)]
            public List<string> PythonModuleList { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values: 1 (periodic task) and 3 (manual task).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public int? ScheduleType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable dynamic resource configuration for Spark. This parameter takes effect only for Spark SQL tasks. If you do not specify this parameter, dynamic resource configuration is enabled by default for Spark SQL tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SparkDynamicResourceSwitch")]
            [Validation(Required=false)]
            public bool? SparkDynamicResourceSwitch { get; set; }

            /// <summary>
            /// <para>The effective scope of Spark resources. Valid values: ONLY_PROD and PROD_AND_DEV. If you do not specify this parameter, the default value ONLY_PROD is used for Spark SQL tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLY_PROD</para>
            /// </summary>
            [NameInMap("SparkResourceEffectScope")]
            [Validation(Required=false)]
            public string SparkResourceEffectScope { get; set; }

            /// <summary>
            /// <para>The resource configuration for the Spark task. The value is a JSON string, such as {&quot;spark.executor.memory&quot;:&quot;2g&quot;}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;spark.executor.memory&quot;:&quot;2g&quot;}</para>
            /// </summary>
            [NameInMap("SparkSqlResourceConfigMap")]
            [Validation(Required=false)]
            public string SparkSqlResourceConfigMap { get; set; }

            /// <summary>
            /// <para>The MaxCompute Spark version. Valid values: MAX_COMPUTE_23X, MAX_COMPUTE_245X, and MAX_COMPUTE_311X. For Apsara Stack, only MAX_COMPUTE_APSARA is supported. Display names such as Spark 2.3.0, Spark 2.4.5, and Spark 3.1.1 are also accepted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Spark 3.1.1</para>
            /// </summary>
            [NameInMap("SparkVersion")]
            [Validation(Required=false)]
            public string SparkVersion { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Hive_SQL.</description></item>
            /// <item><description>101: Hive_SQL_23X.</description></item>
            /// <item><description>111: HIVE_SQL_FUSION_INSIGHT_80X.</description></item>
            /// <item><description>131: COMMON_HIVE_SQL.</description></item>
            /// <item><description>2: HADOOP_MR.</description></item>
            /// <item><description>5: MaxCompute_SQL.</description></item>
            /// <item><description>6: MaxCompute_MR.</description></item>
            /// <item><description>7: SPARK_SQL_ON_MAX_COMPUTE.</description></item>
            /// <item><description>8: SPARK_JAR_ON_MAX_COMPUTE.</description></item>
            /// <item><description>17: SPARK_SQL_ON_HIVE.</description></item>
            /// <item><description>18: Spark_JAR_ON_HIVE.</description></item>
            /// <item><description>10: Shell.</description></item>
            /// <item><description>71: PAI_DESIGNER.</description></item>
            /// <item><description>15: DataX.</description></item>
            /// <item><description>16: Merge.</description></item>
            /// <item><description>21: Python.</description></item>
            /// <item><description>22: Python37x.</description></item>
            /// <item><description>23: Perl.</description></item>
            /// <item><description>24: Python311x.</description></item>
            /// <item><description>25: OneService_SQL.</description></item>
            /// <item><description>26: ONE_SERVICE_SQL_ADB_FOR_PG.</description></item>
            /// <item><description>27: OneService_SQL_Hive11x.</description></item>
            /// <item><description>29: OneService_SQL_Hive23x.</description></item>
            /// <item><description>75: ONE_SERVICE_SQL_TDH_INCEPTOR.</description></item>
            /// <item><description>91: ONE_SERVICE_SQL_HIVE_CDP.</description></item>
            /// <item><description>92: ONE_SERVICE_SQL_HIVE_ASIA_INFO_DP_53X.</description></item>
            /// <item><description>30: Dlink.</description></item>
            /// <item><description>33: ONE_SERVICE_SQL_ADB_FOR_MYSQL.</description></item>
            /// <item><description>31: Logical.</description></item>
            /// <item><description>41: Flink_Streaming.</description></item>
            /// <item><description>42: Flink_Batch.</description></item>
            /// <item><description>51: ADB_FOR_PG.</description></item>
            /// <item><description>100: DryRun.</description></item>
            /// <item><description>902: CHECK.</description></item>
            /// <item><description>999: VIRTUAL.</description></item>
            /// <item><description>10000: INCEPTOR_SQL.</description></item>
            /// <item><description>28: HOLOGRES_SQL.</description></item>
            /// <item><description>76: ARGODB_SQL.</description></item>
            /// <item><description>78: IMPALA_SQL.</description></item>
            /// <item><description>79: STARROCKS_SQL.</description></item>
            /// <item><description>80: SPARK_SQL.</description></item>
            /// <item><description>81: GAUSS_SQL.</description></item>
            /// <item><description>998: DATABASE_SQL.</description></item>
            /// <item><description>997: EXTERNAL_TRIGGER.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
