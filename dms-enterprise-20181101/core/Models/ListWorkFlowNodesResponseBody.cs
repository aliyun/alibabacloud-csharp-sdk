// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowNodesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of approval nodes.
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
                /// The details about approvers.
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
                        /// The nickname of the approver.
                        /// </summary>
                        [NameInMap("NickName")]
                        [Validation(Required=false)]
                        public string NickName { get; set; }

                        /// <summary>
                        /// The real name of the approver.
                        /// </summary>
                        [NameInMap("RealName")]
                        [Validation(Required=false)]
                        public string RealName { get; set; }

                        /// <summary>
                        /// The ID of the approver. The ID is different from the ID of the Alibaba Cloud account of the approver.
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public long? UserId { get; set; }

                    }

                }

                /// <summary>
                /// The description of the approval template.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The ID of the creator. This ID is different from the ID of the Alibaba Cloud account of the creator.
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                /// <summary>
                /// The name of the user who creates the approval node.
                /// </summary>
                [NameInMap("CreateUserNickName")]
                [Validation(Required=false)]
                public string CreateUserNickName { get; set; }

                /// <summary>
                /// The ID of the approval node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the approval node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The type of the approval node. Valid values:
                /// 
                /// *   SYS: The approval node is predefined by the system.
                /// *   USER_LIST: The approval node is created by a user.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

    }

}
