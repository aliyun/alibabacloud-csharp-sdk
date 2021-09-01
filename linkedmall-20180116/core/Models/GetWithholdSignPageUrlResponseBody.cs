// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetWithholdSignPageUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WithholdSignResponse")]
        [Validation(Required=false)]
        public GetWithholdSignPageUrlResponseBodyWithholdSignResponse WithholdSignResponse { get; set; }
        public class GetWithholdSignPageUrlResponseBodyWithholdSignResponse : TeaModel {
            [NameInMap("PageUrl")]
            [Validation(Required=false)]
            public string PageUrl { get; set; }
            [NameInMap("OutRequestNo")]
            [Validation(Required=false)]
            public string OutRequestNo { get; set; }
        };

    }

}
