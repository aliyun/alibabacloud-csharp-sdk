// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class GenerateWuyingServerSceneUrlResponseBody : TeaModel {
        [NameInMap("ExpireDurationHours")]
        [Validation(Required=false)]
        public int? ExpireDurationHours { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
