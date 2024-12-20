// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried database accounts.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("DBInstanceAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsDBInstanceAccount> DBInstanceAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountsDBInstanceAccount : TeaModel {
                /// <summary>
                /// <para>The description of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The state of the account.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The account is being created.</description></item>
                /// <item><description><b>1</b>: The account is in use.</description></item>
                /// <item><description><b>3</b>: The account is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The type of the database account. Valid values: Super and Normal. Super indicates a privileged account and Normal indicates a standard account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Super</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp***************</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7565770E-7C45-462D-BA4A-8A5396F2CAD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
