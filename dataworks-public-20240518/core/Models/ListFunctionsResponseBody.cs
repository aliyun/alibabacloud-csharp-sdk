// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListFunctionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListFunctionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The function list.</para>
            /// </summary>
            [NameInMap("Functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyPagingInfoFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyPagingInfoFunctions : TeaModel {
                /// <summary>
                /// <para>The list of resource files for the ARM cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.jar,yyy.jar</para>
                /// </summary>
                [NameInMap("ArmResource")]
                [Validation(Required=false)]
                public string ArmResource { get; set; }

                /// <summary>
                /// <para>The fully qualified class name of the UDF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo.Main</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The command description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUdf(xx,yy)</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>The timestamp when the UDF was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Data source information of the UDF.</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsDataSource DataSource { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsDataSource : TeaModel {
                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The database name. This parameter is used only when the function type is EMR Function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>The general description of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Content of the nested function code</para>
                /// 
                /// <b>Example:</b>
                /// <para>print(\&quot;hello,world!\&quot;)</para>
                /// </summary>
                [NameInMap("EmbeddedCode")]
                [Validation(Required=false)]
                public string EmbeddedCode { get; set; }

                /// <summary>
                /// <para>The nested code type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Python2</description></item>
                /// <item><description>Python3</description></item>
                /// <item><description>Java8</description></item>
                /// <item><description>Java11</description></item>
                /// <item><description>Java17</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Python2</para>
                /// </summary>
                [NameInMap("EmbeddedCodeType")]
                [Validation(Required=false)]
                public string EmbeddedCodeType { get; set; }

                /// <summary>
                /// <para>The nested resource type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>File: General resource file.</description></item>
                /// <item><description>Embedded: Embedded resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>File</para>
                /// </summary>
                [NameInMap("EmbeddedResourceType")]
                [Validation(Required=false)]
                public string EmbeddedResourceType { get; set; }

                /// <summary>
                /// <para>The example description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example description &gt;&gt;&gt; select tsetUdf(xx,yy);
                /// abc</para>
                /// </summary>
                [NameInMap("ExampleDescription")]
                [Validation(Required=false)]
                public string ExampleDescription { get; set; }

                /// <summary>
                /// <para>The implementation code of the function and the list of resource files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.jar,yyy.jar</para>
                /// </summary>
                [NameInMap("FileResource")]
                [Validation(Required=false)]
                public string FileResource { get; set; }

                /// <summary>
                /// <para>The unique identifier of the UDF.</para>
                /// <remarks>
                /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>580667964888595XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The UDF name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Function name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the UDF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx: parameter information XXX
                /// yy: parameter information YYY</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The ID of the project to which the UDF belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307XXX</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The return value description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The return value is a string.</para>
                /// </summary>
                [NameInMap("ReturnValueDescription")]
                [Validation(Required=false)]
                public string ReturnValueDescription { get; set; }

                /// <summary>
                /// <para>The runtime resource group information.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource RuntimeResource { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The runtime resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_resgrop_xxx</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>Script information of the UDF.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsScript Script { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsScript : TeaModel {
                    /// <summary>
                    /// <para>The ID of the script.</para>
                    /// <remarks>
                    /// <para> This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. However, compilation failures may occur due to the type change only when upgrading the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>652567824470354XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The script path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XXX/OpenAPI/function/function_name</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>Runtime</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime Runtime { get; set; }
                    public class ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>Command</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ODPS_FUNCTION</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

                /// <summary>
                /// <para>The UDF type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Math: Mathematical operation functions</description></item>
                /// <item><description>Aggregate: Aggregation functions</description></item>
                /// <item><description>String: String processing functions</description></item>
                /// <item><description>Date: Date functions</description></item>
                /// <item><description>Analytic: Window functions</description></item>
                /// <item><description>Other: Other functions</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MATH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89FB2BF0-EB00-5D03-9C34-05931001XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
