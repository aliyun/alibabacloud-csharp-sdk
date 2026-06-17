// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAccountPasswordZonalRequest : TeaModel {
        /// <summary>
        /// <para>The account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>A client-generated, case-sensitive token that you can use to ensure the idempotence of the request. The token must be unique among different requests and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The new password for the account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Be 8 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pw123456</para>
        /// </summary>
        [NameInMap("NewAccountPassword")]
        [Validation(Required=false)]
        public string NewAccountPassword { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tair</para>
        /// </summary>
        [NameInMap("PasswordType")]
        [Validation(Required=false)]
        public string PasswordType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
