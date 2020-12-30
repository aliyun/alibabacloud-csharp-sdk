// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class CreateFacePersonRequest : TeaModel {
        [NameInMap("FaceGroupId")]
        [Validation(Required=false)]
        public long? FaceGroupId { get; set; }

        [NameInMap("FacePersonName")]
        [Validation(Required=false)]
        public string FacePersonName { get; set; }

        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrls { get; set; }

    }

}
