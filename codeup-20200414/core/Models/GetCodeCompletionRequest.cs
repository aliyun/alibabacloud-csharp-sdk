// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetCodeCompletionRequest : TeaModel {
        [NameInMap("FetchKeys")]
        [Validation(Required=false)]
        public string FetchKeys { get; set; }

        [NameInMap("IsEncrypted")]
        [Validation(Required=false)]
        public bool? IsEncrypted { get; set; }

    }

}
