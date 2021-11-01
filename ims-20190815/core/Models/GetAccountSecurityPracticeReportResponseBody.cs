// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSecurityPracticeReportResponseBody : TeaModel {
        [NameInMap("AccountSecurityPracticeInfo")]
        [Validation(Required=false)]
        public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo AccountSecurityPracticeInfo { get; set; }
        public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo : TeaModel {
            [NameInMap("AccountSecurityPracticeUserInfo")]
            [Validation(Required=false)]
            public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo AccountSecurityPracticeUserInfo { get; set; }
            public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo : TeaModel {
                [NameInMap("BindMfa")]
                [Validation(Required=false)]
                public bool? BindMfa { get; set; }

                [NameInMap("OldAkNum")]
                [Validation(Required=false)]
                public int? OldAkNum { get; set; }

                [NameInMap("RootWithAccessKey")]
                [Validation(Required=false)]
                public int? RootWithAccessKey { get; set; }

                [NameInMap("SubUser")]
                [Validation(Required=false)]
                public int? SubUser { get; set; }

                [NameInMap("SubUserBindMfa")]
                [Validation(Required=false)]
                public int? SubUserBindMfa { get; set; }

                [NameInMap("SubUserPwdLevel")]
                [Validation(Required=false)]
                public string SubUserPwdLevel { get; set; }

                [NameInMap("SubUserWithOldAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithOldAccessKey { get; set; }

                [NameInMap("SubUserWithUnusedAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithUnusedAccessKey { get; set; }

                [NameInMap("UnusedAkNum")]
                [Validation(Required=false)]
                public int? UnusedAkNum { get; set; }

            }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
