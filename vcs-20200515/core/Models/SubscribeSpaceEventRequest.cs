// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SubscribeSpaceEventRequest : TeaModel {
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("PushConfig")]
        [Validation(Required=false)]
        public string PushConfig { get; set; }

    }

}
