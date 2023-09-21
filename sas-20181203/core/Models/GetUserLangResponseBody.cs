// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetUserLangResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasUserLang")]
        [Validation(Required=false)]
        public GetUserLangResponseBodySasUserLang SasUserLang { get; set; }
        public class GetUserLangResponseBodySasUserLang : TeaModel {
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

        }

    }

}
