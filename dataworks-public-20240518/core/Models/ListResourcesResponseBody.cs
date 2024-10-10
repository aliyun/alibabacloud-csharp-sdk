// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourcesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListResourcesResponseBodyPagingInfo : TeaModel {
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

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyPagingInfoResources> Resources { get; set; }
            public class ListResourcesResponseBodyPagingInfoResources : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>函数注册到的数据源信息</para>
                /// </summary>
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public ListResourcesResponseBodyPagingInfoResourcesDataSource DataSource { get; set; }
                public class ListResourcesResponseBodyPagingInfoResourcesDataSource : TeaModel {
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
                /// <para>代表资源组的资源属性字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>631478864897630XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>资源文件的最近修改时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724505917000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>代表资源名称的资源属性字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>math.py</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>资源文件的责任人</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>资源文件的项目id</para>
                /// 
                /// <b>Example:</b>
                /// <para>344247</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>工作流的脚本信息</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListResourcesResponseBodyPagingInfoResourcesScript Script { get; set; }
                public class ListResourcesResponseBodyPagingInfoResourcesScript : TeaModel {
                    /// <summary>
                    /// <para>工作流脚本的id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123348864897630XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>工作流的脚本路径</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root/demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>脚本的运行时信息</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListResourcesResponseBodyPagingInfoResourcesScriptRuntime Runtime { get; set; }
                    public class ListResourcesResponseBodyPagingInfoResourcesScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>脚本所属类型</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ODPS_PYTHON</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

                /// <summary>
                /// <para>文件目标存储路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX/unknown/ide/1/XXX/20240820200851_963a9da676de44ef8d06a6576a8c4d6a.py</para>
                /// </summary>
                [NameInMap("SourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>文件资源来源存储类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>文件来源路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX/unknown/ide/1/XXX/20240820200851_963a9da676de44ef8d06a6576a8c4d6a.py</para>
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// <para>文件目标存储类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>资源类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>jar</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99EBE7CF-69C0-5089-BE3E-79563C31XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
