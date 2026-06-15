// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The type of the snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: a standard snapshot.</para>
        /// </description></item>
        /// <item><description><para>Flash: a Flash Snapshot.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is deprecated. standard snapshots for ESSD cloud disks now include the <a href="https://help.aliyun.com/document_detail/193667.html">Instant Access</a> feature by default at no additional cost.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. The token must be unique for each request. The <b>ClientToken</b> value must be an ASCII string of up to 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The snapshot description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Instant Access feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the Instant Access feature. This feature can be enabled only for snapshots of ESSD cloud disks.</para>
        /// </description></item>
        /// <item><description><para>false: Disables the Instant Access feature. A standard snapshot is created.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. standard snapshots for ESSD cloud disks now include the <a href="https://help.aliyun.com/document_detail/193667.html">Instant Access</a> feature by default at no additional cost.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// <para>The retention period for the Instant Access feature, in days. The snapshot is automatically deleted when this retention period expires. This parameter takes effect only when <c>InstantAccess</c> is set to <c>true</c>. Valid values: 1 to 65,535.</para>
        /// <para>Defaults to the value of <c>RetentionDays</c>.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. standard snapshots for ESSD cloud disks now include the <a href="https://help.aliyun.com/document_detail/193667.html">Instant Access</a> feature by default at no additional cost.</para>
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
        /// <para>The ID of the Resource Group to which the snapshot belongs.</para>
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
        /// <para>The retention period of the snapshot, in days. Valid values: 1 to 65,536. The snapshot is automatically deleted when the retention period expires.</para>
        /// <para>If this parameter is not specified, the snapshot is retained indefinitely.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The snapshot name must be 2 to 128 characters long. It must start with a letter or a Chinese character and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>The name cannot start with <c>http://</c> or <c>https://</c>. To avoid conflicts with auto snapshot names, the name cannot start with <c>auto</c>.</para>
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
        /// <para>This parameter is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// <para>The tags to add to the snapshot. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSnapshotRequestTag> Tag { get; set; }
        public class CreateSnapshotRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para>This parameter is not recommended. For better compatibility, use the Key parameter instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It can be an empty string, must be 128 characters or shorter, and cannot contain http\:// or https\://.</para>
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
