// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyUserDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyUserDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The details of asset fingerprints for the account.
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyUserDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyUserDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// The date on which the account expires.
            /// </summary>
            [NameInMap("AccountsExpirationDate")]
            [Validation(Required=false)]
            public string AccountsExpirationDate { get; set; }

            /// <summary>
            /// The timestamp at which the last asset fingerprint collection is performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The details of the user groups to which the account belongs.
            /// </summary>
            [NameInMap("GroupNames")]
            [Validation(Required=false)]
            public List<string> GroupNames { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The IP addresses of the server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// Indicates whether the account is an interactive logon account. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("IsCouldLogin")]
            [Validation(Required=false)]
            public int? IsCouldLogin { get; set; }

            /// <summary>
            /// Indicates whether the password expires. Valid values:
            /// 
            /// *   **0**: yes
            /// *   **1**: no
            /// </summary>
            [NameInMap("IsPasswdExpired")]
            [Validation(Required=false)]
            public int? IsPasswdExpired { get; set; }

            /// <summary>
            /// Indicates whether the password is locked. Valid values:
            /// 
            /// *   **0**: yes
            /// *   **1**: no
            /// </summary>
            [NameInMap("IsPasswdLocked")]
            [Validation(Required=false)]
            public int? IsPasswdLocked { get; set; }

            /// <summary>
            /// Indicates whether the account has root permissions. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public string IsRoot { get; set; }

            /// <summary>
            /// Indicates whether the account is a sudo account. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("IsSudoer")]
            [Validation(Required=false)]
            public int? IsSudoer { get; set; }

            /// <summary>
            /// Indicates whether the account expires. Valid values:
            /// 
            /// *   **0**: yes
            /// *   **1**: no
            /// </summary>
            [NameInMap("IsUserExpired")]
            [Validation(Required=false)]
            public int? IsUserExpired { get; set; }

            /// <summary>
            /// The source IP address of the last logon to the account.
            /// </summary>
            [NameInMap("LastLoginIp")]
            [Validation(Required=false)]
            public string LastLoginIp { get; set; }

            /// <summary>
            /// The last logon time of the account.
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// The timestamp of the last logon to the account. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastLoginTimeDt")]
            [Validation(Required=false)]
            public long? LastLoginTimeDt { get; set; }

            /// <summary>
            /// The timestamp of the last logon to the account. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// The date on which the password of the account expires.
            /// </summary>
            [NameInMap("PasswordExpirationDate")]
            [Validation(Required=false)]
            public string PasswordExpirationDate { get; set; }

            /// <summary>
            /// This parameter is deprecated. You can ignore it.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
