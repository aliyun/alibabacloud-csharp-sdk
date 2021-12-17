// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeEduPaperOcrRequest : TeaModel {
        /// <summary>
        /// 图片类型
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// 是否输出原图坐标信息(如果图片被做过旋转，图片校正等处理)
        /// </summary>
        [NameInMap("OutputOricoord")]
        [Validation(Required=false)]
        public bool? OutputOricoord { get; set; }

        /// <summary>
        /// 年级学科
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 图片链接（长度不超 2048，不支持 base64）
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 图片二进制字节流，最大10MB
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
