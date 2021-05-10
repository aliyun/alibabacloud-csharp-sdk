// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeDriverLicenseRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("Side")]
        [Validation(Required=false)]
        public string Side { get; set; }

    }

}
