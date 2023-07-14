// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateWebhookRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("HttpHeaders")]
        [Validation(Required=false)]
        public string HttpHeaders { get; set; }

        [NameInMap("HttpParams")]
        [Validation(Required=false)]
        public string HttpParams { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("RecoverBody")]
        [Validation(Required=false)]
        public string RecoverBody { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
