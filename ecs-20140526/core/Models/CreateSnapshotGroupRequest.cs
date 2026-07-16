// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of a disk for which you want to create a snapshot-consistent group. You can specify disk IDs across instances within the same zone. Valid values of N: 1 to 16. A snapshot-consistent group can contain up to 16 disks with a total capacity of up to 32 TiB.</para>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This parameter cannot be specified together with <c>ExcludeDiskId.N</c>.</description></item>
        /// <item><description>If you specify <c>InstanceId</c>, this parameter can only be set to disks attached to the specified instance and no longer supports specifying disk IDs across multiple instances.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The ID of a disk in the instance for which you do not want to create a snapshot. After you specify this parameter, the snapshot-consistent group does not contain the snapshot of the specified disk. Valid values of N: 1 to 16.</para>
        /// <para>Default value: null, which indicates that snapshots are created for all disks in the instance.</para>
        /// <remarks>
        /// <para>This parameter cannot be specified together with <c>DiskId.N</c>.</para>
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
        /// <para>Specifies whether to enable snapshot instant access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables snapshot instant access.</description></item>
        /// <item><description>false: disables snapshot instant access.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots of enterprise SSDs are upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">instant access by default</a>. No additional configuration or fees are required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// <para>The number of days for which the snapshot instant access feature remains active. Unit: days. Valid values: 1 to 65535.</para>
        /// <para>This parameter takes effect only when <c>InstantAccess=true</c>. The snapshot instant access feature is automatically shutdown when the specified duration expires.</para>
        /// <para>Default value: null, which indicates that the instant access duration is the same as the snapshot release period.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots of enterprise SSDs are upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">instant access by default</a>. No additional configuration or fees are required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstantAccessRetentionDays")]
        [Validation(Required=false)]
        public int? InstantAccessRetentionDays { get; set; }

        /// <summary>
        /// <para>The name of the snapshot-consistent group. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, periods (.), underscores (_), hyphens (-), and colons (:).</para>
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
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSnapshotGroupRequestTag> Tag { get; set; }
        public class CreateSnapshotGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the snapshot-consistent group. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the snapshot-consistent group. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
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
