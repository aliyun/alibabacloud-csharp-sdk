// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemTimeLinesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProblemTimeLinesResponseBodyData> Data { get; set; }
        public class ListProblemTimeLinesResponseBodyData : TeaModel {
            /// <summary>
            /// 内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 是否是关键字 true是 false不是 默认 false
            /// </summary>
            [NameInMap("isKey")]
            [Validation(Required=false)]
            public bool? IsKey { get; set; }

            /// <summary>
            /// 关键节点 码表:PROBLEM_KEY_NODE (逗号分隔)
            /// </summary>
            [NameInMap("keyNode")]
            [Validation(Required=false)]
            public string KeyNode { get; set; }

            /// <summary>
            /// 时间线id
            /// </summary>
            [NameInMap("problemTimelineId")]
            [Validation(Required=false)]
            public long? ProblemTimelineId { get; set; }

            /// <summary>
            /// 展示时间
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// 内容中的用户信息
            /// </summary>
            [NameInMap("usersInContent")]
            [Validation(Required=false)]
            public List<ListProblemTimeLinesResponseBodyDataUsersInContent> UsersInContent { get; set; }
            public class ListProblemTimeLinesResponseBodyDataUsersInContent : TeaModel {
                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// 用户名
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
