// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAccountPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account for which you want to change the password. You can call the <a href="https://help.aliyun.com/document_detail/95802.html">DescribeAccounts</a> operation to query the username of the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new password to be set for the account. The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters. These special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newPassWd888****</para>
        /// </summary>
        [NameInMap("NewAccountPassword")]
        [Validation(Required=false)]
        public string NewAccountPassword { get; set; }

        /// <summary>
        /// <para>The current password of the account.</para>
        /// <remarks>
        /// <para>If you forget your password, you can call the <a href="https://help.aliyun.com/document_detail/95941.html">ResetAccountPassword</a> operation to reset your password.</para>
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

        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
