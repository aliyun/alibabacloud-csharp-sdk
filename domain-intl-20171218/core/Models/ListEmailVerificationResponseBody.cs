// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class ListEmailVerificationResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEmailVerificationResponseBodyData> Data { get; set; }
        public class ListEmailVerificationResponseBodyData : TeaModel {
            [NameInMap("ConfirmIp")]
            [Validation(Required=false)]
            public string ConfirmIp { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("EmailVerificationNo")]
            [Validation(Required=false)]
            public string EmailVerificationNo { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("SendIp")]
            [Validation(Required=false)]
            public string SendIp { get; set; }

            [NameInMap("TokenSendTime")]
            [Validation(Required=false)]
            public string TokenSendTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("VerificationStatus")]
            [Validation(Required=false)]
            public int? VerificationStatus { get; set; }

            [NameInMap("VerificationTime")]
            [Validation(Required=false)]
            public string VerificationTime { get; set; }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
