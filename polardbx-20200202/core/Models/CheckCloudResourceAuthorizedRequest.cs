// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CheckCloudResourceAuthorizedRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor ARN (Alibaba Cloud Resource Name) of the authorized role. After the authorization of this role is complete, the related KMS can be used. Format: acs:ram::$accountID:role/$roleName.</para>
        /// <list type="bullet">
        /// <item><description>$accountID: the Alibaba Cloud account ID. To view the ID, logon to the Alibaba Cloud Management Console, move the mouse over the profile picture in the upper-right corner, and then click Security Settings.</description></item>
        /// <item><description>$roleName: the RAM role name. The value is fixed as AliyunRdsInstanceEncryptionDefaultRole.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
