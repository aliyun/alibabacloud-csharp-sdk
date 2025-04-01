// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceTDERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom key. You can call the <a href="https://help.aliyun.com/document_detail/473860.html">DescribeEncryptionKeyList</a> operation to query the key ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service (KMS)</a> automatically generates a key.</para>
        /// </description></item>
        /// <item><description><para>To create a custom key, you can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation of the KMS API.</para>
        /// </description></item>
        /// </list>
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
        /// <para>This parameter is available only if the <b>TDEStatus</b> parameter is set to <b>Enabled</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES-CTR-256</para>
        /// </summary>
        [NameInMap("EncryptionName")]
        [Validation(Required=false)]
        public string EncryptionName { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the ID of the instance.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role that you want to attach to your Tair (Redis OSS-compatible) instance. The ARN must be in the format of <c>acs:ram::$accountID:role/$roleName</c>. After the role is attached, your Tair (Redis OSS-compatible) instance can use KMS.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>$accountID</c>: the ID of the Alibaba Cloud account. To view the account ID, log on to the Alibaba Cloud console, move the pointer over your profile picture in the upper-right corner of the page, and then click <b>Security Settings</b>.</para>
        /// </description></item>
        /// <item><description><para><c>$roleName</c>: the name of the RAM role. Replace $roleName with <b>AliyunRdsInstanceEncryptionDefaultRole</b>.</para>
        /// </description></item>
        /// </list>
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
        /// <para>Specifies whether to enable TDE. Set the value to <b>Enabled</b>.</para>
        /// <remarks>
        /// <para>TDE cannot be disabled after it is enabled. Before you enable it, evaluate whether this feature affects your business. For more information, see <a href="https://help.aliyun.com/document_detail/265913.html">Enable TDE</a>.</para>
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
