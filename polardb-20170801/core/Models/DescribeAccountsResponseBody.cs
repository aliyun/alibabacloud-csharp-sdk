// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the account.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<DescribeAccountsResponseBodyAccounts> Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            /// <summary>
            /// <para>The description of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccountDescription")]
            [Validation(Required=false)]
            public string AccountDescription { get; set; }

            /// <summary>
            /// <para>The locking state of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UnLock</b></description></item>
            /// <item><description><b>Lock</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UnLock</para>
            /// </summary>
            [NameInMap("AccountLockState")]
            [Validation(Required=false)]
            public string AccountLockState { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_acc</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The validity period of the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>undefined</para>
            /// </summary>
            [NameInMap("AccountPasswordValidTime")]
            [Validation(Required=false)]
            public string AccountPasswordValidTime { get; set; }

            /// <summary>
            /// <para>The state of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The account is being created.</description></item>
            /// <item><description><b>Available</b>: The account is available.</description></item>
            /// <item><description><b>Deleting</b>: The account is being deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>The type of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: a standard account</description></item>
            /// <item><description><b>Super</b>: a privileged account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The list of database permissions that are granted to the account.</para>
            /// </summary>
            [NameInMap("DatabasePrivileges")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
            public class DescribeAccountsResponseBodyAccountsDatabasePrivileges : TeaModel {
                /// <summary>
                /// <para>The permissions that the account is granted on the database. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DBtest</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>155462B9-205F-4FFC-BB43-4855FE******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
