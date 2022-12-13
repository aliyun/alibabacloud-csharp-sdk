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
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("isKey")]
            [Validation(Required=false)]
            public bool? IsKey { get; set; }

            [NameInMap("keyNode")]
            [Validation(Required=false)]
            public string KeyNode { get; set; }

            [NameInMap("problemTimelineId")]
            [Validation(Required=false)]
            public long? ProblemTimelineId { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("usersInContent")]
            [Validation(Required=false)]
            public List<ListProblemTimeLinesResponseBodyDataUsersInContent> UsersInContent { get; set; }
            public class ListProblemTimeLinesResponseBodyDataUsersInContent : TeaModel {
                [NameInMap("isValid")]
                [Validation(Required=false)]
                public long? IsValid { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

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
