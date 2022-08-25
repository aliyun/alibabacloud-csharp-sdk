// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsResponseBody : TeaModel {
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public string ForbiddenMediaIds { get; set; }

        [NameInMap("MediaRefreshJobId")]
        [Validation(Required=false)]
        public string MediaRefreshJobId { get; set; }

        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public string NonExistMediaIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
