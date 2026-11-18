// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom key. You can call the <a href="https://help.aliyun.com/document_detail/473860.html">DescribeEncryptionKeyList</a> operation to obtain the key ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service (KMS)</a> automatically generates a key.</description></item>
        /// <item><description>To create a custom key, you can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation of Key Management Service (KMS).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ad463061-992d-4195-8a94-ed63********</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption algorithm. Default value: AES-CTR-256.</para>
        /// <remarks>
        /// <para>This parameter is available only when the <b>TDEStatus</b> parameter is set to <b>Enabled</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES-CTR-256</para>
        /// </summary>
        [NameInMap("EncryptionName")]
        [Validation(Required=false)]
        public string EncryptionName { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to obtain the instance ID.</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor ARN (Alibaba Cloud Resource Name) of the RAM role to authorize. After authorization, you can use the related Key Management Service (KMS) features. Format: <c>acs:ram::$accountID:role/$roleName</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$accountID</c>: the Alibaba Cloud account ID. You can logon to the Alibaba Cloud Management Console, move the mouse over the profile picture in the upper-right corner, and click <b>Security Settings</b> to view the account ID.</description></item>
        /// <item><description><c>$roleName</c>: the name of the RAM role. Set the value to <b>AliyunRdsInstanceEncryptionDefaultRole</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The TDE status. Valid value: <b>Enabled</b>.</para>
        /// <remarks>
        /// <para>After TDE is enabled, it cannot be disabled. Evaluate the impact on your business before you enable TDE. For more information, see <a href="https://help.aliyun.com/document_detail/265913.html">Enable Transparent Data Encryption (TDE)</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
