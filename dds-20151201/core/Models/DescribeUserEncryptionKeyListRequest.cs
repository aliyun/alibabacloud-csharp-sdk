// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeUserEncryptionKeyListRequest : TeaModel {
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the specified role. Format: <c>acs:ram::$accountID:role/$roleName </c>. Default value: <c>acs:ram::$accountID:role/aliyunrdsinstanceencryptiondefaultrole</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>$accountID</c>: the Alibaba Cloud account ID. You can log on to the Alibaba Cloud Management Console, move the mouse over the profile picture in the upper-right corner, and click Security Settings to view it.</description></item>
        /// <item><description><c>$roleName</c>: the name of the RAM role. You can log on to the Resource Access Management (RAM) console, click RAM Roles in the left-side navigation pane, and view the name in the RAM role name list.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The target zone ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query available zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

    }

}
