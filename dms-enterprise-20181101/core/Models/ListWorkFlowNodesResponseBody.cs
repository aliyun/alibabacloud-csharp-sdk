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

        [NameInMap("WorkflowNodes")]
        [Validation(Required=false)]
        public ListWorkFlowNodesResponseBodyWorkflowNodes WorkflowNodes { get; set; }
        public class ListWorkFlowNodesResponseBodyWorkflowNodes : TeaModel {
            [NameInMap("WorkflowNode")]
            [Validation(Required=false)]
            public List<ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
            public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNode : TeaModel {
                [NameInMap("AuditUsers")]
                [Validation(Required=false)]
                public ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsers AuditUsers { get; set; }
                public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsers : TeaModel {
                    [NameInMap("AuditUser")]
                    [Validation(Required=false)]
                    public List<ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsersAuditUser> AuditUser { get; set; }
                    public class ListWorkFlowNodesResponseBodyWorkflowNodesWorkflowNodeAuditUsersAuditUser : TeaModel {
                        [NameInMap("NickName")]
                        [Validation(Required=false)]
                        public string NickName { get; set; }

                        [NameInMap("RealName")]
                        [Validation(Required=false)]
                        public string RealName { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public long? UserId { get; set; }

                    }

                }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                [NameInMap("CreateUserNickName")]
                [Validation(Required=false)]
                public string CreateUserNickName { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

        }

    }

}
