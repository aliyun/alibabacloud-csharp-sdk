// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeBatchRecognizeRequest : TeaModel {
        /// <summary>
        /// 图片名称
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 图片识别op类型
        /// </summary>
        [NameInMap("ImageOp")]
        [Validation(Required=false)]
        public string ImageOp { get; set; }

        /// <summary>
        /// 图片存入oss中的key
        /// </summary>
        [NameInMap("ImageOssKey")]
        [Validation(Required=false)]
        public string ImageOssKey { get; set; }

        /// <summary>
        /// 是否需要自动旋转功能(结构化检测、混贴场景、教育相关场景会自动做旋转，无需设置)，返回角度信息
        /// </summary>
        [NameInMap("NeedRotate")]
        [Validation(Required=false)]
        public bool? NeedRotate { get; set; }

        /// <summary>
        /// 是否按顺序输出文字块。false表示从左往右，从上到下的顺序；true表示从上到下，从左往右的顺序
        /// </summary>
        [NameInMap("NeedSortPage")]
        [Validation(Required=false)]
        public bool? NeedSortPage { get; set; }

        /// <summary>
        /// 是否输出单字识别结果
        /// </summary>
        [NameInMap("OutputCharInfo")]
        [Validation(Required=false)]
        public bool? OutputCharInfo { get; set; }

        /// <summary>
        /// 是否输出表格识别结果，包含单元格信息
        /// </summary>
        [NameInMap("OutputTable")]
        [Validation(Required=false)]
        public bool? OutputTable { get; set; }

        /// <summary>
        /// 图片链接（长度不超 2048，不支持 base64）
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
