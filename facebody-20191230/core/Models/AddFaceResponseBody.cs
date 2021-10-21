// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddFaceResponseBodyData Data { get; set; }
        public class AddFaceResponseBodyData : TeaModel {
            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }
            [NameInMap("QualitieScore")]
            [Validation(Required=false)]
            public float? QualitieScore { get; set; }
        };

    }

}
