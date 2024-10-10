// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByAccountRequest : TeaModel {
        /// <summary>
        /// <para>Enter the name or ID of the Alibaba Cloud account that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><para>When you enter an account name:</para>
        /// <list type="bullet">
        /// <item><description>If the organization user is a master account, such as main_account, the query account format is master account. That is, the main account main_account to be entered.</description></item>
        /// <item><description>If the organization user is a RAM user, such as a <a href="mailto:zhangsan@test.onaliyun.com">zhangsan@test.onaliyun.com</a>, the query account format is the head of the RAM user, that is, the RAM user to be entered is zhangsan.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ID：</para>
        /// <list type="bullet">
        /// <item><description>Enter the UID of the account to query the account information.</description></item>
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

        [NameInMap("ParentAccountName")]
        [Validation(Required=false)]
        public string ParentAccountName { get; set; }

    }

}
