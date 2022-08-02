// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CreateGameRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("GameName")]
        [Validation(Required=false)]
        public string GameName { get; set; }

        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public long? PlatformType { get; set; }

    }

}
