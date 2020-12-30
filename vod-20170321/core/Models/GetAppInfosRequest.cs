// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        [NameInMap("ResourceRealOwnerId")]
        [Validation(Required=false)]
        public long? ResourceRealOwnerId { get; set; }

        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

    }

}
