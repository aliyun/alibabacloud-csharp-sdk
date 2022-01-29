// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemWorkFlowStatusResponseBody : TeaModel {
        /// <summary>
        /// 错误返回码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误返回信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// openapi平台的request id
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 工作流状态
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public List<ListWorkItemWorkFlowStatusResponseBodyStatuses> Statuses { get; set; }
        public class ListWorkItemWorkFlowStatusResponseBodyStatuses : TeaModel {
            /// <summary>
            /// 状态的创建人
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 工作流状态id
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 修改人
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 工作流状态名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 状态作用的资源类型
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// 状态来源
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 阶段信息-阶段的唯一标识
            /// </summary>
            [NameInMap("workflowStageIdentifier")]
            [Validation(Required=false)]
            public string WorkflowStageIdentifier { get; set; }

            /// <summary>
            /// 阶段信息-名称
            /// </summary>
            [NameInMap("workflowStageName")]
            [Validation(Required=false)]
            public string WorkflowStageName { get; set; }

        }

        /// <summary>
        /// 接口是否正常返回
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
