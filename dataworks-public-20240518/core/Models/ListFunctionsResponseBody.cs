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
            /// <para>The UDFs.</para>
            /// </summary>
            [NameInMap("Functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyPagingInfoFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyPagingInfoFunctions : TeaModel {
                /// <summary>
                /// <para>The file resources in an Advanced RISC Machines (ARM) cluster.</para>
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
                /// <para>The description of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUdf(xx,yy)</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>The time when the UDF was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data source information about the UDF.</para>
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
                /// <para>The name of the database. This parameter is returned for E-MapReduce (EMR) functions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>The overall description of the UDF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The code of the embedded UDF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>print(\&quot;hello,world!\&quot;)</para>
                /// </summary>
                [NameInMap("EmbeddedCode")]
                [Validation(Required=false)]
                public string EmbeddedCode { get; set; }

                /// <summary>
                /// <para>The type of the nested code.</para>
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
                /// <para>The type of the nested resource.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>File: general resources</description></item>
                /// <item><description>Embedded: embedded resources</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>File</para>
                /// </summary>
                [NameInMap("EmbeddedResourceType")]
                [Validation(Required=false)]
                public string EmbeddedResourceType { get; set; }

                /// <summary>
                /// <para>The description of the example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example description &gt;&gt;&gt; select tsetUdf(xx,yy);
                /// abc</para>
                /// </summary>
                [NameInMap("ExampleDescription")]
                [Validation(Required=false)]
                public string ExampleDescription { get; set; }

                /// <summary>
                /// <para>The files resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.jar,yyy.jar</para>
                /// </summary>
                [NameInMap("FileResource")]
                [Validation(Required=false)]
                public string FileResource { get; set; }

                /// <summary>
                /// <para>The ID of the UDF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>580667964888595XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The time when the UDF was last modified. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the UDF.</para>
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
                /// <para>The description of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx: parameter information XXX
                /// yy: parameter information YYY</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the UDF belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307XXX</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The description of the return value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The return value is a string.</para>
                /// </summary>
                [NameInMap("ReturnValueDescription")]
                [Validation(Required=false)]
                public string ReturnValueDescription { get; set; }

                /// <summary>
                /// <para>The information about the resource group used when you run the UDF.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource RuntimeResource { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The ID of the resource group used when you run the UDF.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_resgrop_xxx</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>The script information about the UDF.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsScript Script { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsScript : TeaModel {
                    /// <summary>
                    /// <para>The script ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>652567824470354XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

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
                    /// <para>The runtime.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime Runtime { get; set; }
                    public class ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command.</para>
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
                /// <item><description>Math: mathematical operation function</description></item>
                /// <item><description>Aggregate: aggregate function</description></item>
                /// <item><description>String: string processing function</description></item>
                /// <item><description>Date: date function</description></item>
                /// <item><description>Analytic: window function</description></item>
                /// <item><description>Other: other functions</description></item>
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
