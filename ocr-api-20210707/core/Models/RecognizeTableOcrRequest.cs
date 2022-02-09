// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeTableOcrRequest : TeaModel {
        /// <summary>
        /// 是否无线条
        /// </summary>
        [NameInMap("LineLess")]
        [Validation(Required=false)]
        public bool? LineLess { get; set; }

        /// <summary>
        /// 是否需要自动旋转功能，默认需要
        /// </summary>
        [NameInMap("NeedRotate")]
        [Validation(Required=false)]
        public bool? NeedRotate { get; set; }

        /// <summary>
        /// 是否跳过表格识别，如果没有检测到表格，可以设置"skip_detection":true
        /// </summary>
        [NameInMap("SkipDetection")]
        [Validation(Required=false)]
        public bool? SkipDetection { get; set; }

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
