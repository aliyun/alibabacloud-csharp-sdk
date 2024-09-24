// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried database accounts.</para>
        /// </summary>
        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccountList AccountList { get; set; }
        public class DescribeAccountsResponseBodyAccountList : TeaModel {
            [NameInMap("DBAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountListDBAccount> DBAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountListDBAccount : TeaModel {
                /// <summary>
                /// <para>The description of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_accout_des</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_accout</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The status of the database account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The type of the database account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: standard account.</description></item>
                /// <item><description><b>Super</b>: privileged account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The database engine of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AnalyticDB</b>: the AnalyticDB for MySQL engine.</description></item>
                /// <item><description><b>Clickhouse</b>: the wide table engine.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Clickhouse</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The ID of the Resource Access Management (RAM) user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1958134230****</para>
                /// </summary>
                [NameInMap("RamUsers")]
                [Validation(Required=false)]
                public string RamUsers { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9CCFAAB4-97B7-5800-B9F2-685EB596E3EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
