// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeHouseholdRequest : TeaModel {
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
