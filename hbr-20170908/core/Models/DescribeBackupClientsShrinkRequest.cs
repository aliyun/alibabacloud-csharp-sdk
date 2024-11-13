// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of HBR clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-*********************&quot;]</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the HBR client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_CLIENT</b>: HBR client for Elastic Compute Service (ECS) file backup</description></item>
        /// <item><description><b>CONTAINER_CLIENT</b>: HBR client for container backup</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_CLIENT</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster for the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000ge4wa61b4d337xblq</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.</description></item>
        /// <item><description>CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>129374672382xxxx</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The IDs of ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-*********************&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33738719#</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsShrinkRequestTag> Tag { get; set; }
        public class DescribeBackupClientsShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the backup vault. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the backup vault. Valid values of N: 1 to 20.</para>
            /// <list type="bullet">
            /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The tag value cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
