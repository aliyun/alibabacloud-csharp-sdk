// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryEmailVerificationResponseBody : TeaModel {
        [NameInMap("VerificationStatus")]
        [Validation(Required=false)]
        public int? VerificationStatus { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("EmailVerificationNo")]
        [Validation(Required=false)]
        public string EmailVerificationNo { get; set; }

        [NameInMap("ConfirmIp")]
        [Validation(Required=false)]
        public string ConfirmIp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("SendIp")]
        [Validation(Required=false)]
        public string SendIp { get; set; }

        [NameInMap("VerificationTime")]
        [Validation(Required=false)]
        public string VerificationTime { get; set; }

        [NameInMap("TokenSendTime")]
        [Validation(Required=false)]
        public string TokenSendTime { get; set; }

    }

}
