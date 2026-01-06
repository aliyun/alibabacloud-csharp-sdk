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
                /// <para>The timestamp when the workflow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698057323000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>Workflow description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The unique identifier of the workflow.</para>
                /// <remarks>
                /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>463497880880954XXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The timestamp when the workflow was last modified.</para>
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
                /// <para>Owner</para>
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
                    /// <para>The ID of the script.</para>
                    /// <remarks>
                    /// <para> This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures due to the type change may occur only when upgrading the SDK across version 8.0.0, in which case users need to manually correct the data type.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>698002781368644XXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

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
                    /// <para>Runtime</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime Runtime { get; set; }
                    public class ListWorkflowDefinitionsResponseBodyPagingInfoWorkflowDefinitionsScriptRuntime : TeaModel {
                        /// <summary>
                        /// <para>Command</para>
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
