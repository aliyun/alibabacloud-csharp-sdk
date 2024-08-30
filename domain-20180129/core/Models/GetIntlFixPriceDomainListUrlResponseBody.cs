// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class GetIntlFixPriceDomainListUrlResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetIntlFixPriceDomainListUrlResponseBodyModule Module { get; set; }
        public class GetIntlFixPriceDomainListUrlResponseBodyModule : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
