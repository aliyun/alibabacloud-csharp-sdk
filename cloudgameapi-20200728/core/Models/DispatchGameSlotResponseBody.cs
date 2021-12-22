// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class DispatchGameSlotResponseBody : TeaModel {
        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("GameSession")]
        [Validation(Required=false)]
        public string GameSession { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("QueueCode")]
        [Validation(Required=false)]
        public int? QueueCode { get; set; }

        [NameInMap("QueueState")]
        [Validation(Required=false)]
        public int? QueueState { get; set; }

        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
