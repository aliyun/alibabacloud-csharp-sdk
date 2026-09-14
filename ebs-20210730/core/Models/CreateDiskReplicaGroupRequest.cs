// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiskReplicaGroupRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth in Kbps.</para>
        /// <remarks>
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique value from your client for this parameter. The \<c>ClientToken\\</c> parameter value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the replication pair-consistent group. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the region where the disaster recovery site is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the disaster recovery site is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable replication time control (RTC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Disable RTC.</para>
        /// </description></item>
        /// <item><description><para>true: Enable RTC.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If you set this parameter to true, RTC is enabled for the replication pair-consistent group. RTC is also enabled for all asynchronous replication pairs that are added to the group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRtc")]
        [Validation(Required=false)]
        public bool? EnableRtc { get; set; }

        /// <summary>
        /// <para>The name of the replication pair-consistent group. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myreplicagrouptest</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The recovery point objective (RPO) of the replication pair-consistent group, in seconds. The only supported value is 900.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// <para>The ID of the region where the replication pair-consistent group resides. This is the same as the region of the production site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the replication pair-consistent group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvs*******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the production site is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("SourceZoneId")]
        [Validation(Required=false)]
        public string SourceZoneId { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskReplicaGroupRequestTag> Tag { get; set; }
        public class CreateDiskReplicaGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
