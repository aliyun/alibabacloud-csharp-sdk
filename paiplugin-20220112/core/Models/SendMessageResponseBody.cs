// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SendMessageResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SendMessageResponseBodyData Data { get; set; }
        public class SendMessageResponseBodyData : TeaModel {
            /// <summary>
            /// 短信结果列表，列表中手机号的顺序与输入请求手机号顺序一一对应。
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<SendMessageResponseBodyDataMessages> Messages { get; set; }
            public class SendMessageResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// 短信Id，可使用ListMessages查询短信状态。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 手机号码。
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

            }

            /// <summary>
            /// 短信批处理Id，可使用ListMessages查询短信状态。
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
