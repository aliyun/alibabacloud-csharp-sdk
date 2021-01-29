// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBusinessLicenseRequest : TeaModel {
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public int? ImageType { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

    }

}
