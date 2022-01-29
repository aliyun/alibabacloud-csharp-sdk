// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSprintsResponseBody : TeaModel {
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
        /// 迭代信息
        /// </summary>
        [NameInMap("sprints")]
        [Validation(Required=false)]
        public List<ListSprintsResponseBodySprints> Sprints { get; set; }
        public class ListSprintsResponseBodySprints : TeaModel {
            /// <summary>
            /// 创建人id
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 描述信息
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

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
            /// 迭代唯一标识符
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
            /// 迭代名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 可见范围
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// 项目id
            /// </summary>
            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public long? StartDate { get; set; }

            /// <summary>
            /// 状态，未开始:Todo, 进行中:Doing, 已完成:Done
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
