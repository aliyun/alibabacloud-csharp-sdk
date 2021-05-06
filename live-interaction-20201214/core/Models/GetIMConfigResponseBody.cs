// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetIMConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 网络错误码
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Messaage")]
        [Validation(Required=false)]
        public string Messaage { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetIMConfigResponseBodyResult Result { get; set; }
        public class GetIMConfigResponseBodyResult : TeaModel {
            [NameInMap("ImConfig")]
            [Validation(Required=false)]
            public GetIMConfigResponseBodyResultImConfig ImConfig { get; set; }
            public class GetIMConfigResponseBodyResultImConfig : TeaModel {
                /// <summary>
                /// 消息配置
                /// </summary>
                [NameInMap("MsgConfig")]
                [Validation(Required=false)]
                public GetIMConfigResponseBodyResultImConfigMsgConfig MsgConfig { get; set; }
                public class GetIMConfigResponseBodyResultImConfigMsgConfig : TeaModel {
                    [NameInMap("ClientMsgRecallTimeIntervalMinute")]
                    [Validation(Required=false)]
                    public long? ClientMsgRecallTimeIntervalMinute { get; set; }
                };

                /// <summary>
                /// 回调配置
                /// </summary>
                [NameInMap("CallbackConfig")]
                [Validation(Required=false)]
                public GetIMConfigResponseBodyResultImConfigCallbackConfig CallbackConfig { get; set; }
                public class GetIMConfigResponseBodyResultImConfigCallbackConfig : TeaModel {
                    [NameInMap("CallbackUrl")]
                    [Validation(Required=false)]
                    public string CallbackUrl { get; set; }
                    [NameInMap("SignatureKey")]
                    [Validation(Required=false)]
                    public string SignatureKey { get; set; }
                    [NameInMap("SignatureValue")]
                    [Validation(Required=false)]
                    public string SignatureValue { get; set; }
                    [NameInMap("Apis")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Apis { get; set; }
                };

            }
        };

    }

}
