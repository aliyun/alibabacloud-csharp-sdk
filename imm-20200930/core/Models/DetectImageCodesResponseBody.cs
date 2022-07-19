// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCodesResponseBody : TeaModel {
        /// <summary>
        /// 二维码检测结果
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public List<Codes> Codes { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
