// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class BeginSessionResponseBody : TeaModel {
        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 欢迎语
        /// </summary>
        [NameInMap("WelcomeMessage")]
        [Validation(Required=false)]
        public string WelcomeMessage { get; set; }

    }

}
