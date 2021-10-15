// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficeWatermark : TeaModel {
        /// <summary>
        /// 字体颜色
        /// </summary>
        [NameInMap("FillStyle")]
        [Validation(Required=false)]
        public string FillStyle { get; set; }

        /// <summary>
        /// 字体样式
        /// </summary>
        [NameInMap("Font")]
        [Validation(Required=false)]
        public string Font { get; set; }

        /// <summary>
        /// 水平间距
        /// </summary>
        [NameInMap("Horizontal")]
        [Validation(Required=false)]
        public long? Horizontal { get; set; }

        /// <summary>
        /// 旋转角度
        /// </summary>
        [NameInMap("Rotate")]
        [Validation(Required=false)]
        public float? Rotate { get; set; }

        /// <summary>
        /// 水印类型，目前仅支持文字水印，0: 无水印；1: 文字水印
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// 水印文字
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// 垂直间距
        /// </summary>
        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public long? Vertical { get; set; }

    }

}
