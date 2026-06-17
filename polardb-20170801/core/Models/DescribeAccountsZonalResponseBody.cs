// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAccountsZonalResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the accounts.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<DescribeAccountsZonalResponseBodyAccounts> Accounts { get; set; }
        public class DescribeAccountsZonalResponseBodyAccounts : TeaModel {
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
            /// <para>The lock state of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UnLock: The account is not locked.</para>
            /// </description></item>
            /// <item><description><para>Lock: The account is locked.</para>
            /// </description></item>
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
            /// <para>The time when the password expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>undefined</para>
            /// </summary>
            [NameInMap("AccountPasswordValidTime")]
            [Validation(Required=false)]
            public string AccountPasswordValidTime { get; set; }

            /// <summary>
            /// <para>The status of the account. Valid values:</para>
            /// <para>Creating: The account is being created.</para>
            /// <para>Available: The account is active.</para>
            /// <para>Deleting: The account is being deleted.</para>
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
            /// <item><description><para>Normal: A standard account.</para>
            /// </description></item>
            /// <item><description><para>Super: A privileged account.</para>
            /// </description></item>
            /// <item><description><para>ReadOnly: A global read-only account.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The details of the database permissions that the account has.</para>
            /// </summary>
            [NameInMap("DatabasePrivileges")]
            [Validation(Required=false)]
            public List<DescribeAccountsZonalResponseBodyAccountsDatabasePrivileges> DatabasePrivileges { get; set; }
            public class DescribeAccountsZonalResponseBodyAccountsDatabasePrivileges : TeaModel {
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
        /// <para>The maximum number of entries returned in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If the results are not fully returned, this token is returned. You can use this token in the next request to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
