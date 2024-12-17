// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CheckCloudResourceAuthorizedRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the ID of the instance.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role that you want to attach to your ApsaraDB for Redis instance. The ARN must be in the format of <c>acs:ram::$accountID:role/$roleName</c>. After the role is attached, your ApsaraDB for Redis instance can use KMS.</para>
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

    }

}
