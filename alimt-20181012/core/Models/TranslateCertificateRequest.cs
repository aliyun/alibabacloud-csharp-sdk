// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateCertificateRequest : TeaModel {
        [NameInMap("SourceLanguage")]
        [Validation(Required=true)]
        public string SourceLanguage { get; set; }

        [NameInMap("TargetLanguage")]
        [Validation(Required=true)]
        public string TargetLanguage { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=true)]
        public string ImageUrl { get; set; }

        [NameInMap("CertificateType")]
        [Validation(Required=true)]
        public string CertificateType { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

    }

}
