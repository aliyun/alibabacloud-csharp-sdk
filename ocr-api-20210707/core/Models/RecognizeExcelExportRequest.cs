// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeExcelExportRequest : TeaModel {
        /// <summary>
        /// 文件名称
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 图片识别op类型
        /// </summary>
        [NameInMap("ImageOp")]
        [Validation(Required=false)]
        public string ImageOp { get; set; }

        /// <summary>
        /// 识别图片数量
        /// </summary>
        [NameInMap("OcrImageCount")]
        [Validation(Required=false)]
        public long? OcrImageCount { get; set; }

        /// <summary>
        /// 图片识别结果集
        /// </summary>
        [NameInMap("OcrResult")]
        [Validation(Required=false)]
        public string OcrResult { get; set; }

        /// <summary>
        /// 票证类型
        /// </summary>
        [NameInMap("OcrType")]
        [Validation(Required=false)]
        public string OcrType { get; set; }

    }

}
