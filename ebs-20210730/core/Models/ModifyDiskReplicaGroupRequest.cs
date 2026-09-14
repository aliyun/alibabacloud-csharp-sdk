// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDiskReplicaGroupRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth. Unit: Kbps.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique value for this parameter from your client. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>Specifies whether to enable replication time control (RTC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: RTC is disabled.</para>
        /// </description></item>
        /// <item><description><para>true: RTC is enabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to true, RTC is enabled for the replication pair-consistent group. RTC is also enabled for all asynchronous replication pairs that are added to the group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRtc")]
        [Validation(Required=false)]
        public bool? EnableRtc { get; set; }

        /// <summary>
        /// <para>The name of the replication pair-consistent group. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myreplicagrouptest</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The recovery point objective (RPO) of the replication pair-consistent group. Unit: seconds. A value of 900 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// <para>The region ID of the replication pair-consistent group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the replication pair-consistent group. Call <a href="https://help.aliyun.com/document_detail/426614.html">DescribeDiskReplicaGroups</a> to query the IDs of replication pair-consistent groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-myreplica****</para>
        /// </summary>
        [NameInMap("ReplicaGroupId")]
        [Validation(Required=false)]
        public string ReplicaGroupId { get; set; }

    }

}
