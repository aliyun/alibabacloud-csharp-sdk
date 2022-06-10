// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeletePerspectiveResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 删除视角的结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
