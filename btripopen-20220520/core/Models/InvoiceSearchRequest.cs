// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceSearchRequest : TeaModel {
        [NameInMap("authority")]
        [Validation(Required=false)]
        public bool? Authority { get; set; }

        [NameInMap("corp_id")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
