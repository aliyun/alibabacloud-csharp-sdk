// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the account information.</para>
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
            /// <para>The lock status of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UnLock</b>: The account is not locked.</description></item>
            /// <item><description><b>Lock</b>: The account is locked.</description></item>
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
            /// <para>The validity period of the account password. A value of <c>undefined</c> indicates that no validity period is set. A value of <c>infinity</c> indicates that the password never expires. A value of <c>-infinity</c> indicates that the password has expired. If an expiration time is specified, a UTC time string in the ISO 8601 format (<c>YYYY-MM-DDThh:mm:ssZ</c>) is returned instead of a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>undefined</para>
            /// </summary>
            [NameInMap("AccountPasswordValidTime")]
            [Validation(Required=false)]
            public string AccountPasswordValidTime { get; set; }

            /// <summary>
            /// <para>The status of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The account is being created.</description></item>
            /// <item><description><b>Available</b>: The account is available.</description></item>
            /// <item><description><b>Deleting</b>: The account is being deleted.</description></item>
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
            /// <item><description><b>Normal</b>: standard account</description></item>
            /// <item><description><b>Super</b>: privileged account</description></item>
            /// <item><description><b>ReadOnly</b>: global read-only account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The details of the database permissions owned by the account.</para>
            /// </summary>
            [NameInMap("DatabasePrivileges")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
            public class DescribeAccountsResponseBodyAccountsDatabasePrivileges : TeaModel {
                /// <summary>
                /// <para>The permissions of the account.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
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
