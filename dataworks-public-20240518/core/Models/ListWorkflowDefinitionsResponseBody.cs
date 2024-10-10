// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowDefinitionsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListWorkflowDefinitionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListWorkflowDefinitionsResponseBodyPagingInfo : TeaModel {
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
            /// <para>227</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("WorkflowDefinitions")]
            [Validation(Required=false)]
            public List<ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitions> WorkflowDefinitions { get; set; }
            public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitions : TeaModel {
                /// <summary>
                /// <para>工作流的创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698057323000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>工作流的描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>工作流定义的唯一ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>463497880880954XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>工作流的最近修改时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698057323000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>工作流的名称</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>工作流的责任人</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>工作流定义的所属项目空间</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4710</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>工作流的脚本信息</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScript Script { get; set; }
                public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScript : TeaModel {
                    /// <summary>
                    /// <para>工作流脚本的id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>698002781368644XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>工作流的脚本路径</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>脚本的运行时信息</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime Runtime { get; set; }
                    public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>脚本所属类型</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>WORKFLOW</para>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                    }

                }

                /// <summary>
                /// <para>工作流类型，可选值：CycleWorkflow、ManualWorkflow，分别表示周期工作流和手动工作流</para>
                /// 
                /// <b>Example:</b>
                /// <para>CycleWorkflow</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8C3ED0C5-ABAB-55E1-854B-DAC02B11XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
