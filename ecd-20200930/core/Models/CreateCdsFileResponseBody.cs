// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCdsFileResponseBody : TeaModel {
        [NameInMap("FileModel")]
        [Validation(Required=false)]
        public CreateCdsFileResponseBodyFileModel FileModel { get; set; }
        public class CreateCdsFileResponseBodyFileModel : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
