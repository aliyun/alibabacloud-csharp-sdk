// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class DetectFaceAttributesRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public string ImageFile { get; set; }

    }

}
