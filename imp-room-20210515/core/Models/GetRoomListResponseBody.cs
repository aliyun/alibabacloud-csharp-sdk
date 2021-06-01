// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class GetRoomListResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRoomListResponseBodyResult Result { get; set; }
        public class GetRoomListResponseBodyResult : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("RoomInfoList")]
            [Validation(Required=false)]
            public List<GetRoomListResponseBodyResultRoomInfoList> RoomInfoList { get; set; }
            public class GetRoomListResponseBodyResultRoomInfoList : TeaModel {
                public string RoomId { get; set; }
                public string Title { get; set; }
                public string OwnerId { get; set; }
                public string BizType { get; set; }
                public string Domain { get; set; }
            }
        };

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

    }

}
