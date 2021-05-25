// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class DestroyRoomRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public DestroyRoomRequestRequest Request { get; set; }
        public class DestroyRoomRequestRequest : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
        };

    }

}
