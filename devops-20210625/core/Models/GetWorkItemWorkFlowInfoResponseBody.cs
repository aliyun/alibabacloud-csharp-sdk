// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemWorkFlowInfoResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 工作项信息
        /// </summary>
        [NameInMap("workflow")]
        [Validation(Required=false)]
        public GetWorkItemWorkFlowInfoResponseBodyWorkflow Workflow { get; set; }
        public class GetWorkItemWorkFlowInfoResponseBodyWorkflow : TeaModel {
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("defaultStatusIdentifier")]
            [Validation(Required=false)]
            public string DefaultStatusIdentifier { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ownerSpaceIdentifier")]
            [Validation(Required=false)]
            public string OwnerSpaceIdentifier { get; set; }
            [NameInMap("ownerSpaceType")]
            [Validation(Required=false)]
            public string OwnerSpaceType { get; set; }
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("statusOrder")]
            [Validation(Required=false)]
            public string StatusOrder { get; set; }
            [NameInMap("statuses")]
            [Validation(Required=false)]
            public List<GetWorkItemWorkFlowInfoResponseBodyWorkflowStatuses> Statuses { get; set; }
            public class GetWorkItemWorkFlowInfoResponseBodyWorkflowStatuses : TeaModel {
                public string Creator { get; set; }
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Identifier { get; set; }
                public string Modifier { get; set; }
                public string Name { get; set; }
                public string ResourceType { get; set; }
                public string Source { get; set; }
                public string WorkflowStageIdentifier { get; set; }
                public string WorkflowStageName { get; set; }
            }
            [NameInMap("workflowActions")]
            [Validation(Required=false)]
            public List<GetWorkItemWorkFlowInfoResponseBodyWorkflowWorkflowActions> WorkflowActions { get; set; }
            public class GetWorkItemWorkFlowInfoResponseBodyWorkflowWorkflowActions : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public string NextWorkflowStatusIdentifier { get; set; }
                public string WorkflowIdentifier { get; set; }
                public string WorkflowStatusIdentifier { get; set; }
            }
        };

    }

}
