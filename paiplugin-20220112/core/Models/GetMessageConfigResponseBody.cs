// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class GetMessageConfigResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMessageConfigResponseBodyData Data { get; set; }
        public class GetMessageConfigResponseBodyData : TeaModel {
            /// <summary>
            /// 短信发送状态回执接收服务地址。
            /// </summary>
            [NameInMap("SmsReportUrl")]
            [Validation(Required=false)]
            public string SmsReportUrl { get; set; }

            /// <summary>
            /// 上行短信消息接收服务地址。
            /// </summary>
            [NameInMap("SmsUpUrl")]
            [Validation(Required=false)]
            public string SmsUpUrl { get; set; }

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
