// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class DispatchGameSlotRequest : TeaModel {
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("BizParam")]
        [Validation(Required=false)]
        public string BizParam { get; set; }

        [NameInMap("Cancel")]
        [Validation(Required=false)]
        public bool? Cancel { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("GameCommand")]
        [Validation(Required=false)]
        public string GameCommand { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("GameSession")]
        [Validation(Required=false)]
        public string GameSession { get; set; }

        [NameInMap("GameStartParam")]
        [Validation(Required=false)]
        public string GameStartParam { get; set; }

        [NameInMap("Reconnect")]
        [Validation(Required=false)]
        public bool? Reconnect { get; set; }

        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public string SystemInfo { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserLevel")]
        [Validation(Required=false)]
        public int? UserLevel { get; set; }

    }

}
