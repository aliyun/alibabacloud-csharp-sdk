// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeEduPaperCutRequest : TeaModel {
        /// <summary>
        /// 图片链接（长度不超 1014，不支持 base64）
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 切题类型
        /// </summary>
        [NameInMap("CutType")]
        [Validation(Required=false)]
        public string CutType { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// 年级学科
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
