// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BlurFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BlurFaceResponseBodyData Data { get; set; }
        public class BlurFaceResponseBodyData : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("MaskURL")]
            [Validation(Required=false)]
            public string MaskURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
