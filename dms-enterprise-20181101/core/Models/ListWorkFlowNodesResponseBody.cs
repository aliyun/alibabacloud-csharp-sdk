// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowNodesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                public string Comment { get; set; }
                public long? CreateUserId { get; set; }
                public string CreateUserNickName { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string NodeType { get; set; }
            }
        };

    }

}
