// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetIMConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Messaage")]
        [Validation(Required=false)]
        public string Messaage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetIMConfigResponseBodyResult Result { get; set; }
        public class GetIMConfigResponseBodyResult : TeaModel {
            [NameInMap("ImConfig")]
            [Validation(Required=false)]
            public GetIMConfigResponseBodyResultImConfig ImConfig { get; set; }
            public class GetIMConfigResponseBodyResultImConfig : TeaModel {
                [NameInMap("CallbackConfig")]
                [Validation(Required=false)]
                public GetIMConfigResponseBodyResultImConfigCallbackConfig CallbackConfig { get; set; }
                public class GetIMConfigResponseBodyResultImConfigCallbackConfig : TeaModel {
                    [NameInMap("Apis")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Apis { get; set; }

                    [NameInMap("CallbackUrl")]
                    [Validation(Required=false)]
                    public string CallbackUrl { get; set; }

                    [NameInMap("Events")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Events { get; set; }

                    [NameInMap("SignatureKey")]
                    [Validation(Required=false)]
                    public string SignatureKey { get; set; }

                    [NameInMap("SignatureValue")]
                    [Validation(Required=false)]
                    public string SignatureValue { get; set; }

                    [NameInMap("Spis")]
                    [Validation(Required=false)]
                    public Dictionary<string, bool?> Spis { get; set; }

                }

                [NameInMap("MsgConfig")]
                [Validation(Required=false)]
                public GetIMConfigResponseBodyResultImConfigMsgConfig MsgConfig { get; set; }
                public class GetIMConfigResponseBodyResultImConfigMsgConfig : TeaModel {
                    [NameInMap("ClientMsgRecallTimeIntervalMinute")]
                    [Validation(Required=false)]
                    public long? ClientMsgRecallTimeIntervalMinute { get; set; }

                }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
