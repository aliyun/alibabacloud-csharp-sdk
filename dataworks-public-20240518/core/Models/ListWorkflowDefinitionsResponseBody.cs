// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowDefinitionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListWorkflowDefinitionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListWorkflowDefinitionsResponseBodyPagingInfo : TeaModel {
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
            /// <para>227</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The workflows.</para>
            /// </summary>
            [NameInMap("WorkflowDefinitions")]
            [Validation(Required=false)]
            public List<ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitions> WorkflowDefinitions { get; set; }
            public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitions : TeaModel {
                /// <summary>
                /// <para>The time when the workflow was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698057323000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Workflow description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>463497880880954XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The times when the workflow was last modified. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698057323000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAPI test workflow Demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace to which the workflow belongs.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4710</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The script information.</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScript Script { get; set; }
                public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScript : TeaModel {
                    /// <summary>
                    /// <para>The script ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>698002781368644XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The script path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XX/OpenAPI_test/workflow_test/OpenAPI_test_workflow_Demo</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The runtime.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime Runtime { get; set; }
                    public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>The command.</para>
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
                /// <para>The type of the workflow.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CycleWorkflow</description></item>
                /// <item><description>ManualWorkflow</description></item>
                /// </list>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C3ED0C5-ABAB-55E1-854B-DAC02B11XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
