// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeDriverLicenseAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public int? ImageType { get; set; }

        [NameInMap("Side")]
        [Validation(Required=false)]
        public string Side { get; set; }

    }

}
