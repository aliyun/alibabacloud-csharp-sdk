// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAccountPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account whose password you want to modify. You can call <a href="https://help.aliyun.com/document_detail/473816.html">DescribeAccounts</a> to query the account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

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

        /// <summary>
        /// <para>The new password to set for the account. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newPassWd888****</para>
        /// </summary>
        [NameInMap("NewAccountPassword")]
        [Validation(Required=false)]
        public string NewAccountPassword { get; set; }

        /// <summary>
        /// <para>The original password of the account.</para>
        /// <remarks>
        /// <para>If you forget the password of the account, you can call <a href="https://help.aliyun.com/document_detail/473815.html">ResetAccountPassword</a> to reset the password.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oldPassWd999****</para>
        /// </summary>
        [NameInMap("OldAccountPassword")]
        [Validation(Required=false)]
        public string OldAccountPassword { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para>This parameter is used only for internal maintenance purposes. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDK</para>
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
