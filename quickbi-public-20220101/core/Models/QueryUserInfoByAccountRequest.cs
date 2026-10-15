// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByAccountRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account name or Alibaba Cloud ID to query.</para>
        /// <list type="bullet">
        /// <item><description>When you enter an account name:<list type="bullet">
        /// <item><description>If the organization user is a primary account (for example, main_account), the query account format is the primary account. That is, enter the primary account main_account. </description></item>
        /// <item><description>If the organization user is a RAM user (for example, <a href="mailto:zhangsan@test.onaliyun.com">zhangsan@test.onaliyun.com</a>), the query account format is the prefix of the RAM user. That is, enter zhangsan.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>When you enter an Alibaba Cloud ID:<list type="bullet">
        /// <item><description>Enter the complete account UID to query the corresponding account information.</description></item>
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
        /// <para>The account name of the primary account when a duplicate error occurs during RAM user query. For example, <a href="mailto:zhangsan@test.onaliyun.com">zhangsan@test.onaliyun.com</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@test.onaliyun.com">zhangsan@test.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("ParentAccountName")]
        [Validation(Required=false)]
        public string ParentAccountName { get; set; }

    }

}
