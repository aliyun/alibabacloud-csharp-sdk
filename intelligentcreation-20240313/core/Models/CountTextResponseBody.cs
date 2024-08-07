// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CountTextResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("countTextCmdList")]
        [Validation(Required=false)]
        public List<CountTextResponseBodyCountTextCmdList> CountTextCmdList { get; set; }
        public class CountTextResponseBodyCountTextCmdList : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("theme")]
            [Validation(Required=false)]
            public string Theme { get; set; }

        }

    }

}
