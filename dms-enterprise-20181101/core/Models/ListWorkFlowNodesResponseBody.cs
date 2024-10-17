// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFD8FE00-36D9-4C1B-940D-65A7B73D9066</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of approval nodes.</para>
        /// </summary>
        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public ListWorkFlowNodesResponseBodyWorkflowNodes WorkflowNodes { get; set; }
        public class ListWorkFlowNodesResponseBodyWorkflowNodes : TeaModel {
            [NameInMap("WorkflowNode")]
            [Validation(Required=false)]
            public List<ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
            public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNode : TeaModel {
                /// <summary>
                /// <para>The details about approvers.</para>
                /// </summary>
                [NameInMap("AuditUsers")]
                [Validation(Required=false)]
                public ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsers AuditUsers { get; set; }
                public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsers : TeaModel {
                    [NameInMap("AuditUser")]
                    [Validation(Required=false)]
                    public List<ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsersAuditUser> AuditUser { get; set; }
                    public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsersAuditUser : TeaModel {
                        /// <summary>
                        /// <para>The nickname of the approver.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("NickName")]
                        [Validation(Required=false)]
                        public string NickName { get; set; }

                        /// <summary>
                        /// <para>The real name of the approver.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("RealName")]
                        [Validation(Required=false)]
                        public string RealName { get; set; }

                        /// <summary>
                        /// <para>The ID of the approver. The ID is different from the ID of the Alibaba Cloud account of the approver.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public long? UserId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The ID of the creator. This ID is different from the ID of the Alibaba Cloud account of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                /// <summary>
                /// <para>The name of the user who creates the approval node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CreateUserNickName")]
                [Validation(Required=false)]
                public string CreateUserNickName { get; set; }

                /// <summary>
                /// <para>The ID of the approval node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the approval node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The type of the approval node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYS: The approval node is predefined by the system.</description></item>
                /// <item><description>USER_LIST: The approval node is created by a user.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYS</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

    }

}
