// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCroppingResponseBody : TeaModel {
        /// <summary>
        /// 图片裁剪结果
        /// </summary>
        [NameInMap("Croppings")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> Croppings { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
