// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupUserByIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageGroupUserByIdResponseBodyResult Result { get; set; }
        public class ListMessageGroupUserByIdResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListMessageGroupUserByIdResponseBodyResultUserList> UserList { get; set; }
            public class ListMessageGroupUserByIdResponseBodyResultUserList : TeaModel {
                [NameInMap("IsMute")]
                [Validation(Required=false)]
                public bool? IsMute { get; set; }

                [NameInMap("MuteBy")]
                [Validation(Required=false)]
                public List<string> MuteBy { get; set; }

                [NameInMap("UserAvatar")]
                [Validation(Required=false)]
                public string UserAvatar { get; set; }

                [NameInMap("UserExtension")]
                [Validation(Required=false)]
                public string UserExtension { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

        }

    }

}
