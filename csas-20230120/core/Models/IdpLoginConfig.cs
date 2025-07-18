// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpLoginConfig : TeaModel {
        [NameInMap("MobileLoginType")]
        [Validation(Required=false)]
        public string MobileLoginType { get; set; }

        [NameInMap("MobileMfaTypes")]
        [Validation(Required=false)]
        public string MobileMfaTypes { get; set; }

        [NameInMap("PcLoginType")]
        [Validation(Required=false)]
        public string PcLoginType { get; set; }

        [NameInMap("PcMfaTypes")]
        [Validation(Required=false)]
        public string PcMfaTypes { get; set; }

        [NameInMap("TotpCorpVerifyAesKey")]
        [Validation(Required=false)]
        public string TotpCorpVerifyAesKey { get; set; }

        [NameInMap("TotpCorpVerifyToken")]
        [Validation(Required=false)]
        public string TotpCorpVerifyToken { get; set; }

        [NameInMap("TotpCorpVerifyUrl")]
        [Validation(Required=false)]
        public string TotpCorpVerifyUrl { get; set; }

    }

}
