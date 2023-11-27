// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetLoginTokenRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetLoginTokenRequestRequestParams RequestParams { get; set; }
        public class GetLoginTokenRequestRequestParams : TeaModel {
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

        }

    }

}
