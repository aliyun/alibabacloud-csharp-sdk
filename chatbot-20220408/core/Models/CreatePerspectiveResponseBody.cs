// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePerspectiveResponseBody : TeaModel {
        /// <summary>
        /// 视角主键（code_id）
        /// </summary>
        [NameInMap("PerspectiveId")]
        [Validation(Required=false)]
        public string PerspectiveId { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
