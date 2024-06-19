// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceTDERequest : TeaModel {
        /// <summary>
        /// The ID of the custom key. You can call the [DescribeEncryptionKeyList](https://help.aliyun.com/document_detail/302339.html) operation to query the key ID.
        /// 
        /// > 
        /// 
        /// *   If you do not specify this parameter, [Key Management Service (KMS)](https://help.aliyun.com/document_detail/28935.html) automatically generates a key.
        /// 
        /// *   To create a custom key, you can call the [CreateKey](https://help.aliyun.com/document_detail/28947.html) operation of the KMS API.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The encryption algorithm. Default value: AES-CTR-256.
        /// 
        /// > This parameter is available only if the **TDEStatus** parameter is set to **Enabled**.
        /// </summary>
        [NameInMap("EncryptionName")]
        [Validation(Required=false)]
        public string EncryptionName { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
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
        /// The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role that you want to attach to your ApsaraDB for Redis instance. The ARN must be in the format of `acs:ram::$accountID:role/$roleName`. After the role is attached, your ApsaraDB for Redis instance can use KMS.
        /// 
        /// > 
        /// 
        /// *   `$accountID`: the ID of the Alibaba Cloud account. To view the account ID, log on to the Alibaba Cloud console, move the pointer over your profile picture in the upper-right corner of the page, and then click **Security Settings**.
        /// 
        /// *   `$roleName`: the name of the RAM role. Replace $roleName with **AliyunRdsInstanceEncryptionDefaultRole**.
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Specifies whether to enable TDE. Set the value to **Enabled**.
        /// 
        /// > TDE cannot be disabled after it is enabled. Before you enable it, evaluate whether this feature affects your business. For more information, see [Enable TDE](https://help.aliyun.com/document_detail/265913.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
