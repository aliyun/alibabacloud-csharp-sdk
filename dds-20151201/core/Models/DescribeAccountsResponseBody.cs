// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the account.</para>
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeAccountsResponseBodyAccounts Accounts { get; set; }
        public class DescribeAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeAccountsResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// <para>The description of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("AccountDescription")]
                [Validation(Required=false)]
                public string AccountDescription { get; set; }

                /// <summary>
                /// <para>The name of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The status of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unavailable</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <para>The role of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>db</b>: shard node</description></item>
                /// <item><description><b>cs</b>: Configserver node</description></item>
                /// <item><description><b>mongos</b>: mongos node</description></item>
                /// <item><description><b>logic</b>: sharded cluster instance</description></item>
                /// <item><description><b>normal</b>: replica set instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mongos</para>
                /// </summary>
                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the account belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp1fd530f271****</para>
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
        /// <para>B562A65B-39AB-4EE8-8635-5A222054FB35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
