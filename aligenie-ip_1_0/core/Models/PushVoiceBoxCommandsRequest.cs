// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushVoiceBoxCommandsRequest : TeaModel {
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<PushVoiceBoxCommandsRequestCommands> Commands { get; set; }
        public class PushVoiceBoxCommandsRequestCommands : TeaModel {
            [NameInMap("CommandDomain")]
            [Validation(Required=false)]
            public string CommandDomain { get; set; }

            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

        }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}
