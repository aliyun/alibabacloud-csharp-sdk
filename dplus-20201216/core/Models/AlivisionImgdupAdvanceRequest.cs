// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class AlivisionImgdupAdvanceRequest : TeaModel {
        [NameInMap("PicUrlObject")]
        [Validation(Required=true)]
        public Stream PicUrlObject { get; set; }

        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public int? ImageHeight { get; set; }

        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public int? ImageWidth { get; set; }

        [NameInMap("OutputImageNum")]
        [Validation(Required=false)]
        public int? OutputImageNum { get; set; }

        [NameInMap("PicNum")]
        [Validation(Required=false)]
        public int? PicNum { get; set; }

    }

}
