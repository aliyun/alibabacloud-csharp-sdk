// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizePublicFaceRequest : TeaModel {
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<RecognizePublicFaceRequestTask> Task { get; set; }
        public class RecognizePublicFaceRequestTask : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
