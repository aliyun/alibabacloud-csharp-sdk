// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class FaceRecognizeRequest : TeaModel {
        [NameInMap("FaceRequest")]
        [Validation(Required=false)]
        public FaceRecognizeRequestFaceRequest FaceRequest { get; set; }
        public class FaceRecognizeRequestFaceRequest : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Liveness")]
            [Validation(Required=false)]
            public bool? Liveness { get; set; }

            [NameInMap("SourceImage")]
            [Validation(Required=false)]
            public string SourceImage { get; set; }

            [NameInMap("TargetImage")]
            [Validation(Required=false)]
            public string TargetImage { get; set; }

        }

    }

}
