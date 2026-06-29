// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The request for creating an API.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDataServiceApiRequestCreateCommand CreateCommand { get; set; }
        public class CreateDataServiceApiRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The group ID of the API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ApiGroupId")]
            [Validation(Required=false)]
            public long? ApiGroupId { get; set; }

            /// <summary>
            /// <para>The group name of the API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认API分组</para>
            /// </summary>
            [NameInMap("ApiGroupName")]
            [Validation(Required=false)]
            public string ApiGroupName { get; set; }

            /// <summary>
            /// <para>The name of the API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API_01</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The type of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>3: datasource SQL mode.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public int? ApiType { get; set; }

            /// <summary>
            /// <para>The protocol. Different gateway types support different protocols. For more information, see the documentation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: HTTP </description></item>
            /// <item><description>1: HTTPS.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("BizProtocol")]
            [Validation(Required=false)]
            public List<int?> BizProtocol { get; set; }

            /// <summary>
            /// <para>The cache timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("CacheTimeout")]
            [Validation(Required=false)]
            public int? CacheTimeout { get; set; }

            /// <summary>
            /// <para>The call mode of the API. Default value: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: synchronous call</description></item>
            /// <item><description>2: asynchronous call.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallMode")]
            [Validation(Required=false)]
            public int? CallMode { get; set; }

            /// <summary>
            /// <para>The custom update frequency. This parameter is required when the update frequency is set to custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>每天8点</para>
            /// </summary>
            [NameInMap("CustomUpdateRate")]
            [Validation(Required=false)]
            public string CustomUpdateRate { get; set; }

            /// <summary>
            /// <para>The description of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configuration of the operation-type API. This parameter is not required when creating a query-type API.</para>
            /// </summary>
            [NameInMap("DmlConfig")]
            [Validation(Required=false)]
            public CreateDataServiceApiRequestCreateCommandDmlConfig DmlConfig { get; set; }
            public class CreateDataServiceApiRequestCreateCommandDmlConfig : TeaModel {
                /// <summary>
                /// <para>The data volume per batch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When the data volume type is single record, this parameter cannot be set.</description></item>
                /// <item><description>When the data volume type is batch:<list type="bullet">
                /// <item><description>If the transaction processing mode is 1, this parameter cannot be set.</description></item>
                /// <item><description>If the transaction processing mode is 2, the value ranges from 1 to 1000000.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BatchInputDataSize")]
                [Validation(Required=false)]
                public int? BatchInputDataSize { get; set; }

                /// <summary>
                /// <para>The data volume type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: single record</description></item>
                /// <item><description>2: batch.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DataVolumeType")]
                [Validation(Required=false)]
                public int? DataVolumeType { get; set; }

                /// <summary>
                /// <para>The error handling method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: partial success allowed</description></item>
                /// <item><description>2: all must succeed</description></item>
                /// </list>
                /// <para>Parameter rules:</para>
                /// <list type="bullet">
                /// <item><description>When the data volume type is single record, this parameter cannot be set.</description></item>
                /// <item><description>When the data volume type is batch, the value is 1 or 2.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorHandlingType")]
                [Validation(Required=false)]
                public int? ErrorHandlingType { get; set; }

                /// <summary>
                /// <para>The maximum number of input records. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When the data volume type is single record, this parameter cannot be set.</description></item>
                /// <item><description>When the data volume type is batch, the value ranges from 1 to 1000000.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("MaxInputDataSize")]
                [Validation(Required=false)]
                public int? MaxInputDataSize { get; set; }

                /// <summary>
                /// <para>The degree of parallelism. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When the data volume type is single record, this parameter cannot be set.</description></item>
                /// <item><description>When the data volume type is batch:<list type="bullet">
                /// <item><description>If the transaction processing mode is 1, this parameter cannot be set.</description></item>
                /// <item><description>If the transaction processing mode is 2, the value ranges from 1 to 5.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParallelNum")]
                [Validation(Required=false)]
                public int? ParallelNum { get; set; }

                /// <summary>
                /// <para>The transaction processing mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no transaction</description></item>
                /// <item><description>1: no batching</description></item>
                /// <item><description>2: batch processing</description></item>
                /// </list>
                /// <para>Parameter rules:</para>
                /// <list type="bullet">
                /// <item><description>When the data volume type is single record, the transaction processing mode is 0.</description></item>
                /// <item><description>When the data volume type is batch:<list type="bullet">
                /// <item><description>If the error handling method is 1, the transaction processing mode is 1 or 2.</description></item>
                /// <item><description>If the error handling method is 2, the transaction processing mode can only be 1.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TransactionType")]
                [Validation(Required=false)]
                public int? TransactionType { get; set; }

            }

            /// <summary>
            /// <para>The execution timeout period for asynchronous API calls. This parameter takes effect only for asynchronous API calls and is required when the call mode is asynchronous.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ExecutionTimeout")]
            [Validation(Required=false)]
            public int? ExecutionTimeout { get; set; }

            /// <summary>
            /// <para>The development mode of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Basic mode </description></item>
            /// <item><description>1: Dev-Prod mode.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The ID of the data service project.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The request method of the API. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (GET): Returns a single record. The query result is unique. </description></item>
            /// <item><description>1 (LIST): Returns multiple records.</description></item>
            /// <item><description>2 (CREATE): Creates objects. Supports single or batch creation.</description></item>
            /// <item><description>3 (UPDATE): Updates objects. Supports single or batch updates.</description></item>
            /// <item><description>4 (DELETE): Deletes objects. Supports single or batch deletions.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RequestType")]
            [Validation(Required=false)]
            public int? RequestType { get; set; }

            /// <summary>
            /// <para>Specifies whether to return the SQL in the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReturnSqlSwitch")]
            [Validation(Required=false)]
            public bool? ReturnSqlSwitch { get; set; }

            /// <summary>
            /// <para>The list of row-level permission IDs.</para>
            /// </summary>
            [NameInMap("RowPermissionIds")]
            [Validation(Required=false)]
            public List<long?> RowPermissionIds { get; set; }

            /// <summary>
            /// <para>The details of the script API.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScriptDetails")]
            [Validation(Required=false)]
            public CreateDataServiceApiRequestCreateCommandScriptDetails ScriptDetails { get; set; }
            public class CreateDataServiceApiRequestCreateCommandScriptDetails : TeaModel {
                /// <summary>
                /// <para>The ID of the datasource. This parameter is required when the API mode is direct datasource connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6668888888888812345L</para>
                /// </summary>
                [NameInMap("DatasourceID")]
                [Validation(Required=false)]
                public long? DatasourceID { get; set; }

                /// <summary>
                /// <para>The data type on which the API is based. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: datasource.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DatasourceType")]
                [Validation(Required=false)]
                public int? DatasourceType { get; set; }

                /// <summary>
                /// <para>Specifies whether to paginate the results. This parameter is required only when RequestType is set to List. Default value: false. Pagination is not supported in asynchronous call mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPaginated")]
                [Validation(Required=false)]
                public bool? IsPaginated { get; set; }

                /// <summary>
                /// <para>The SQL script.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select a,b,c from table1 where d = ${d}</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// <para>The list of request parameters for the script API.</para>
                /// </summary>
                [NameInMap("ScriptRequestParameters")]
                [Validation(Required=false)]
                public List<CreateDataServiceApiRequestCreateCommandScriptDetailsScriptRequestParameters> ScriptRequestParameters { get; set; }
                public class CreateDataServiceApiRequestCreateCommandScriptDetailsScriptRequestParameters : TeaModel {
                    /// <summary>
                    /// <para>The default value of the input parameter for operation-type APIs. This parameter takes effect when the parameter is not required. If not specified, the value is null.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The example value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the parameter is required.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsRequiredParameter")]
                    [Validation(Required=false)]
                    public bool? IsRequiredParameter { get; set; }

                    /// <summary>
                    /// <para>The data type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>&quot;STRING&quot;</description></item>
                    /// <item><description>&quot;DOUBLE&quot;</description></item>
                    /// <item><description>&quot;INT&quot;</description></item>
                    /// <item><description>&quot;DATE&quot;</description></item>
                    /// <item><description>&quot;LONG&quot;</description></item>
                    /// <item><description>&quot;FLOAT&quot;</description></item>
                    /// <item><description>&quot;BOOLEAN&quot;</description></item>
                    /// <item><description>&quot;SHORT&quot;</description></item>
                    /// <item><description>&quot;BYTE&quot;</description></item>
                    /// <item><description>&quot;BIGDECIMAL&quot;</description></item>
                    /// <item><description>&quot;BINARY&quot;</description></item>
                    /// <item><description>&quot;ARRAY&quot;</description></item>
                    /// <item><description>&quot;Array(int)&quot;</description></item>
                    /// <item><description>&quot;Array(string)&quot;.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public string ParameterDataType { get; set; }

                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>字段d</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The value type of the parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1 (single value): A fixed value used for operators such as =, &gt;=, &lt;=, &gt;, &lt;, !=, and between. </description></item>
                    /// <item><description>2 (multiple values): The input parameter contains multiple values separated by commas (,). Used for In and Not In operators.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("ParameterValueType")]
                    [Validation(Required=false)]
                    public string ParameterValueType { get; set; }

                }

                /// <summary>
                /// <para>The list of response parameters for the script API.</para>
                /// </summary>
                [NameInMap("ScriptResponseParameters")]
                [Validation(Required=false)]
                public List<CreateDataServiceApiRequestCreateCommandScriptDetailsScriptResponseParameters> ScriptResponseParameters { get; set; }
                public class CreateDataServiceApiRequestCreateCommandScriptDetailsScriptResponseParameters : TeaModel {
                    /// <summary>
                    /// <para>The example value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>amazing</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <para>The data type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>&quot;STRING&quot;</description></item>
                    /// <item><description>&quot;DOUBLE&quot;</description></item>
                    /// <item><description>&quot;INT&quot;</description></item>
                    /// <item><description>&quot;DATE&quot;</description></item>
                    /// <item><description>&quot;LONG&quot;</description></item>
                    /// <item><description>&quot;FLOAT&quot;</description></item>
                    /// <item><description>&quot;BOOLEAN&quot;</description></item>
                    /// <item><description>&quot;SHORT&quot;</description></item>
                    /// <item><description>&quot;BYTE&quot;</description></item>
                    /// <item><description>&quot;BIGDECIMAL&quot;</description></item>
                    /// <item><description>&quot;BINARY&quot;</description></item>
                    /// <item><description>&quot;ARRAY&quot;</description></item>
                    /// <item><description>&quot;Array(int)&quot;</description></item>
                    /// <item><description>&quot;Array(string)&quot;.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public string ParameterDataType { get; set; }

                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>字段a</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <para>The location of the response parameter for operation-type APIs. This parameter must be set when the API is an operation-type API with batch data volume. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>success: the response data of a successful operation</description></item>
                    /// <item><description>failed: the response data of a failed operation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("ParameterLocation")]
                    [Validation(Required=false)]
                    public string ParameterLocation { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                }

                /// <summary>
                /// <para>The sorting priority. This parameter takes effect only when the SQL mode is basic mode. Default value: 2. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: SQL script </description></item>
                /// <item><description>2: OrderByList request parameter.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SortPriority")]
                [Validation(Required=false)]
                public int? SortPriority { get; set; }

                /// <summary>
                /// <para>The SQL mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: basic mode</description></item>
                /// <item><description>2: advanced mode.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SqlMode")]
                [Validation(Required=false)]
                public int? SqlMode { get; set; }

            }

            /// <summary>
            /// <para>The timeout period, in seconds.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The update frequency. Default value: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: custom</description></item>
            /// <item><description>1: day</description></item>
            /// <item><description>2: hour</description></item>
            /// <item><description>3: minute.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateRate")]
            [Validation(Required=false)]
            public int? UpdateRate { get; set; }

            /// <summary>
            /// <para>The version of the API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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

    }

}
