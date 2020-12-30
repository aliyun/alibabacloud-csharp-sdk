// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetApprovalDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ApprovalDetail")]
        [Validation(Required=false)]
        public GetApprovalDetailResponseBodyApprovalDetail ApprovalDetail { get; set; }
        public class GetApprovalDetailResponseBodyApprovalDetail : TeaModel {
            [NameInMap("WorkflowNodes")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes WorkflowNodes { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes : TeaModel {
                [NameInMap("WorkflowNode")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode : TeaModel {
                    [NameInMap("OperateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    [NameInMap("OperatorId")]
                    [Validation(Required=false)]
                    public long? OperatorId { get; set; }

                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("AuditUserIdList")]
                    [Validation(Required=false)]
                    public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList AuditUserIdList { get; set; }
                    public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList : TeaModel {
                        [NameInMap("AuditUserIds")]
                        [Validation(Required=false)]
                        public List<string> AuditUserIds { get; set; }
                    };

                    [NameInMap("OperateComment")]
                    [Validation(Required=false)]
                    public string OperateComment { get; set; }

                    [NameInMap("WorkflowInsCode")]
                    [Validation(Required=false)]
                    public string WorkflowInsCode { get; set; }

                }

            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CurrentHandlers")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers CurrentHandlers { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers : TeaModel {
                [NameInMap("CurrentHandler")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler> CurrentHandler { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler : TeaModel {
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

            }
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("AuditId")]
            [Validation(Required=false)]
            public long? AuditId { get; set; }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
            [NameInMap("WorkflowInsCode")]
            [Validation(Required=false)]
            public string WorkflowInsCode { get; set; }
            [NameInMap("ReasonList")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailReasonList ReasonList { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailReasonList : TeaModel {
                [NameInMap("Reasons")]
                [Validation(Required=false)]
                public List<string> Reasons { get; set; }

            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
