// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceApiDocumentResponseBody : TeaModel {
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
        /// <para>The API documentation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiDocumentResponseBodyData Data { get; set; }
        public class GetDataServiceApiDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102101</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The API registration information.</para>
            /// </summary>
            [NameInMap("ApiRegisterInfo")]
            [Validation(Required=false)]
            public GetDataServiceApiDocumentResponseBodyDataApiRegisterInfo ApiRegisterInfo { get; set; }
            public class GetDataServiceApiDocumentResponseBodyDataApiRegisterInfo : TeaModel {
                /// <summary>
                /// <para>The authentication method for the API data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: BearToken</description></item>
                /// <item><description>2: ApiKey</description></item>
                /// <item><description>3: None</description></item>
                /// <item><description>4: AppKeyAuth</description></item>
                /// <item><description>5: BasicAuth.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The API data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102311</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public string DatasourceId { get; set; }

                /// <summary>
                /// <para>The API data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DatasourceName")]
                [Validation(Required=false)]
                public string DatasourceName { get; set; }

                /// <summary>
                /// <para>The HTTP method for the registered API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: GET</description></item>
                /// <item><description>2: POST.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public int? HttpMethod { get; set; }

                /// <summary>
                /// <para>The mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: basic</description></item>
                /// <item><description>1: dev_prod.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The service path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The request protocol for the API data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The timeout period, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The API data source URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://192.168.1.1:8080">http://192.168.1.1:8080</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The timeout period of the direct API, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ApiTimeout")]
            [Validation(Required=false)]
            public int? ApiTimeout { get; set; }

            /// <summary>
            /// <para>The business unit name. This parameter has a value only for logical tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bizUnit_test</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <para>The cache duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("CacheTime")]
            [Validation(Required=false)]
            public string CacheTime { get; set; }

            /// <summary>
            /// <para>The creation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: custom mode</description></item>
            /// <item><description>1: wizard mode</description></item>
            /// <item><description>2: direct API.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public int? CreateType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The data source ID of the direct API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DirectDatasourceId")]
            [Validation(Required=false)]
            public long? DirectDatasourceId { get; set; }

            /// <summary>
            /// <para>The data source name of the direct API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DirectDatasourceName")]
            [Validation(Required=false)]
            public string DirectDatasourceName { get; set; }

            /// <summary>
            /// <para>The environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: dev</description></item>
            /// <item><description>1: prod.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public int? Env { get; set; }

            /// <summary>
            /// <para>The API group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1011</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// <para>The API group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1011</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a logical table.</para>
            /// </summary>
            [NameInMap("IsLogicalTable")]
            [Validation(Required=false)]
            public bool? IsLogicalTable { get; set; }

            /// <summary>
            /// <para>Indicates whether the query is a paged query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Yes.</description></item>
            /// <item><description>0: No.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsPagedQuery")]
            [Validation(Required=false)]
            public bool? IsPagedQuery { get; set; }

            /// <summary>
            /// <para>Specifies whether the SQL is special. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsSpecialSql")]
            [Validation(Required=false)]
            public bool? IsSpecialSql { get; set; }

            /// <summary>
            /// <para>The mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: basic</description></item>
            /// <item><description>1: dev_prod.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether caching is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("OpenCache")]
            [Validation(Required=false)]
            public bool? OpenCache { get; set; }

            /// <summary>
            /// <para>The data service project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10201</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// <para>The data service project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: HTTPS</description></item>
            /// <item><description>2: HTTP</description></item>
            /// <item><description>3: both HTTP and HTTPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public int? Protocol { get; set; }

            /// <summary>
            /// <para>The list of common parameters.</para>
            /// </summary>
            [NameInMap("PublicParamList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiDocumentResponseBodyDataPublicParamList> PublicParamList { get; set; }
            public class GetDataServiceApiDocumentResponseBodyDataPublicParamList : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether the request parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Required.</description></item>
                /// <item><description>0: Optional.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("IsRequired")]
                [Validation(Required=false)]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>The frontend parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The request method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: get</description></item>
            /// <item><description>2: list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RequestMethod")]
            [Validation(Required=false)]
            public int? RequestMethod { get; set; }

            /// <summary>
            /// <para>The list of request parameters.</para>
            /// </summary>
            [NameInMap("RequestParamList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiDocumentResponseBodyDataRequestParamList> RequestParamList { get; set; }
            public class GetDataServiceApiDocumentResponseBodyDataRequestParamList : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether the request parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Required.</description></item>
                /// <item><description>0: Optional.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("IsRequired")]
                [Validation(Required=false)]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>The frontend parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10021</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The list of response parameters.</para>
            /// </summary>
            [NameInMap("ResponseParamList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiDocumentResponseBodyDataResponseParamList> ResponseParamList { get; set; }
            public class GetDataServiceApiDocumentResponseBodyDataResponseParamList : TeaModel {
                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The frontend parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The sample invocation result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;count&quot;: 88}</para>
            /// </summary>
            [NameInMap("ResultSample")]
            [Validation(Required=false)]
            public string ResultSample { get; set; }

            /// <summary>
            /// <para>The maximum number of records returned by the direct API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ReturnLimit")]
            [Validation(Required=false)]
            public int? ReturnLimit { get; set; }

            /// <summary>
            /// <para>The return data type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: JSON.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReturnType")]
            [Validation(Required=false)]
            public int? ReturnType { get; set; }

            /// <summary>
            /// <para>The script type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL_SQL: basic SQL</description></item>
            /// <item><description>MYBATIS_SQL: advanced SQL</description></item>
            /// <item><description>AVIATOR: Aviator expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL_SQL</para>
            /// </summary>
            [NameInMap("ScriptType")]
            [Validation(Required=false)]
            public string ScriptType { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select col1 from table1;</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The logical table name. This parameter has a value only for logical tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_logical_test1</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public string Timeout { get; set; }

            /// <summary>
            /// <para>The update frequency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: custom</description></item>
            /// <item><description>1: daily</description></item>
            /// <item><description>2: hourly</description></item>
            /// <item><description>3: every minute.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UpdateRate")]
            [Validation(Required=false)]
            public int? UpdateRate { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
