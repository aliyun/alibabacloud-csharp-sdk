// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class DestroyRoomRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public DestroyRoomRequestRequest Request { get; set; }
        public class DestroyRoomRequestRequest : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("openId")]
            [Validation(Required=false)]
            public string OpenId { get; set; }

            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
