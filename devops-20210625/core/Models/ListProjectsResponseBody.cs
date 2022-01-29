// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectsResponseBody : TeaModel {
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
        /// 项目信息
        /// </summary>
        [NameInMap("projects")]
        [Validation(Required=false)]
        public List<ListProjectsResponseBodyProjects> Projects { get; set; }
        public class ListProjectsResponseBodyProjects : TeaModel {
            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 自定义编号
            /// </summary>
            [NameInMap("customCode")]
            [Validation(Required=false)]
            public string CustomCode { get; set; }

            /// <summary>
            /// 删除时间
            /// </summary>
            [NameInMap("deleteTime")]
            [Validation(Required=false)]
            public long? DeleteTime { get; set; }

            /// <summary>
            /// 描述信息
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
            /// 项目封面
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 项目唯一标识符
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
            /// 项目名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 公开还是私有
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// 状态阶段
            /// </summary>
            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            /// <summary>
            /// 类型id
            /// </summary>
            [NameInMap("typeIdentifier")]
            [Validation(Required=false)]
            public string TypeIdentifier { get; set; }

        }

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

    }

}
