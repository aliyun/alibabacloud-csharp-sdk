// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CheckCloudResourceAuthorizedRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
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
        /// <para>The global resource descriptor Alibaba Cloud Resource Name (ARN) of the role to be authorized. After the role is granted authorization, the related KMS can be used. Format: <c>acs:ram::$accountID:role/$roleName</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$accountID</c>: the ID of the Alibaba Cloud account. Log on to the Alibaba Cloud Management Console, move the mouse pointer over the profile picture in the upper-right corner, and then click <b>Security Settings</b> to view the account ID.</description></item>
        /// <item><description><c>$roleName</c>: the name of the RAM role. Set this value to <b>AliyunRdsInstanceEncryptionDefaultRole</b>.</description></item>
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

    }

}
