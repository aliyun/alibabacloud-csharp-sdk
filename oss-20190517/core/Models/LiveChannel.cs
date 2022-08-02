// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannel : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PlayUrls")]
        [Validation(Required=false)]
        public LiveChannelPlayUrls PlayUrls { get; set; }

        [NameInMap("PublishUrls")]
        [Validation(Required=false)]
        public LiveChannelPublishUrls PublishUrls { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
