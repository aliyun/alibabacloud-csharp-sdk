// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizePublicFaceAdvanceRequest : TeaModel {
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<RecognizePublicFaceAdvanceRequestTask> Task { get; set; }
        public class RecognizePublicFaceAdvanceRequestTask : TeaModel {
            [NameInMap("ImageData")]
            [Validation(Required=false)]
            public byte[] ImageData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

        }

    }

}
