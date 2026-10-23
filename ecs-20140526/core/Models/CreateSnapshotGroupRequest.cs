// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the snapshot-consistent group. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the disk for which you want to create a snapshot-consistent group. You can specify multiple disk IDs across instances in the same zone. Valid values of N: 1 to 128. A single snapshot-consistent group can contain up to 128 disks with a total capacity of up to 256 TiB.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter and <c>ExcludeDiskId.N</c> cannot be set at the same time.</description></item>
        /// <item><description>If you set <c>InstanceId</c>, you can set this parameter only to the IDs of disks attached to the specified instance. Setting multiple cross-instance disk IDs is no longer supported.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The ID of the disk for which you do not want to create a snapshot in the instance. After you specify a disk ID, the created snapshot-consistent group does not contain the snapshot of the disk. Valid values of N: 1 to 128.</para>
        /// <para>Default value: empty, which indicates that snapshots are created for all disks in the instance.</para>
        /// <remarks>
        /// <para>This parameter and <c>DiskId.N</c> cannot be set at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-j6cf7l0ewidb78lq****</para>
        /// </summary>
        [NameInMap("ExcludeDiskId")]
        [Validation(Required=false)]
        public List<string> ExcludeDiskId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-j6ca469urv8ei629****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the snapshot instant access feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the feature.</description></item>
        /// <item><description>false: disables the feature.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots of ESSDs are upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">instant access by default</a>. You do not need to configure this parameter, and no additional fees are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// <para>Sets the retention period for the snapshot instant access feature. Unit: days. Valid values: 1 to 65535.</para>
        /// <para>This parameter takes effect only when <c>InstantAccess</c> is set to true. The snapshot instant access feature is automatically disabled when the specified period expires.</para>
        /// <para>Default value: empty, which indicates that the retention period is the same as the snapshot release time.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots of ESSDs are upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">instant access by default</a>. You do not need to configure this parameter, and no additional fees are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstantAccessRetentionDays")]
        [Validation(Required=false)]
        public int? InstantAccessRetentionDays { get; set; }

        /// <summary>
        /// <para>The name of the snapshot-consistent group. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), underscores (_), hyphens (-), and colons (:).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the snapshot-consistent group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSnapshotGroupRequestTag> Tag { get; set; }
        public class CreateSnapshotGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the snapshot-consistent group. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the snapshot-consistent group. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
