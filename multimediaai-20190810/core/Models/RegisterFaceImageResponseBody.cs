// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class RegisterFaceImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FaceImages")]
        [Validation(Required=false)]
        public List<RegisterFaceImageResponseBodyFaceImages> FaceImages { get; set; }
        public class RegisterFaceImageResponseBodyFaceImages : TeaModel {
            [NameInMap("FaceImageId")]
            [Validation(Required=false)]
            public long? FaceImageId { get; set; }

        }

    }

}
