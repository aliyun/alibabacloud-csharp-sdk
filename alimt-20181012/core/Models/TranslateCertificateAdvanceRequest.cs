// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateCertificateAdvanceRequest : TeaModel {
        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public Stream ImageUrlObject { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
