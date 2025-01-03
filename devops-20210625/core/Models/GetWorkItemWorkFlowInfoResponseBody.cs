// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemWorkFlowInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workflow")]
        [Validation(Required=false)]
        public GetWorkItemWorkFlowInfoResponseBodyWorkflow Workflow { get; set; }
        public class GetWorkItemWorkFlowInfoResponseBodyWorkflow : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100005</para>
            /// </summary>
            [NameInMap("defaultStatusIdentifier")]
            [Validation(Required=false)]
            public string DefaultStatusIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>工作流的描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640850318000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640850318000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8bxxxxxxxxxxxxxxxx23</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8b26xxxxx6e76aa20xxxxx23</para>
            /// </summary>
            [NameInMap("ownerSpaceIdentifier")]
            [Validation(Required=false)]
            public string OwnerSpaceIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ownerSpaceType")]
            [Validation(Required=false)]
            public string OwnerSpaceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("statusOrder")]
            [Validation(Required=false)]
            public string StatusOrder { get; set; }

            [NameInMap("statuses")]
            [Validation(Required=false)]
            public List<GetWorkItemWorkFlowInfoResponseBodyWorkflowStatuses> Statuses { get; set; }
            public class GetWorkItemWorkFlowInfoResponseBodyWorkflowStatuses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>19xx7043xxxxxxx914</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1613805843000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1613805843000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>156603</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19xx7043xxxxxxx914</para>
                /// </summary>
                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>待处理</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Workitem</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("workflowStageIdentifier")]
                [Validation(Required=false)]
                public string WorkflowStageIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>确认阶段</para>
                /// </summary>
                [NameInMap("workflowStageName")]
                [Validation(Required=false)]
                public string WorkflowStageName { get; set; }

            }

            [NameInMap("workflowActions")]
            [Validation(Required=false)]
            public List<GetWorkItemWorkFlowInfoResponseBodyWorkflowWorkflowActions> WorkflowActions { get; set; }
            public class GetWorkItemWorkFlowInfoResponseBodyWorkflowWorkflowActions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16274887</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100011</para>
                /// </summary>
                [NameInMap("nextWorkflowStatusIdentifier")]
                [Validation(Required=false)]
                public string NextWorkflowStatusIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fd0xxxxxd00d355b05dxxxx26</para>
                /// </summary>
                [NameInMap("workflowIdentifier")]
                [Validation(Required=false)]
                public string WorkflowIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100005</para>
                /// </summary>
                [NameInMap("workflowStatusIdentifier")]
                [Validation(Required=false)]
                public string WorkflowStatusIdentifier { get; set; }

            }

        }

    }

}
