// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGameStatusResponseBodyData Data { get; set; }
        public class GetGameStatusResponseBodyData : TeaModel {
            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }
            [NameInMap("GameSession")]
            [Validation(Required=false)]
            public string GameSession { get; set; }
            [NameInMap("GameStartAt")]
            [Validation(Required=false)]
            public long? GameStartAt { get; set; }
            [NameInMap("PlayingCount")]
            [Validation(Required=false)]
            public int? PlayingCount { get; set; }
            [NameInMap("PlayingUsers")]
            [Validation(Required=false)]
            public List<GetGameStatusResponseBodyDataPlayingUsers> PlayingUsers { get; set; }
            public class GetGameStatusResponseBodyDataPlayingUsers : TeaModel {
                public string AccountId { get; set; }
                public long? StartPlayTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
