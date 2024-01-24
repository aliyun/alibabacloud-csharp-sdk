// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceAccountsResponseBody : TeaModel {
        /// <summary>
        /// Indicates the information about the instance accounts.
        /// </summary>
        [NameInMap("InstanceAccounts")]
        [Validation(Required=false)]
        public DescribeInstanceAccountsResponseBodyInstanceAccounts InstanceAccounts { get; set; }
        public class DescribeInstanceAccountsResponseBodyInstanceAccounts : TeaModel {
            [NameInMap("InstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount> InstanceAccount { get; set; }
            public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccount : TeaModel {
                /// <summary>
                /// Indicates the username of an instance account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// Indicates the type of an instance account. Valid values:
                /// 
                /// *   **0**: The instance account is a privileged account.
                /// *   **1**: The instance account is a standard account.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public int? AccountType { get; set; }

                /// <summary>
                /// Indicates the information about the permissions of an account on a database.
                /// </summary>
                [NameInMap("DbPrivileges")]
                [Validation(Required=false)]
                public DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges DbPrivileges { get; set; }
                public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivileges : TeaModel {
                    [NameInMap("DbPrivilege")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege> DbPrivilege { get; set; }
                    public class DescribeInstanceAccountsResponseBodyInstanceAccountsInstanceAccountDbPrivilegesDbPrivilege : TeaModel {
                        /// <summary>
                        /// Indicates the name of a database.
                        /// </summary>
                        [NameInMap("DbName")]
                        [Validation(Required=false)]
                        public string DbName { get; set; }

                        /// <summary>
                        /// Indicates the permissions that an account is granted on the database. Valid values:
                        /// 
                        /// *   **R**: The account is granted the permissions that are required to read the data of the database.
                        /// *   **W**: The account is granted the permissions that are required to write data to the database.
                        /// *   **DDL**: The account is granted the permissions that are required to perform DDL operations on the database.
                        /// *   **DML**: The account is granted the permissions that are required to perform DML operations on the database.
                        /// </summary>
                        [NameInMap("Privilege")]
                        [Validation(Required=false)]
                        public string Privilege { get; set; }

                    }

                }

                /// <summary>
                /// Indicates the description of an account. By default, if 0 is the value of the AccountType parameter, **Created by DRDS** is returned as the value of the Description parameter. If 1 is the value of the AccountType parameter, an empty string is returned as the value of the Description parameter. You can modify the description of an account on the Accounts page in the PolarDB-X console.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates an IP address that is allowed to access the database. The value **%** indicates that each IP address is allowed to access the database. \</note>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
