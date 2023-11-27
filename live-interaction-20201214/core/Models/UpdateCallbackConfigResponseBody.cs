// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateCallbackConfigResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// httpStatusCode
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// desc
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateCallbackConfigResponseBodyResult Result { get; set; }
        public class UpdateCallbackConfigResponseBodyResult : TeaModel {
            [NameInMap("ImConfig")]
            [Validation(Required=false)]
            public UpdateCallbackConfigResponseBodyResultImConfig ImConfig { get; set; }
            public class UpdateCallbackConfigResponseBodyResultImConfig : TeaModel {
                [NameInMap("CallbackConfig")]
                [Validation(Required=false)]
                public UpdateCallbackConfigResponseBodyResultImConfigCallbackConfig CallbackConfig { get; set; }
                public class UpdateCallbackConfigResponseBodyResultImConfigCallbackConfig : TeaModel {
                    [NameInMap("ApiIds")]
                    [Validation(Required=false)]
                    public List<string> ApiIds { get; set; }

                    [NameInMap("BackendUrl")]
                    [Validation(Required=false)]
                    public string BackendUrl { get; set; }

                    [NameInMap("SignatureKey")]
                    [Validation(Required=false)]
                    public string SignatureKey { get; set; }

                    [NameInMap("SignatureValue")]
                    [Validation(Required=false)]
                    public string SignatureValue { get; set; }

                }

                [NameInMap("MsgConfig")]
                [Validation(Required=false)]
                public UpdateCallbackConfigResponseBodyResultImConfigMsgConfig MsgConfig { get; set; }
                public class UpdateCallbackConfigResponseBodyResultImConfigMsgConfig : TeaModel {
                    [NameInMap("MsgRecallTimeInterval")]
                    [Validation(Required=false)]
                    public long? MsgRecallTimeInterval { get; set; }

                }

            }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
