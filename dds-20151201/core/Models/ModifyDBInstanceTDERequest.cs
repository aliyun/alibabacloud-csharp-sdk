// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
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
        /// Custom keys are supported only in the following regions. In other regions, the default key is used for encryption.</para>
        /// <list type="bullet">
        /// <item><description>Singapore (ap-southeast-1)</description></item>
        /// <item><description>Hangzhou (cn-hangzhou)</description></item>
        /// <item><description>Shanghai (cn-shanghai)</description></item>
        /// <item><description>Beijing (cn-beijing)</description></item>
        /// <item><description>Shenzhen (cn-shenzhen)</description></item>
        /// <item><description>Hong Kong (China) (cn-hongkong)</description></item>
        /// <item><description>Malaysia (ap-southeast-3)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values: <b>aes-256-cbc</b>.</para>
        /// <remarks>
        /// <para>This parameter is available only when the <b>TDEStatus</b> parameter is set to <b>enabled</b>.</para>
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
        /// <para>The ARN of the specified role. Format: <c>acs:ram::$accountID:role/$roleName</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$accountID</c>: the ID of the Alibaba Cloud account. You can view the ID by logging on to the Alibaba Cloud Management Console, moving the pointer over the profile picture in the upper-right corner, and clicking Security Settings.</description></item>
        /// <item><description><c>$roleName</c>: the name of the RAM role. You can view the name by logging on to the Resource Access Management (RAM) console, clicking RAM Roles in the left-side navigation pane, and viewing the RAM role name list.</description></item>
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
        /// <para>The time to modify the Transparent Data Encryption (TDE) status of the MongoDB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: immediately.</para>
        /// </description></item>
        /// <item><description><para>1: within the O&amp;M window.</para>
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
        /// <para>The TDE status. Valid values: <b>enabled</b>, which indicates that TDE is enabled.</para>
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
