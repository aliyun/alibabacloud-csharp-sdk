// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListRoomMessagesRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public ListRoomMessagesRequestRequest Request { get; set; }
        public class ListRoomMessagesRequestRequest : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public int? SubType { get; set; }

        }

    }

}
