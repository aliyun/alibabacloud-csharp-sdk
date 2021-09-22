// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifySmsCodeRequest : TeaModel {
        [NameInMap("SmsCode")]
        [Validation(Required=false)]
        public string SmsCode { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("SmsToken")]
        [Validation(Required=false)]
        public string SmsToken { get; set; }

    }

}
