// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
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
                /// <para>C@test</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The state of the database account. Valid values:</para>
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

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAccountsResponseBodyAccountListDBAccountTags Tags { get; set; }
                public class DescribeAccountsResponseBodyAccountListDBAccountTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAccountsResponseBodyAccountListDBAccountTagsTag> Tag { get; set; }
                    public class DescribeAccountsResponseBodyAccountListDBAccountTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64E37E6F-C363-41F3-867A-70EF5DC60EA4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
