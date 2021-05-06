// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListGroupAllMembersResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 拉取群成员列表的结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListGroupAllMembersResponseBodyResult Result { get; set; }
        public class ListGroupAllMembersResponseBodyResult : TeaModel {
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<ListGroupAllMembersResponseBodyResultMembers> Members { get; set; }
            public class ListGroupAllMembersResponseBodyResultMembers : TeaModel {
                public string AppUid { get; set; }
                public int? Role { get; set; }
                public string Nick { get; set; }
                public long? JoinTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
