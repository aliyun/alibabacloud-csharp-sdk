// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetUserBuyStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUserBuyStatusResponseBodyData Data { get; set; }
        public class GetUserBuyStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Bid。
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public long? Bid { get; set; }

            [NameInMap("Buy")]
            [Validation(Required=false)]
            public bool? Buy { get; set; }

            [NameInMap("Indebt")]
            [Validation(Required=false)]
            public bool? Indebt { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
