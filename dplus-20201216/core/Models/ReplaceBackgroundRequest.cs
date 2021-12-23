// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class ReplaceBackgroundRequest : TeaModel {
        /// <summary>
        /// 返回的图片背景图片ID
        /// </summary>
        [NameInMap("BackgroundId")]
        [Validation(Required=false)]
        public string BackgroundId { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("PicBackgroundUrl")]
        [Validation(Required=false)]
        public string PicBackgroundUrl { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

    }

}
