// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard snapshot.</description></item>
        /// <item><description>Flash: local snapshot.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is about to be deprecated. Standard snapshots for enterprise SSD disks (excluding standard SSD) have been upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">active by default</a>. No additional configuration is required, and no extra costs are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the snapshot. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk. You can call the DescribeDisks operation and filter by InstanceId to query the cloud disks attached to the instance. The cloud disk used to create a snapshot must be in the In Use or Available state. An available cloud disk must have been previously attached to an ECS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the snapshot instant access feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the feature. Only enterprise SSD disks (excluding standard SSD) support this feature.</description></item>
        /// <item><description>false: disables the feature. A standard snapshot is created.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots for enterprise SSD disks (excluding standard SSD) have been upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">active by default</a>. No additional configuration is required, and no extra costs are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// <para>Settings for the retention period of the snapshot instant access feature. The snapshot is subject to automatic release when the retention period expires. This parameter takes effect only when <c>InstantAccess</c> is set to <c>true</c>. Unit: days. Valid values: 1 to 65535.</para>
        /// <para>Default value: the value of the <c>RetentionDays</c> parameter.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Standard snapshots for enterprise SSD disks (excluding standard SSD) have been upgraded to <a href="https://help.aliyun.com/document_detail/193667.html">active by default</a>. No additional configuration is required, and no extra costs are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstantAccessRetentionDays")]
        [Validation(Required=false)]
        public int? InstantAccessRetentionDays { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the snapshot belongs.</para>
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
        /// <para>Settings for the retention period of the snapshot. Unit: days. Valid values: 1 to 65536. The snapshot is subject to automatic release when the retention period expires.</para>
        /// <para>Default value: empty, which indicates that the snapshot is not subject to automatic release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The name of the snapshot. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and can contain Unicode letters (including English and Chinese characters) and ASCII digits (0-9). It can contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with http:// or https://. To prevent name conflicts with automatic snapshots, it cannot start with <c>auto</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

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
        public List<CreateSnapshotRequestTag> Tag { get; set; }
        public class CreateSnapshotRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the snapshot. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the snapshot. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
