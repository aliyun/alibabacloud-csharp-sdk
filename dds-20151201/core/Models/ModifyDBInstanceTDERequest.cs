// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption method. Set the value to <b>aes-256-cbc</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>TEDStatus</b> parameter is set to <b>enabled</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aes-256-cbc</para>
        /// </summary>
        [NameInMap("EncryptorName")]
        [Validation(Required=false)]
        public string EncryptorName { get; set; }

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

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the specified Resource Access Management (RAM) role. The ARN is displayed in the <c>acs:ram::$accountID:role/$roleName</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$accountID</c>: specifies the ID of the Alibaba Cloud account. To view the account ID, log on to the Alibaba Cloud Management Console, move your pointer over your profile picture in the upper-right corner, and then click Security Settings.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$roleName</c>: specifies the name of the RAM role. To view the RAM role name, log on to the RAM console. In the left-side navigation pane, choose Identities &gt; Roles. On the Roles page, view the name of the RAM role.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The TDE status. When the value of this parameter is set to <b>Enabled</b>, TDE is enabled.</para>
        /// <remarks>
        /// <para>You cannot disable TDE after it is enabled. Proceed with caution.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
