// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class JoinLiveResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public JoinLiveResponseBodyData Data { get; set; }
        public class JoinLiveResponseBodyData : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }
            [NameInMap("TokenData")]
            [Validation(Required=false)]
            public JoinLiveResponseBodyDataTokenData TokenData { get; set; }
            public class JoinLiveResponseBodyDataTokenData : TeaModel {
                [NameInMap("Turn")]
                [Validation(Required=false)]
                public JoinLiveResponseBodyDataTokenDataTurn Turn { get; set; }
                public class JoinLiveResponseBodyDataTokenDataTurn : TeaModel {
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }
                };

                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("Nonce")]
                [Validation(Required=false)]
                public string Nonce { get; set; }

                [NameInMap("Gslb")]
                [Validation(Required=false)]
                public List<string> Gslb { get; set; }

                [NameInMap("LiveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
