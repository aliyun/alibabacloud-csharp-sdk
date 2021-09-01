// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetLoginPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UrlData")]
        [Validation(Required=false)]
        public GetLoginPageResponseBodyUrlData UrlData { get; set; }
        public class GetLoginPageResponseBodyUrlData : TeaModel {
            [NameInMap("ReturnUrl")]
            [Validation(Required=false)]
            public string ReturnUrl { get; set; }
        };

    }

}
