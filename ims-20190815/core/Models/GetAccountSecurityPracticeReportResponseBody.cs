// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSecurityPracticeReportResponseBody : TeaModel {
        /// <summary>
        /// The information of the security report for the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AccountSecurityPracticeInfo")]
        [Validation(Required=false)]
        public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo AccountSecurityPracticeInfo { get; set; }
        public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo : TeaModel {
            /// <summary>
            /// The information of the security report for the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountSecurityPracticeUserInfo")]
            [Validation(Required=false)]
            public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo AccountSecurityPracticeUserInfo { get; set; }
            public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo : TeaModel {
                /// <summary>
                /// Indicates whether MFA is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("BindMfa")]
                [Validation(Required=false)]
                public bool? BindMfa { get; set; }

                /// <summary>
                /// The number of old AccessKey pairs for the Alibaba Cloud account.
                /// </summary>
                [NameInMap("OldAkNum")]
                [Validation(Required=false)]
                public int? OldAkNum { get; set; }

                /// <summary>
                /// The number of AccessKey pairs for the Alibaba Cloud account.
                /// </summary>
                [NameInMap("RootWithAccessKey")]
                [Validation(Required=false)]
                public int? RootWithAccessKey { get; set; }

                /// <summary>
                /// The number of RAM users within the Alibaba Cloud account.
                /// </summary>
                [NameInMap("SubUser")]
                [Validation(Required=false)]
                public int? SubUser { get; set; }

                /// <summary>
                /// The number of RAM users that have MFA devices bound.
                /// </summary>
                [NameInMap("SubUserBindMfa")]
                [Validation(Required=false)]
                public int? SubUserBindMfa { get; set; }

                /// <summary>
                /// The complexity level of the password for the RAM user. Valid values:
                /// 
                /// *   low
                /// *   mid
                /// *   high
                /// </summary>
                [NameInMap("SubUserPwdLevel")]
                [Validation(Required=false)]
                public string SubUserPwdLevel { get; set; }

                /// <summary>
                /// The number of RAM users that use the old AccessKey pairs.
                /// </summary>
                [NameInMap("SubUserWithOldAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithOldAccessKey { get; set; }

                /// <summary>
                /// The number of RAM users that have no AccessKey pairs.
                /// </summary>
                [NameInMap("SubUserWithUnusedAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithUnusedAccessKey { get; set; }

                /// <summary>
                /// The number of AccessKey pairs that are not used for the Alibaba Cloud account.
                /// </summary>
                [NameInMap("UnusedAkNum")]
                [Validation(Required=false)]
                public int? UnusedAkNum { get; set; }

            }

            /// <summary>
            /// The security score of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
