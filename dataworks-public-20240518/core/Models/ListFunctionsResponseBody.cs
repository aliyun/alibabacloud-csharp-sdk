// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListFunctionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListFunctionsResponseBodyPagingInfo : TeaModel {
            [NameInMap("Functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyPagingInfoFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyPagingInfoFunctions : TeaModel {
                /// <summary>
                /// <para>ARM集群资源文件列表</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.jar,yyy.jar</para>
                /// </summary>
                [NameInMap("ArmResource")]
                [Validation(Required=false)]
                public string ArmResource { get; set; }

                /// <summary>
                /// <para>函数实现类名</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo.Main</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>命令描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUdf(xx,yy)</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>代表创建时间的资源属性字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>函数注册到的数据源信息</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsDataSource DataSource { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsDataSource : TeaModel {
                    /// <summary>
                    /// <para>数据源名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>数据源类型</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>数据库名，可选</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>对funciotn的描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>嵌套函数代码内容</para>
                /// 
                /// <b>Example:</b>
                /// <para>print(\&quot;hello,world!\&quot;)</para>
                /// </summary>
                [NameInMap("EmbeddedCode")]
                [Validation(Required=false)]
                public string EmbeddedCode { get; set; }

                /// <summary>
                /// <para>嵌套代码类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>Python2</para>
                /// </summary>
                [NameInMap("EmbeddedCodeType")]
                [Validation(Required=false)]
                public string EmbeddedCodeType { get; set; }

                /// <summary>
                /// <para>嵌套资源类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>File</para>
                /// </summary>
                [NameInMap("EmbeddedResourceType")]
                [Validation(Required=false)]
                public string EmbeddedResourceType { get; set; }

                /// <summary>
                /// <para>示例说明</para>
                /// </summary>
                [NameInMap("ExampleDescription")]
                [Validation(Required=false)]
                public string ExampleDescription { get; set; }

                /// <summary>
                /// <para>函数的实现代码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.jar,yyy.jar</para>
                /// </summary>
                [NameInMap("FileResource")]
                [Validation(Required=false)]
                public string FileResource { get; set; }

                /// <summary>
                /// <para>代表资源一级ID的资源属性字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>580667964888595XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>修改时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1655953028000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>代表资源名称的资源属性字段</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>函数责任人</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>命令描述</para>
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// <para>项目Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>307XXX</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>返回值说明</para>
                /// </summary>
                [NameInMap("ReturnValueDescription")]
                [Validation(Required=false)]
                public string ReturnValueDescription { get; set; }

                /// <summary>
                /// <para>运行时资源组信息</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource RuntimeResource { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>运行时资源组Id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_resgrop_xxx</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

                /// <summary>
                /// <para>工作流的脚本信息</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListFunctionsResponseBodyPagingInfoFunctionsScript Script { get; set; }
                public class ListFunctionsResponseBodyPagingInfoFunctionsScript : TeaModel {
                    /// <summary>
                    /// <para>脚本的id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>652567824470354XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>脚本路径</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>脚本的运行时信息</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime Runtime { get; set; }
                    public class ListFunctionsResponseBodyPagingInfoFunctionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>脚本所属类型</para>
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
                /// <para>函数类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>MATH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89FB2BF0-EB00-5D03-9C34-05931001XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
