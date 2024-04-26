// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyRequest : TeaModel {
        [NameInMap("CertNum")]
        [Validation(Required=false)]
        public string CertNum { get; set; }

        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        [NameInMap("ImageContext")]
        [Validation(Required=false)]
        public string ImageContext { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("IsCheck")]
        [Validation(Required=false)]
        public string IsCheck { get; set; }

        [NameInMap("IsOCR")]
        [Validation(Required=false)]
        public string IsOCR { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
