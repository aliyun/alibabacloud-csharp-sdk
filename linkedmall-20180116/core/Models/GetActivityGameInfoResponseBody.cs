// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetActivityGameInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetActivityGameInfoResponseBodyModel Model { get; set; }
        public class GetActivityGameInfoResponseBodyModel : TeaModel {
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("GameDTO")]
            [Validation(Required=false)]
            public string GameDTO { get; set; }

            [NameInMap("GameShowInfo")]
            [Validation(Required=false)]
            public string GameShowInfo { get; set; }

            [NameInMap("UserGameCoinInfos")]
            [Validation(Required=false)]
            public string UserGameCoinInfos { get; set; }

            [NameInMap("UserProcessDTO")]
            [Validation(Required=false)]
            public string UserProcessDTO { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
