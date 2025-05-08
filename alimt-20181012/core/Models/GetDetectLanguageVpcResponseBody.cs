// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetDetectLanguageVpcResponseBody : TeaModel {
        [NameInMap("DetectedLanguage")]
        [Validation(Required=false)]
        public string DetectedLanguage { get; set; }

        [NameInMap("LanguageProbabilities")]
        [Validation(Required=false)]
        public string LanguageProbabilities { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
