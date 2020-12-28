// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetRealPersonVerificationResultRequest : TeaModel {
        [NameInMap("VerificationToken")]
        [Validation(Required=false)]
        public string VerificationToken { get; set; }

        [NameInMap("MaterialHash")]
        [Validation(Required=false)]
        public string MaterialHash { get; set; }

    }

}
