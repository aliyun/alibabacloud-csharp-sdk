// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// The details of the account.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<DescribeAccountsResponseBodyAccounts> Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            /// <summary>
            /// The description of the account.
            /// </summary>
            [NameInMap("AccountDescription")]
            [Validation(Required=false)]
            public string AccountDescription { get; set; }

            /// <summary>
            /// The locking state of the account. Valid values:
            /// 
            /// *   **UnLock**
            /// *   **Lock**
            /// </summary>
            [NameInMap("AccountLockState")]
            [Validation(Required=false)]
            public string AccountLockState { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The validity period of the password.
            /// </summary>
            [NameInMap("AccountPasswordValidTime")]
            [Validation(Required=false)]
            public string AccountPasswordValidTime { get; set; }

            /// <summary>
            /// The state of the account. Valid values:
            /// 
            /// *   **Creating**: The account is being created.
            /// *   **Available**: The account is available.
            /// *   **Deleting**: The account is being deleted
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// The type of the account. Valid values:
            /// 
            /// *   **Normal**: a standard account
            /// *   **Super**: a privileged account
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// The list of database permissions that are granted to the account.
            /// </summary>
            [NameInMap("DatabasePrivileges")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
            public class DescribeAccountsResponseBodyAccountsDatabasePrivileges : TeaModel {
                /// <summary>
                /// The permissions that the account is granted on the database. Valid values:
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
