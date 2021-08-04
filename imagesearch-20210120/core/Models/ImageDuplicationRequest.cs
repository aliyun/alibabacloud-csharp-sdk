// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImageDuplicationRequest : TeaModel {
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("PicUrlList")]
        [Validation(Required=false)]
        public string PicUrlList { get; set; }

        [NameInMap("PicNumList")]
        [Validation(Required=false)]
        public string PicNumList { get; set; }

        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        [NameInMap("OutputImageNum")]
        [Validation(Required=false)]
        public long? OutputImageNum { get; set; }

    }

}
