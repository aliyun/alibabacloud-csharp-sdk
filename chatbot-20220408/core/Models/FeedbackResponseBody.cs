// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackResponseBody : TeaModel {
        /// <summary>
        /// good-点赞、bad-点踩
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// 会话窗单次会话标识
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
