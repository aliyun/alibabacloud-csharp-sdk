// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitImageCopyrightRequest : TeaModel {
        /// <summary>
        /// 需要加水印的图片oss地址
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// 水印强度
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// 水印信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 水印图片输出oss地址
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
