// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAskLumaLogResult : TeaModel {
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<AskLumaLogEntry> Entries { get; set; }

        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("LastKey")]
        [Validation(Required=false)]
        public string LastKey { get; set; }

    }

}
