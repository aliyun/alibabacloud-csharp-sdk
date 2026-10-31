// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBatchTemplateVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBatchTemplateVersionsResponseBodyData Data { get; set; }
        public class GetBatchTemplateVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The template version list.</para>
            /// </summary>
            [NameInMap("TemplateVersionList")]
            [Validation(Required=false)]
            public List<GetBatchTemplateVersionsResponseBodyDataTemplateVersionList> TemplateVersionList { get; set; }
            public class GetBatchTemplateVersionsResponseBodyDataTemplateVersionList : TeaModel {
                /// <summary>
                /// <para>The template submission comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Initial submission</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The template content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash
                /// echo \&quot;hello world\&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The data source configuration of the database SQL template.</para>
                /// </summary>
                [NameInMap("DataSourceConfig")]
                [Validation(Required=false)]
                public GetBatchTemplateVersionsResponseBodyDataTemplateVersionListDataSourceConfig DataSourceConfig { get; set; }
                public class GetBatchTemplateVersionsResponseBodyDataTemplateVersionListDataSourceConfig : TeaModel {
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
                    /// <para>The data source type of the database SQL template. Valid values: MYSQL, ORACLE, ADB_FOR_PG, OUSHUDB, PRESTO, POSTGRE_SQL, STARROCKS, CLICKHOUSE, ANALYTICDB, ADB_FOR_MYSQL_V3, GAUSSDB, SELECTDB, DORIS, SQL_SERVER, HOLOGRES, OPENGAUSS, DAMENG, OCEANBASE, TRINO, POLARDB_X2, LINDORM, EMR_SPARK_SERVERLESS, TDSQL_FOR_PG, TDSQL_FOR_MYSQL, GBASE_8A, and TDENGINE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MYSQL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The template description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shell template for data processing</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the resource group in the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DevResourceGroupId")]
                [Validation(Required=false)]
                public string DevResourceGroupId { get; set; }

                /// <summary>
                /// <para>The name of the resource group in the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group for the project</para>
                /// </summary>
                [NameInMap("DevResourceGroupName")]
                [Validation(Required=false)]
                public string DevResourceGroupName { get; set; }

                /// <summary>
                /// <para>The version of the compute engine. Valid values: Python 2.7 and Python 3.7.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Python 3.7</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The time when the template was created. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the template was updated. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-28 15:30:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the template, which is the same as the menu tree node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The last user who updated the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Si</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The ID of the last user who updated the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100002</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data processing template</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type. Valid values: 10 (Shell) and 21 (Python).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OperatorType")]
                [Validation(Required=false)]
                public int? OperatorType { get; set; }

                /// <summary>
                /// <para>The owner of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the template owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The list of template parameters.</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public List<GetBatchTemplateVersionsResponseBodyDataTemplateVersionListParams> Params { get; set; }
                public class GetBatchTemplateVersionsResponseBodyDataTemplateVersionListParams : TeaModel {
                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether encryption is enabled for the parameter.</para>
                    /// </summary>
                    [NameInMap("EncryptEnabled")]
                    [Validation(Required=false)]
                    public bool? EncryptEnabled { get; set; }

                    /// <summary>
                    /// <para>The key of the parameter.</para>
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
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of dependent Python third-party packages.</para>
                /// </summary>
                [NameInMap("PythonModuleList")]
                [Validation(Required=false)]
                public List<GetBatchTemplateVersionsResponseBodyDataTemplateVersionListPythonModuleList> PythonModuleList { get; set; }
                public class GetBatchTemplateVersionsResponseBodyDataTemplateVersionListPythonModuleList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Python third-party package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The installation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-01-01 10:00:00</para>
                    /// </summary>
                    [NameInMap("InstallTime")]
                    [Validation(Required=false)]
                    public string InstallTime { get; set; }

                    /// <summary>
                    /// <para>The name of the Python third-party package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>numpy</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The Python version. Valid values: PYTHON_2_7, PYTHON_3_7, and PYTHON_3_11.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PYTHON_2_7</para>
                    /// </summary>
                    [NameInMap("PythonVersion")]
                    [Validation(Required=false)]
                    public string PythonVersion { get; set; }

                    /// <summary>
                    /// <para>The status of the third-party package. Valid values: INSTALL_SUCCESS (installed), INSTALL_FAILED (installation failed), INSTALLING (installing), UPGRADE_SUCCESS (upgraded), UPGRADE_FAILED (upgrade failed), and UPGRADING (upgrading).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INSTALL_SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The version of the third-party package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The ID of the resource group in the production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The name of the resource group in the production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group for the project</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <para>Indicates whether runtime resources are shared.</para>
                /// </summary>
                [NameInMap("ShareRuntimeResource")]
                [Validation(Required=false)]
                public bool? ShareRuntimeResource { get; set; }

                /// <summary>
                /// <para>The status of the template. Valid values: 0 (draft), 2 (submitted), and 100 (in development).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
