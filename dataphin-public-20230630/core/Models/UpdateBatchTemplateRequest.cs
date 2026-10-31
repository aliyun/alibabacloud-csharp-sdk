// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBatchTemplateRequest : TeaModel {
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

        /// <summary>
        /// <para>The template update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateBatchTemplateRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateBatchTemplateRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The template content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo 123</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The datasource config for database SQL templates. This parameter takes effect only for database SQL templates.</para>
            /// </summary>
            [NameInMap("DataSourceConfig")]
            [Validation(Required=false)]
            public UpdateBatchTemplateRequestUpdateCommandDataSourceConfig DataSourceConfig { get; set; }
            public class UpdateBatchTemplateRequestUpdateCommandDataSourceConfig : TeaModel {
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
            /// <para>The folder of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/Data development/Templates</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

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
            /// <para>The list of template parameters.</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public List<UpdateBatchTemplateRequestUpdateCommandParams> Params { get; set; }
            public class UpdateBatchTemplateRequestUpdateCommandParams : TeaModel {
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

            /// <summary>
            /// <para>The ID of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
