// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByAccountRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account name or Alibaba Cloud ID of the user.</para>
        /// <list type="bullet">
        /// <item><description><para>If you enter an account name:</para>
        /// <list type="bullet">
        /// <item><description><para>If the organization member is a root account, such as <c>main_account</c>, enter the root account name. For example, <c>main_account</c>.</para>
        /// </description></item>
        /// <item><description><para>If the organization member is a RAM user, such as <c>zhangsan@test.onaliyun.com</c>, enter the prefix of the username before the at sign (@). For example, <c>zhangsan</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you enter an Alibaba Cloud ID:</para>
        /// <list type="bullet">
        /// <item><description>Enter the complete user ID (UID) of the account.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1386587****@163.com</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// <para>To resolve a &quot;duplicate user&quot; error when querying a RAM user, specify the name of the root account to which the user belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@test.onaliyun.com">zhangsan@test.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("ParentAccountName")]
        [Validation(Required=false)]
        public string ParentAccountName { get; set; }

    }

}
