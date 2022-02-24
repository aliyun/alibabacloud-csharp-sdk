// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemsResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 分页Token，没有下一页则为空
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 工作项信息
        /// </summary>
        [NameInMap("workitems")]
        [Validation(Required=false)]
        public List<ListWorkitemsResponseBodyWorkitems> Workitems { get; set; }
        public class ListWorkitemsResponseBodyWorkitems : TeaModel {
            /// <summary>
            /// 负责人aliyunPk
            /// </summary>
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            /// <summary>
            /// 工作项的类型id
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// 创建人aliyunPK
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 工作项内容
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 工作项唯一标识
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 逻辑状态
            /// </summary>
            [NameInMap("logicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            /// <summary>
            /// 修改人aliyunPK
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 父工作项id
            /// </summary>
            [NameInMap("parentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// 编号
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// 所属项目id
            /// </summary>
            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            /// <summary>
            /// 所属项目名称
            /// </summary>
            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// 项目类型
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            /// <summary>
            /// 状态名称
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 状态唯一标识
            /// </summary>
            [NameInMap("statusIdentifier")]
            [Validation(Required=false)]
            public string StatusIdentifier { get; set; }

            /// <summary>
            /// 状态阶段id
            /// </summary>
            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            /// <summary>
            /// 工作项标题
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// 状态更新时间
            /// </summary>
            [NameInMap("updateStatusAt")]
            [Validation(Required=false)]
            public long? UpdateStatusAt { get; set; }

            /// <summary>
            /// 工作项类型id
            /// </summary>
            [NameInMap("workitemTypeIdentifier")]
            [Validation(Required=false)]
            public string WorkitemTypeIdentifier { get; set; }

        }

    }

}
