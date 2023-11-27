// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetMediaUrlRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetMediaUrlRequestRequestParams RequestParams { get; set; }
        public class GetMediaUrlRequestRequestParams : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("UrlExpireTime")]
            [Validation(Required=false)]
            public long? UrlExpireTime { get; set; }

        }

    }

}
