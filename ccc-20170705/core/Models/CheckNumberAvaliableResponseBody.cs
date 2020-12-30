// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CheckNumberAvaliableResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CallerAvaliable")]
        [Validation(Required=false)]
        public CheckNumberAvaliableResponseBodyCallerAvaliable CallerAvaliable { get; set; }
        public class CheckNumberAvaliableResponseBodyCallerAvaliable : TeaModel {
            [NameInMap("Avaliable")]
            [Validation(Required=false)]
            public bool? Avaliable { get; set; }
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("CalleeAvaliable")]
        [Validation(Required=false)]
        public CheckNumberAvaliableResponseBodyCalleeAvaliable CalleeAvaliable { get; set; }
        public class CheckNumberAvaliableResponseBodyCalleeAvaliable : TeaModel {
            [NameInMap("Avaliable")]
            [Validation(Required=false)]
            public bool? Avaliable { get; set; }
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
        };

    }

}
