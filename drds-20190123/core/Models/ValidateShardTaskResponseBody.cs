// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ValidateShardTaskResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ValidateShardTaskResponseBodyList> List { get; set; }
        public class ValidateShardTaskResponseBodyList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
