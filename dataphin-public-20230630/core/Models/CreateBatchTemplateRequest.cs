// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBatchTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The command to create a template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBatchTemplateRequestCreateCommand CreateCommand { get; set; }
        public class CreateBatchTemplateRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The content of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo 123</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The datasource config for database SQL templates, which takes effect only for database SQL templates.</para>
            /// </summary>
            [NameInMap("DataSourceConfig")]
            [Validation(Required=false)]
            public CreateBatchTemplateRequestCreateCommandDataSourceConfig DataSourceConfig { get; set; }
            public class CreateBatchTemplateRequestCreateCommandDataSourceConfig : TeaModel {
                /// <summary>
                /// <para>The catalog of the data source for the database SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The ID of the data source for the database SQL template.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("DsId")]
                [Validation(Required=false)]
                public string DsId { get; set; }

                /// <summary>
                /// <para>The schema of the data source for the database SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>The type of the data source for the database SQL template. Valid values: MYSQL, ORACLE, ADB_FOR_PG, OUSHUDB, PRESTO, POSTGRE_SQL, STARROCKS, CLICKHOUSE, ANALYTICDB, ADB_FOR_MYSQL_V3, GAUSSDB, SELECTDB, DORIS, SQL_SERVER, HOLOGRES, OPENGAUSS, DAMENG, OCEANBASE, TRINO, POLARDB_X2, LINDORM, EMR_SPARK_SERVERLESS, TDSQL_FOR_PG, TDSQL_FOR_MYSQL, GBASE_8A, and TDENGINE.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MYSQL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shell template for data processing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the resource group in the development environment. By default, the default resource group of the project is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("DevResourceGroupId")]
            [Validation(Required=false)]
            public string DevResourceGroupId { get; set; }

            /// <summary>
            /// <para>The directory of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/Data Development/Templates</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The compute engine version. Valid values: PYTHON_2_7, PYTHON_3_7, and PYTHON_3_11.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PYTHON_3_7</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data processing template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The node type of the template. Valid values: 10: Shell, 21: Python, 998: Database SQL, 5: MaxCompute SQL, 6: MapReduce on MaxCompute, 8: Spark on MaxCompute, 28: Hologres SQL, 1: Hive SQL, 2: MapReduce on Yarn, 18: Spark on Yarn, 78: Impala SQL, 80: Spark SQL, 10000: Inceptor SQL, 51: AnalyticDB for PostgreSQL SQL, 81: GaussDB SQL, 82: Databricks SQL, 76: ArgoDB SQL, 79: StarRocks SQL, 202: SelectDB SQL, 201: Doris SQL, and 203: OushuDB SQL.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public int? OperatorType { get; set; }

            /// <summary>
            /// <para>The list of template parameters.</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public List<CreateBatchTemplateRequestCreateCommandParams> Params { get; set; }
            public class CreateBatchTemplateRequestCreateCommandParams : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Input date</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether encryption is enabled for the parameter.</para>
                /// </summary>
                [NameInMap("EncryptEnabled")]
                [Validation(Required=false)]
                public bool? EncryptEnabled { get; set; }

                /// <summary>
                /// <para>The key of the parameter.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of IDs of dependent third-party Python packages.</para>
            /// </summary>
            [NameInMap("PythonModuleIds")]
            [Validation(Required=false)]
            public List<long?> PythonModuleIds { get; set; }

            /// <summary>
            /// <para>The ID of the resource group in the production environment. By default, the default resource group of the project is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Specifies whether to share runtime resources.</para>
            /// </summary>
            [NameInMap("ShareRuntimeResource")]
            [Validation(Required=false)]
            public bool? ShareRuntimeResource { get; set; }

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

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
