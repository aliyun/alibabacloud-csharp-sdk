// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class ReplaceBackgroundAdvanceRequest : TeaModel {
        [NameInMap("PicUrlObject")]
        [Validation(Required=true)]
        public Stream PicUrlObject { get; set; }

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

    }

}
