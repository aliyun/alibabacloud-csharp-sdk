// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeExitEntryPermitToHKRequest : TeaModel {
        /// <summary>
        /// 图案坐标信息输出，针对结构化，如身份证人脸头像
        /// </summary>
        [NameInMap("OutputFigure")]
        [Validation(Required=false)]
        public bool? OutputFigure { get; set; }

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
