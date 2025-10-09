// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListComponentsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListComponentsResponseBodyPagingInfo : TeaModel {
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyPagingInfoComponents> Components { get; set; }
            public class ListComponentsResponseBodyPagingInfoComponents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12312313123</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-13 16:35:59</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>对组件的描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc peering management_staging</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>组件的输入参数列表</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<ListComponentsResponseBodyPagingInfoComponentsInputs> Inputs { get; set; }
                public class ListComponentsResponseBodyPagingInfoComponentsInputs : TeaModel {
                    /// <summary>
                    /// <para>输入参数的默认值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mdb.shard.2x.2xlarge.d</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>输入参数的描述信息</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>输入参数的名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>auto_updateAlertRule_test_bULIRo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>输入参数的数据类型</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-11-30T13:30:58Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>代表资源名称的资源属性字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto_updateAlertRule_test_lJd81f</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>组件的输出参数列表</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public List<ListComponentsResponseBodyPagingInfoComponentsOutputs> Outputs { get; set; }
                public class ListComponentsResponseBodyPagingInfoComponentsOutputs : TeaModel {
                    /// <summary>
                    /// <para>输出参数的默认值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32000</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>输出参数的描述信息</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zdy</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>输出参数的名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>auto_updateAlertRule_test_bULIRo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>输出参数的数据类型</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>组件责任人</para>
                /// 
                /// <b>Example:</b>
                /// <para>252675537980665607</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>199925</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>工作流的脚本信息</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListComponentsResponseBodyPagingInfoComponentsScript Script { get; set; }
                public class ListComponentsResponseBodyPagingInfoComponentsScript : TeaModel {
                    /// <summary>
                    /// <para>ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>348100</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>脚本路径</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>脚本的运行时信息</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListComponentsResponseBodyPagingInfoComponentsScriptRuntime Runtime { get; set; }
                    public class ListComponentsResponseBodyPagingInfoComponentsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>脚本所属类型</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SQL_COMPONENT</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

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
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>952795279527ab****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
