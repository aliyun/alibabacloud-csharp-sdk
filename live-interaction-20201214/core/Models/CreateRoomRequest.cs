// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class CreateRoomRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public CreateRoomRequestRequest Request { get; set; }
        public class CreateRoomRequestRequest : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("ownerNick")]
            [Validation(Required=false)]
            public string OwnerNick { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
