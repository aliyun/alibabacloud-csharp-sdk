// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class SendCustomMessageToUsersRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("ReceiverList")]
        [Validation(Required=false)]
        public List<string> ReceiverList { get; set; }

        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

    }

}
