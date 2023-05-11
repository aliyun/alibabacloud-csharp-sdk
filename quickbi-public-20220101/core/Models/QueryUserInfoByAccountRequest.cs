// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByAccountRequest : TeaModel {
        /// <summary>
        /// Enter the name or ID of the Alibaba Cloud account that you want to query.
        /// 
        /// *   When you enter an account name:
        /// 
        ///     *   If the organization user is a master account, such as main_account, the query account format is master account. That is, the main account main_account to be entered.
        ///     *   If the organization user is a RAM user, such as a <zhangsan@test.onaliyun.com>, the query account format is the head of the RAM user, that is, the RAM user to be entered is zhangsan.
        /// 
        /// *   ID：
        /// 
        ///     *   Enter the UID of the account to query the account information.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

    }

}
