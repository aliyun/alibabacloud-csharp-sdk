// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class InviteSubAccountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public InviteSubAccountResponseBodyResults Results { get; set; }
        public class InviteSubAccountResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<InviteSubAccountResponseBodyResultsResult> Result { get; set; }
            public class InviteSubAccountResponseBodyResultsResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public InviteSubAccountResponseBodyResultsResultResult Result { get; set; }
                public class InviteSubAccountResponseBodyResultsResultResult : TeaModel {
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    [NameInMap("InviteId")]
                    [Validation(Required=false)]
                    public long? InviteId { get; set; }

                    [NameInMap("RegUrl")]
                    [Validation(Required=false)]
                    public string RegUrl { get; set; }

                }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
