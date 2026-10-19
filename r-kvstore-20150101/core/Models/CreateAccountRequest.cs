// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account.</para>
        /// <list type="bullet">
        /// <item><description>The description must start with a Chinese character or an English letter. It cannot start with <c>http: //</c> or <c>https: //</c>.</description></item>
        /// <item><description>The description can contain Chinese characters, English letters, digits, underscores (_), and hyphens (-). </description></item>
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The account name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name starts with a lowercase letter and can contain lowercase letters, digits, or underscores (_).</description></item>
        /// <item><description>The name is up to 100 characters in length.</description></item>
        /// <item><description>The name cannot be a &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/redis/user-guide/create-and-manage-database-accounts#section-u3q-817-om3">reserved word for Redis account names</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/redis/user-guide/create-and-manage-database-accounts#section-u3q-817-om3">reserved word for Redis account names</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the account. The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Allowed special characters include <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uWonno21****</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The permissions of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RoleReadOnly</b>: read-only permissions.</description></item>
        /// <item><description><b>RoleReadWrite</b>: read and write permissions. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RoleReadOnly</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The account type. Set the value to <b>Normal</b> (standard account).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The account parameters to modify in JSON format. The new values overwrite the original values.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for Tair Serverless KV instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;access-db-id&quot;:&quot;1&quot;,&quot;cu-limit&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>This parameter is used only for internal maintenance. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
