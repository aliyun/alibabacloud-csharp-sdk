// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class CreateAuditCallbackRequest : TeaModel {
        [NameInMap("CallbackSuggestions")]
        [Validation(Required=false)]
        public string CallbackSuggestions { get; set; }

        [NameInMap("CallbackTypes")]
        [Validation(Required=false)]
        public string CallbackTypes { get; set; }

        [NameInMap("CryptType")]
        [Validation(Required=false)]
        public string CryptType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
