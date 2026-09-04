// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccountList AccountList { get; set; }
        public class DescribeAccountsResponseBodyAccountList : TeaModel {
            [NameInMap("DBAccount")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountListDBAccount> DBAccount { get; set; }
            public class DescribeAccountsResponseBodyAccountListDBAccount : TeaModel {
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("PromqlInsertPrivileges")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountListDBAccountPromqlInsertPrivileges PromqlInsertPrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountListDBAccountPromqlInsertPrivileges : TeaModel {
                    [NameInMap("PromqlInsertPrivileges")]
                    [Validation(Required=false)]
                    public List<string> PromqlInsertPrivileges { get; set; }

                }

                [NameInMap("PromqlSelectNodes")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountListDBAccountPromqlSelectNodes PromqlSelectNodes { get; set; }
                public class DescribeAccountsResponseBodyAccountListDBAccountPromqlSelectNodes : TeaModel {
                    [NameInMap("PromqlSelectNodes")]
                    [Validation(Required=false)]
                    public List<string> PromqlSelectNodes { get; set; }

                }

                [NameInMap("PromqlSelectPrivileges")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountListDBAccountPromqlSelectPrivileges PromqlSelectPrivileges { get; set; }
                public class DescribeAccountsResponseBodyAccountListDBAccountPromqlSelectPrivileges : TeaModel {
                    [NameInMap("PromqlSelectPrivileges")]
                    [Validation(Required=false)]
                    public List<string> PromqlSelectPrivileges { get; set; }

                }

                [NameInMap("RamUserList")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountListDBAccountRamUserList RamUserList { get; set; }
                public class DescribeAccountsResponseBodyAccountListDBAccountRamUserList : TeaModel {
                    [NameInMap("RamUserList")]
                    [Validation(Required=false)]
                    public List<string> RamUserList { get; set; }

                }

                [NameInMap("RamUsers")]
                [Validation(Required=false)]
                public string RamUsers { get; set; }

                [NameInMap("promqlSelectNodePercentage")]
                [Validation(Required=false)]
                public double? PromqlSelectNodePercentage { get; set; }

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
