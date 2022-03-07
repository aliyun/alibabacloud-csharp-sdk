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
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<SendMessageResponseBodyDataMessages> Messages { get; set; }
            public class SendMessageResponseBodyDataMessages : TeaModel {
                public string Id { get; set; }
                public string PhoneNumber { get; set; }
            }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
        };

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
