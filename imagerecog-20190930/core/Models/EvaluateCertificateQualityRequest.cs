// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class EvaluateCertificateQualityRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=true)]
        public string ImageURL { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
