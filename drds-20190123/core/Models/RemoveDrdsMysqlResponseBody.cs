// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class RemoveDrdsMysqlResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveDrdsMysqlResponseBodyData Data { get; set; }
        public class RemoveDrdsMysqlResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
