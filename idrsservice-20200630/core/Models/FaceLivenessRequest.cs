// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class FaceLivenessRequest : TeaModel {
        [NameInMap("FaceRequest")]
        [Validation(Required=false)]
        public FaceLivenessRequestFaceRequest FaceRequest { get; set; }
        public class FaceLivenessRequestFaceRequest : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("SourceImage")]
            [Validation(Required=false)]
            public string SourceImage { get; set; }

        }

    }

}
