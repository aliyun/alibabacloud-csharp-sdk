// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListRoomUsersResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求是否成功。
        /// </summary>
        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        /// <summary>
        /// 错误码，请求异常时返回。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息，请求异常时返回。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求的返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomUsersResponseBodyResult Result { get; set; }
        public class ListRoomUsersResponseBodyResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("RoomUserVOList")]
            [Validation(Required=false)]
            public List<ListRoomUsersResponseBodyResultRoomUserVOList> RoomUserVOList { get; set; }
            public class ListRoomUsersResponseBodyResultRoomUserVOList : TeaModel {
                public string RoomId { get; set; }
                public string UserId { get; set; }
                public string Nick { get; set; }
            }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
        };

    }

}
