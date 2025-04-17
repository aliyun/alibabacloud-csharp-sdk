// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListApiByAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListApiByAppResponseBodyListResult ListResult { get; set; }
        public class ListApiByAppResponseBodyListResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListApiByAppResponseBodyListResultData> Data { get; set; }
            public class ListApiByAppResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>987654321</para>
                /// </summary>
                [NameInMap("ApiNo")]
                [Validation(Required=false)]
                public long? ApiNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ApiTimeout")]
                [Validation(Required=false)]
                public long? ApiTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleApp</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleModule</para>
                /// </summary>
                [NameInMap("BizModuleEnName")]
                [Validation(Required=false)]
                public string BizModuleEnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CacheSwitch")]
                [Validation(Required=false)]
                public string CacheSwitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("CacheTime")]
                [Validation(Required=false)]
                public string CacheTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public long? CreateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DbEnv")]
                [Validation(Required=false)]
                public long? DbEnv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这是一个示例API</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>54321</para>
                /// </summary>
                [NameInMap("DirectDatasourceId")]
                [Validation(Required=false)]
                public long? DirectDatasourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>directDatasource</para>
                /// </summary>
                [NameInMap("DirectDatasourceName")]
                [Validation(Required=false)]
                public string DirectDatasourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>67890</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsLogicalTable")]
                [Validation(Required=false)]
                public bool? IsLogicalTable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsPagedQuery")]
                [Validation(Required=false)]
                public long? IsPagedQuery { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxReturnNum")]
                [Validation(Required=false)]
                public long? MaxReturnNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ModelType")]
                [Validation(Required=false)]
                public long? ModelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleApi</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>112233</para>
                /// </summary>
                [NameInMap("ProjId")]
                [Validation(Required=false)]
                public long? ProjId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleProject</para>
                /// </summary>
                [NameInMap("ProjName")]
                [Validation(Required=false)]
                public string ProjName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public long? Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP和HTTPS</para>
                /// </summary>
                [NameInMap("ProtocolName")]
                [Validation(Required=false)]
                public string ProtocolName { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("PublicParamList")]
                [Validation(Required=false)]
                public List<ListApiByAppResponseBodyListResultDataPublicParamList> PublicParamList { get; set; }
                public class ListApiByAppResponseBodyListResultDataPublicParamList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yyyy-MM-dd</para>
                    /// </summary>
                    [NameInMap("DateFormat")]
                    [Validation(Required=false)]
                    public string DateFormat { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default_public_value</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这是一个示例公共参数</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CODE_003</para>
                    /// </summary>
                    [NameInMap("DescriptionCode")]
                    [Validation(Required=false)]
                    public string DescriptionCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>app_key_value</para>
                    /// </summary>
                    [NameInMap("InitialValue")]
                    [Validation(Required=false)]
                    public string InitialValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>publicColumn1</para>
                    /// </summary>
                    [NameInMap("MappingColumn")]
                    [Validation(Required=false)]
                    public string MappingColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Must")]
                    [Validation(Required=false)]
                    public long? Must { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Optional")]
                    [Validation(Required=false)]
                    public long? Optional { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>original_public_column</para>
                    /// </summary>
                    [NameInMap("OriginalColumn")]
                    [Validation(Required=false)]
                    public string OriginalColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>publicParam1</para>
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/path/to/public_param</para>
                    /// </summary>
                    [NameInMap("ParameterLocation")]
                    [Validation(Required=false)]
                    public string ParameterLocation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>publicValue1</para>
                    /// </summary>
                    [NameInMap("Sample")]
                    [Validation(Required=false)]
                    public string Sample { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("TableAndDsList")]
                    [Validation(Required=false)]
                    public List<ListApiByAppResponseBodyListResultDataPublicParamListTableAndDsList> TableAndDsList { get; set; }
                    public class ListApiByAppResponseBodyListResultDataPublicParamListTableAndDsList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ds54321</para>
                        /// </summary>
                        [NameInMap("DatasourceId")]
                        [Validation(Required=false)]
                        public string DatasourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>publicDatasource</para>
                        /// </summary>
                        [NameInMap("DatasourceName")]
                        [Validation(Required=false)]
                        public string DatasourceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("DatasourceType")]
                        [Validation(Required=false)]
                        public long? DatasourceType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/public_datasource">https://example.com/public_datasource</a></para>
                        /// </summary>
                        [NameInMap("DatasourceUrl")]
                        [Validation(Required=false)]
                        public string DatasourceUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>public_table</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

                [NameInMap("RegisterApi")]
                [Validation(Required=false)]
                public ListApiByAppResponseBodyListResultDataRegisterApi RegisterApi { get; set; }
                public class ListApiByAppResponseBodyListResultDataRegisterApi : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>67890</para>
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public long? ApiId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OAuth2</para>
                    /// </summary>
                    [NameInMap("AuthenticationMode")]
                    [Validation(Required=false)]
                    public string AuthenticationMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ds67890</para>
                    /// </summary>
                    [NameInMap("DatasourceId")]
                    [Validation(Required=false)]
                    public string DatasourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>registerDatasource</para>
                    /// </summary>
                    [NameInMap("DatasourceName")]
                    [Validation(Required=false)]
                    public string DatasourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;status&quot;:&quot;error&quot;,&quot;message&quot;:&quot;Invalid request&quot;}</para>
                    /// </summary>
                    [NameInMap("FailExample")]
                    [Validation(Required=false)]
                    public string FailExample { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HttpMethod")]
                    [Validation(Required=false)]
                    public long? HttpMethod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ModelType")]
                    [Validation(Required=false)]
                    public long? ModelType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/api/v1/register</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HTTPS</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;status&quot;:&quot;success&quot;,&quot;data&quot;:[]}</para>
                    /// </summary>
                    [NameInMap("SuccessExample")]
                    [Validation(Required=false)]
                    public string SuccessExample { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/register_api">https://example.com/register_api</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RequestMethod")]
                [Validation(Required=false)]
                public long? RequestMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("RequestMethodName")]
                [Validation(Required=false)]
                public string RequestMethodName { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("RequestParamList")]
                [Validation(Required=false)]
                public List<ListApiByAppResponseBodyListResultDataRequestParamList> RequestParamList { get; set; }
                public class ListApiByAppResponseBodyListResultDataRequestParamList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yyyy-MM-dd</para>
                    /// </summary>
                    [NameInMap("DateFormat")]
                    [Validation(Required=false)]
                    public string DateFormat { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default_value</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这是一个示例参数</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CODE_001</para>
                    /// </summary>
                    [NameInMap("DescriptionCode")]
                    [Validation(Required=false)]
                    public string DescriptionCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>app_key_value</para>
                    /// </summary>
                    [NameInMap("InitialValue")]
                    [Validation(Required=false)]
                    public string InitialValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>column1</para>
                    /// </summary>
                    [NameInMap("MappingColumn")]
                    [Validation(Required=false)]
                    public string MappingColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Must")]
                    [Validation(Required=false)]
                    public long? Must { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Optional")]
                    [Validation(Required=false)]
                    public long? Optional { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>original_column</para>
                    /// </summary>
                    [NameInMap("OriginalColumn")]
                    [Validation(Required=false)]
                    public string OriginalColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/path/to/param</para>
                    /// </summary>
                    [NameInMap("ParameterLocation")]
                    [Validation(Required=false)]
                    public string ParameterLocation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value1</para>
                    /// </summary>
                    [NameInMap("Sample")]
                    [Validation(Required=false)]
                    public string Sample { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("TableAndDsList")]
                    [Validation(Required=false)]
                    public List<ListApiByAppResponseBodyListResultDataRequestParamListTableAndDsList> TableAndDsList { get; set; }
                    public class ListApiByAppResponseBodyListResultDataRequestParamListTableAndDsList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ds12345</para>
                        /// </summary>
                        [NameInMap("DatasourceId")]
                        [Validation(Required=false)]
                        public string DatasourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>exampleDatasource</para>
                        /// </summary>
                        [NameInMap("DatasourceName")]
                        [Validation(Required=false)]
                        public string DatasourceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DatasourceType")]
                        [Validation(Required=false)]
                        public long? DatasourceType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/datasource">https://example.com/datasource</a></para>
                        /// </summary>
                        [NameInMap("DatasourceUrl")]
                        [Validation(Required=false)]
                        public string DatasourceUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>example_table</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleResourceGroup</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ResponseParamList")]
                [Validation(Required=false)]
                public List<ListApiByAppResponseBodyListResultDataResponseParamList> ResponseParamList { get; set; }
                public class ListApiByAppResponseBodyListResultDataResponseParamList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yyyy-MM-dd</para>
                    /// </summary>
                    [NameInMap("DateFormat")]
                    [Validation(Required=false)]
                    public string DateFormat { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default_response_value</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这是一个示例响应参数</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CODE_002</para>
                    /// </summary>
                    [NameInMap("DescriptionCode")]
                    [Validation(Required=false)]
                    public string DescriptionCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>app_key_value</para>
                    /// </summary>
                    [NameInMap("InitialValue")]
                    [Validation(Required=false)]
                    public string InitialValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>responseColumn1</para>
                    /// </summary>
                    [NameInMap("MappingColumn")]
                    [Validation(Required=false)]
                    public string MappingColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Must")]
                    [Validation(Required=false)]
                    public long? Must { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Optional")]
                    [Validation(Required=false)]
                    public long? Optional { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>original_response_column</para>
                    /// </summary>
                    [NameInMap("OriginalColumn")]
                    [Validation(Required=false)]
                    public string OriginalColumn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>responseParam1</para>
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/path/to/response_param</para>
                    /// </summary>
                    [NameInMap("ParameterLocation")]
                    [Validation(Required=false)]
                    public string ParameterLocation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>responseValue1</para>
                    /// </summary>
                    [NameInMap("Sample")]
                    [Validation(Required=false)]
                    public string Sample { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("TableAndDsList")]
                    [Validation(Required=false)]
                    public List<ListApiByAppResponseBodyListResultDataResponseParamListTableAndDsList> TableAndDsList { get; set; }
                    public class ListApiByAppResponseBodyListResultDataResponseParamListTableAndDsList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ds67890</para>
                        /// </summary>
                        [NameInMap("DatasourceId")]
                        [Validation(Required=false)]
                        public string DatasourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>responseDatasource</para>
                        /// </summary>
                        [NameInMap("DatasourceName")]
                        [Validation(Required=false)]
                        public string DatasourceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("DatasourceType")]
                        [Validation(Required=false)]
                        public long? DatasourceType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/response_datasource">https://example.com/response_datasource</a></para>
                        /// </summary>
                        [NameInMap("DatasourceUrl")]
                        [Validation(Required=false)]
                        public string DatasourceUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>response_table</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;status&quot;:&quot;success&quot;,&quot;data&quot;:[]}</para>
                /// </summary>
                [NameInMap("ResultSample")]
                [Validation(Required=false)]
                public string ResultSample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public long? ReturnType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("ReturnTypeName")]
                [Validation(Required=false)]
                public string ReturnTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>grp12345</para>
                /// </summary>
                [NameInMap("RsGrpId")]
                [Validation(Required=false)]
                public string RsGrpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("ScriptType")]
                [Validation(Required=false)]
                public string ScriptType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpecialSql")]
                [Validation(Required=false)]
                public long? SpecialSql { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT * FROM example_table</para>
                /// </summary>
                [NameInMap("SqlStatement")]
                [Validation(Required=false)]
                public string SqlStatement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleTable</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UpdateRate")]
                [Validation(Required=false)]
                public long? UpdateRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>每日更新</para>
                /// </summary>
                [NameInMap("UpdateRateName")]
                [Validation(Required=false)]
                public string UpdateRateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
