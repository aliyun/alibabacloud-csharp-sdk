// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class CreateReadOnlyAccountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateReadOnlyAccountResponseBodyData Data { get; set; }
        public class CreateReadOnlyAccountResponseBodyData : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }
            [NameInMap("DrdsInstanceId")]
            [Validation(Required=false)]
            public string DrdsInstanceId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
