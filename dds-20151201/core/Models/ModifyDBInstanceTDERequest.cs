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
        /// <para>The ID of the custom key.
        /// Custom keys are supported only in the following regions. In other regions, the default key is used.</para>
        /// <list type="bullet">
        /// <item><description><para>Singapore (ap-southeast-1)</para>
        /// </description></item>
        /// <item><description><para>Hangzhou (cn-hangzhou)</para>
        /// </description></item>
        /// <item><description><para>Shanghai (cn-shanghai)</para>
        /// </description></item>
        /// <item><description><para>Beijing (cn-beijing)</para>
        /// </description></item>
        /// <item><description><para>Shenzhen (cn-shenzhen)</para>
        /// </description></item>
        /// <item><description><para>Hong Kong (cn-hongkong)</para>
        /// </description></item>
        /// <item><description><para>Malaysia (ap-southeast-3)</para>
        /// </description></item>
        /// </list>
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
        /// <para>This parameter is available only when <b>TDEStatus</b> is set to <b>enabled</b>.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role. The format is <c>acs:ram::$accountID:role/$roleName </c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><c>$accountID</c>: The ID of your Alibaba Cloud account. To view the ID, log on to the Alibaba Cloud Management Console, move the pointer over your profile picture in the upper-right corner, and then click Security Settings.</para>
        /// </description></item>
        /// <item><description><para><c>$roleName</c>: The name of the RAM role. To view the name, log on to the RAM console, click RAM Role Management in the navigation pane on the left, and then view the role name in the RAM Role Name list.</para>
        /// </description></item>
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
        /// <para>Specifies when to enable TDE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Enables TDE immediately.</para>
        /// </description></item>
        /// <item><description><para>1: Enables TDE during the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

        /// <summary>
        /// <para>The TDE status. Set the value to <b>enabled</b> to enable TDE.</para>
        /// <remarks>
        /// <para>You cannot disable TDE after you enable it. Enable this feature with caution.</para>
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
