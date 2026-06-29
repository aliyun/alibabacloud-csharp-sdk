// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableLineageByTaskIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. OK indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetTableLineageByTaskIdResponseBodyData> Data { get; set; }
        public class GetTableLineageByTaskIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business unit ID of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InputBizUnitId")]
            [Validation(Required=false)]
            public long? InputBizUnitId { get; set; }

            /// <summary>
            /// <para>The data source ID of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InputDataSourceId")]
            [Validation(Required=false)]
            public long? InputDataSourceId { get; set; }

            /// <summary>
            /// <para>The storage type of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("InputDataSourceType")]
            [Validation(Required=false)]
            public string InputDataSourceType { get; set; }

            /// <summary>
            /// <para>The data source type of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("InputDbType")]
            [Validation(Required=false)]
            public string InputDbType { get; set; }

            /// <summary>
            /// <para>The environment of the input table: DEV or PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("InputEnv")]
            [Validation(Required=false)]
            public string InputEnv { get; set; }

            /// <summary>
            /// <para>The project ID of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("InputProjectId")]
            [Validation(Required=false)]
            public long? InputProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the input table is deleted.</para>
            /// </summary>
            [NameInMap("InputTableDeleted")]
            [Validation(Required=false)]
            public bool? InputTableDeleted { get; set; }

            /// <summary>
            /// <para>The GUID of the input table. Each asset has a unique GUID in the following format:</para>
            /// <list type="bullet">
            /// <item><description>Logical table: dp_table.[TenantId].[BusinessUnitName].[TableName]</description></item>
            /// <item><description>Compute source physical table: [EngineType].[TenantId].[ProjectName].[TableName]</description></item>
            /// <item><description>Data source table: dp_ds_table.[TenantId].[DataSourceId].[SchemaName].[TableName]</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>odps.123.test_project.order</para>
            /// </summary>
            [NameInMap("InputTableId")]
            [Validation(Required=false)]
            public string InputTableId { get; set; }

            /// <summary>
            /// <para>The name of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("InputTableName")]
            [Validation(Required=false)]
            public string InputTableName { get; set; }

            /// <summary>
            /// <para>The type of the input table. </para>
            /// <list type="bullet">
            /// <item><description>PHYSICAL_TABLE Physical table (compute source)</description></item>
            /// <item><description>DIM_LOGIC_TABLE Dimension logical table</description></item>
            /// <item><description>FACT_LOGIC_TABLE Fact logical table</description></item>
            /// <item><description>SUM_LOGIC_TABLE Aggregate logical table</description></item>
            /// <item><description>REAL_TIME_LOGIC_TABLE Real-time meta table</description></item>
            /// <item><description>REAL_TIME_MIRROR_TABLE Real-time mirror table</description></item>
            /// <item><description>PHYSICAL_VIEW Physical view</description></item>
            /// <item><description>LOGICAL_VIEW Logical view</description></item>
            /// <item><description>DATA_SOURCE_PHYSICAL_TABLE Data source table</description></item>
            /// <item><description>DATA_SOURCE_VIEW Data source view</description></item>
            /// <item><description>DATA_SOURCE_MATERIALIZED_VIEW Data source materialized view</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICAL_TABLE</para>
            /// </summary>
            [NameInMap("InputTableType")]
            [Validation(Required=false)]
            public string InputTableType { get; set; }

            /// <summary>
            /// <para>The business unit ID of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OutputBizUnitId")]
            [Validation(Required=false)]
            public long? OutputBizUnitId { get; set; }

            /// <summary>
            /// <para>The data source ID of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OutputDataSourceId")]
            [Validation(Required=false)]
            public long? OutputDataSourceId { get; set; }

            /// <summary>
            /// <para>The storage type of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("OutputDataSourceType")]
            [Validation(Required=false)]
            public string OutputDataSourceType { get; set; }

            /// <summary>
            /// <para>The data source type of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("OutputDbType")]
            [Validation(Required=false)]
            public string OutputDbType { get; set; }

            /// <summary>
            /// <para>The environment of the output table: DEV or PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV/PROD</para>
            /// </summary>
            [NameInMap("OutputEnv")]
            [Validation(Required=false)]
            public string OutputEnv { get; set; }

            /// <summary>
            /// <para>The project ID of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OutputProjectId")]
            [Validation(Required=false)]
            public long? OutputProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the output table is deleted.</para>
            /// </summary>
            [NameInMap("OutputTableDeleted")]
            [Validation(Required=false)]
            public bool? OutputTableDeleted { get; set; }

            /// <summary>
            /// <para>The GUID of the output table. Each asset has a unique GUID. For the format, see InputTableId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.123.test_project.order</para>
            /// </summary>
            [NameInMap("OutputTableId")]
            [Validation(Required=false)]
            public string OutputTableId { get; set; }

            /// <summary>
            /// <para>The name of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order</para>
            /// </summary>
            [NameInMap("OutputTableName")]
            [Validation(Required=false)]
            public string OutputTableName { get; set; }

            /// <summary>
            /// <para>The type of the output table. For valid values, see InputTableType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICAL_TABLE</para>
            /// </summary>
            [NameInMap("OutputTableType")]
            [Validation(Required=false)]
            public string OutputTableType { get; set; }

            /// <summary>
            /// <para>The environment of the task (node) associated with the lineage: DEV or PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("TaskEnv")]
            [Validation(Required=false)]
            public string TaskEnv { get; set; }

            /// <summary>
            /// <para>The task (node) ID associated with the lineage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
